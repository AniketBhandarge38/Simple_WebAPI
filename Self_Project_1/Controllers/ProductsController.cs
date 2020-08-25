using Self_Project_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Self_Project_1.Controllers
{
    public class ProductsController : ApiController
    {

        Product[] products = new Product[] {

        new Product { Id=1,Name="Acer Aspire", Category="Gaming Laptop",Price=60000 },
        new Product { Id=2,Name="Dell Inspiron", Category="Laptop", Price=55000}
        
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }


        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id==id);
            if(product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
