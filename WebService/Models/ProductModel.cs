using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Models
{
    [DataContract]
    public class ProductModel
    {
        [DataMember]
        private int id;
        [DataMember]
        private string name;
        [DataMember]
        private decimal price;

        public ProductModel(Product p)
        {
            this.id = p.Id;
            this.name = p.Name;
            this.price = p.Price;
        }
    }
}