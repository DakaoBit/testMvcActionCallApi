using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testMvcActionCallApi.Models;

namespace testMvcActionCallApi.Controllers
{
    public class ProductController : ApiController
    {
        List<Product> product;

        public ProductController()
        {
            product = new List<Product>();

            product.Add(new Product() { id = 1, name = "apple", price = 10 });
            product.Add(new Product() { id = 2, name = "banana", price = 20 });
            product.Add(new Product() { id = 3, name = "cclemon", price = 30 });
        }

        [Route("api/Product/Get")]
        public IEnumerable<Product> Get()
        {
           return product;
        }
    }
}
