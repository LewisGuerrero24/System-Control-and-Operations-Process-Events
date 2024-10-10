using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiPrueba.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
         [HttpGet]
        public IActionResult GetProduct()
        {
            // Simulando un producto
            var product = new 
            {
                Id = 2,
                Name = "Computador portátil",
                Price = 10.0
            };

            return Ok(product);
        }
    }
}