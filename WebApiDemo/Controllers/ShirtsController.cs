using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Now We Dont need to mention in each methodx
    public class ShirtsController : ControllerBase
    {
        [HttpGet]
        //[Route("/shirts")]
        public string GetShirts() 
        {
            return "Reading all the shirts";
        }

        [HttpGet("{id}")]
        //[Route("/shirts/{id}")]
        public string GetShirtById(int id)
        {
            return $"Reading Shirt :{id}";
        }

        [HttpPost]
        //[Route("/shirts")]
        public string CreateShirt()
        {
            return "creatig a Shirt";
        }

        [HttpPut("{id}")]
        //[Route("/shirts/{id}")]
        public string UpdateShirt(int id) 
        {
            return $"Updating Shirt :{id}";
        }

        [HttpDelete("{id}")]
        //[Route("/shirts/{id}")]
        public string DeleteShirt(int id) 
        {
            return $"Deleting Shirt :{id}";
        }
    }
}
