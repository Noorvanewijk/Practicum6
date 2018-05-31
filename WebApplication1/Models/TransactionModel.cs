using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WebApplication1;

namespace WebService.Models
{
    [DataContract]
    public class TransactionModel
    {
        [DataMember]
        private int Id;

        [DataMember]
        private UserModel Buyer;

        [DataMember]
        private List<TransactionRowModel> PurchasedProducts;

        [DataMember]
        private decimal TotalPrice;

        public TransactionModel(Transaction t)
        {
            this.Id = t.Id;
            this.Buyer = new UserModel(t.User);
            this.PurchasedProducts = new List<TransactionRowModel>();
            t.TransactionRows.ToList().ForEach(x => PurchasedProducts.Add(new TransactionRowModel(x)));
            this.TotalPrice = t.TransactionRows.Sum(x => (x.Price * x.Amount));
        }
    }
}