using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        [Route("/shirts")]
        public string GetShirts() 
        {
            return "Reading all the shirts";
        }

        [HttpGet]
        [Route("/shirts/{id}")]
        public string GetShirtById(int id)
        {
            return $"Reading Shirt :{id}";
        }

        [HttpPost]
        [Route("/shirts")]
        public string CreateShirt()
        {
            return "creatig a Shirt";
        }

        [HttpPut]
        [Route("/shirts/{id}")]
        public string UpdateShirt(int id) 
        {
            return $"Updating Shirt :{id}";
        }

        [HttpDelete]
        [Route("/shirts/{id}")]
        public string DeleteShirt(int id) 
        {
            return $"Deleting Shirt :{id}";
        }
    }
}
