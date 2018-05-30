using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;
using WebService.Services;

namespace WebService.Controllers
{
    public class ProductsController : ApiController
    {
        public List<ProductModel> GetAvailible()
        {
            return new ProductService().GetAllAvailibleProducts();
        }
    }
}
