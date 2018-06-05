using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService;
using WebService.Models;

namespace WebService.Services
{
    public class TransactionService
    {
        public List<TransactionModel> GetAllTransactions()
        {
            using (var context = new databaseEntities())
            {
                var result = new List<TransactionModel>();
                (from x in context.Transactions select x).ToList().ForEach(x => result.Add(new TransactionModel(x)));
                return result;
            }
        }

        public TransactionModel GetTransactionById(int id)
        {
            try
            {
                using (var context = new databaseEntities())
                {
                    return new TransactionModel((from x in context.Transactions where x.Id == id select x).First());
                }
            }
            catch
            {
                return null;
            }
        }

        public Transaction CreateNewTransaction(int userId, List<int> productIds, List<int> productAmounts)
        {
            using (var context = new databaseEntities())
            {
                var u = (from x in context.Users where x.Id == userId select x).First();
                var purchases = new List<Purchase>();

                for (int i = 0; i < productIds.Count; i++)
                {
                    var currentId = productIds[i];
                    var currentAmount = productAmounts[i];
                    purchases.Add(new Purchase(currentId, currentAmount, context.Products.Where(x => x.Id == currentId).First().Price));
                }

                var totalPrice = purchases.Sum(x => x.TotalPrice);
                var stocks = (from x in context.Stocks from y in productIds where x.ProductId == y select x);

                if (!(u.Funds >= totalPrice))
                {
                    return null;
                }
                
                for (int i = 0; i < productIds.Count; i++)
                {
                    var currentId = productIds[i];
                    var currentAmount = productAmounts[i];
                    var stock = stocks.Single(x => x.Id == currentId);

                    if (stock.Amount < currentAmount)
                    {
                        return null;
                    }
                }

                var t = new Transaction { UserId = userId };
                context.Transactions.Add(t);

                u.Funds -= totalPrice;

                for (int i = 0; i < productIds.Count; i++)
                {
                    var currentId = productIds[i];
                    var currentAmount = productAmounts[i];
                    var currentPrice = (from x in context.Products where x.Id == currentId select x).First().Price;
                    (from y in stocks where y.ProductId == currentId select y).First().Amount -= currentAmount;
                    context.TransactionRows.Add(new TransactionRow { ProductId = currentId, Amount = currentAmount, TransactionId = t.Id, Price = currentPrice });
                }

                context.SaveChanges();

                return t;
            }
        }
    }
}