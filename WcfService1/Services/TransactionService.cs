using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1;
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
            using (var context = new databaseEntities())
            {
                var t = (from x in context.Transactions where x.Id == id select x).First();
                return new TransactionModel(t);
            }
        }

        public Transaction CreateNewTransaction(int userId, List<Purchase> purchases)
        {
            using (var context = new databaseEntities())
            {
                var u = (from x in context.Users where x.Id == userId select x).First();
                var totalPrice = purchases.Sum(x => x.TotalPrice);
                var stocks = (from x in context.Stocks from y in purchases where x.ProductId == y.ProductId select x);

                if (!(u.Funds >= totalPrice))
                {
                    return null;
                }

                if (!(purchases.All(x => stocks.All(y => y.Amount >= x.Amount))))
                {
                    return null;
                }

                var t = new Transaction { UserId = userId };
                context.Transactions.Add(t);

                u.Funds -= totalPrice;
                purchases.ForEach(x => {
                    (from y in stocks where y.ProductId == x.ProductId select y).First().Amount -= x.Amount;
                    context.TransactionRows.Add(new TransactionRow { ProductId = x.ProductId, Amount = x.Amount, TransactionId = t.Id, Price = x.Price });
                });

                context.SaveChanges();

                return t;
            }
        }
    }
}