using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WebApplication1;

namespace WebService.Models
{
    [DataContract]
    public class ProductModel
    {
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public decimal Price { get; private set; }
        [DataMember]
        public int CurrentStock { get; private set; }

        public ProductModel(Product p, Stock s)
        {
            this.Id = p.Id;
            this.Name = p.Name;
            this.Price = p.Price;
            this.CurrentStock = s.Amount;
        }
    }
}