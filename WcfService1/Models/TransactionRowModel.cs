using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WcfService1;

namespace WebService.Models
{
    [DataContract]
    public class TransactionRowModel
    {
        [DataMember]
        private string ProductName;

        [DataMember]
        private decimal Price;

        [DataMember]
        private int AmountPurchased;

        [DataMember]
        private decimal TotalPrice;

        public TransactionRowModel(TransactionRow tr)
        {
            this.ProductName = tr.Product.Name;
            this.Price = tr.Price;
            this.AmountPurchased = tr.Amount;
            this.TotalPrice = tr.Price * tr.Amount;
        }
    }
}