using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using WebService.Models;
using WebService.Services;

namespace WebService.Controllers
{
    public class ProductsController : Controller
    {
        internal ProductService service = new ProductService();

        public List<ProductModel> GetAllProducts()
        {
            return service.GetAllAvailibleProducts();
        }

        public ProductModel GetProductById(int id)
        {
            return service.GetProductById(id);
        }
    }
}
