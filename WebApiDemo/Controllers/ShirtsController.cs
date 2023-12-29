using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    //[API]
    [ApiController]
    [Route("api/[controller]")] 
    public class ShirtsController : ControllerBase
    {

        private List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt{ShirtId = 1 , Brand="Nike", Color="Pink", Gender="Men" , Price= 90 , Size=10},
            new Shirt{ShirtId = 2 , Brand="Adidas", Color="black", Gender="Men" , Price= 960 , Size=17},
            new Shirt{ShirtId = 3 , Brand="Nike", Color="Pink", Gender="Women" , Price= 907 , Size=8},
            new Shirt{ShirtId = 4 , Brand="PinkVilla", Color="Purple", Gender="Women" , Price= 906 , Size=9},

        };
        [HttpGet]
        //[Route("/shirts")]
        public IActionResult GetShirts()
        {
            return Ok("Reading all the shirts");
        }

        [HttpGet("{id}")]
        //[Route("/shirts/{id}")]
        public IActionResult GetShirtById(int id)
        {
            if (id < 0)
                return BadRequest();

            var shirt = shirts.FirstOrDefault(x => x.ShirtId == id);
            if (shirt == null)
                return NotFound();
            return Ok(shirt);
        }

        [HttpPost]
        //[Route("/shirts")]
        public IActionResult CreateShirt([FromBody] Shirt shirt) //JSon
        //public IActionResult CreateShirt([FromForm] Shirt shirt) //Body Key-value
        {
            return Ok("creatig a Shirt");
        }

        [HttpPut("{id}")]
        //[Route("/shirts/{id}")]
        public IActionResult UpdateShirt(int id)
        {
            return Ok($"Updating Shirt :{id}");
        }

        [HttpDelete("{id}")]
        //[Route("/shirts/{id}")]
        public IActionResult DeleteShirt(int id)
        {
            return Ok($"Deleting Shirt :{id}");
        }
    }
}
















