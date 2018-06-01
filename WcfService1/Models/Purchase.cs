using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WebService.Services;

namespace WebService.Models
{
    [DataContract]
    public class Purchase
    {
        [DataMember]
        public int ProductId { get;  private set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public decimal Price { get; private set; }
        [DataMember]
        public decimal TotalPrice { get; set; }

        public Purchase(int id, int amount, decimal price)
        {
            this.ProductId = id;
            this.Amount = amount;
            this.Price = price;
            this.TotalPrice = price * amount;
        }
    }
}