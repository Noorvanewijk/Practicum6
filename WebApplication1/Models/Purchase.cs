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
        public int Amount { get; private set; }
        [DataMember]
        public decimal Price { get; private set; }
        [DataMember]
        public decimal TotalPrice { get; private set; }

        public Purchase(int productId, int amount)
        {
            var ps = new ProductService();
            var product = ps.GetProductById(productId);

            this.ProductId = product.Id;
            this.Amount = amount;
            this.Price = product.Price;
            this.TotalPrice = product.Price * amount;
        }
    }
}