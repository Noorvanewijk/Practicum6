using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1;
using WebService.Models;

namespace WebService.Services
{
    public class ProductService
    {
        public List<ProductModel> GetAllAvailibleProducts()
        {
            using (var context = new databaseEntities())
            {
                var result = new List<ProductModel>();
                (from x in context.Products from y in context.Stocks where y.Amount > 0 && y.ProductId == x.Id select y).ToList().ForEach(x => result.Add(new ProductModel(x.Product, x)));
                return result;
            }
        }

        public ProductModel GetProductById(int id)
        {
            using (var context = new databaseEntities())
            {
                Stock s = (from x in context.Stocks where x.ProductId == id select x).First();
                Product p = s.Product;
                return new ProductModel(p, s);
            }
        }
    }
}