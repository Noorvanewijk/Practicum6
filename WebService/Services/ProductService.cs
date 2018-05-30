using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Models;

namespace WebService.Services
{
    public class ProductService
    {
        public List<ProductModel> GetAllAvailibleProducts()
        {
            using (var context = new dbEntities())
            {
                var result = new List<ProductModel>();
                (from x in context.Products from y in context.Stocks where y.Amount > 0 && y.ProductId == x.Id select x).ToList().ForEach(x => result.Add(new ProductModel(x)));
                return result;
            }
        }

        public Product GetProductById(int id)
        {
            using (var context = new dbEntities())
            {
                return (from x in context.Products where x.Id == id select x).First();
            }
        }
    }
}