using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testMvcActionCallApi.Models;


namespace testMvcActionCallApi.Controllers.api
{
    public class TestController : ApiController
    {
        List<Product> product;

        public TestController()
        {
            product = new List<Product>();

            product.Add(new Product() { id = 1, name = "apple", price = 10 });
            product.Add(new Product() { id = 2, name = "banana", price = 20 });
            product.Add(new Product() { id = 3, name = "cclemon", price = 30 });
        }

        [Route("api/Test/Get")]
        public IEnumerable<Product> Get()
        {
            return product;
        }
    }
}
