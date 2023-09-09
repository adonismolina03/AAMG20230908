using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AAMG20230908.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MtariculasController : ControllerBase
    {
        static List<object> data = new List<object>();

        //FALTA
        // GET api/<MtariculasController>/5
        [Authorize]
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [Authorize]
        [HttpPost]
        public IActionResult Post(string name, string lastname)
        {
            data.Add(new { name, lastname });
            return Ok(data);
        }

        //FALTA
        // PUT api/<MtariculasController>/5
        [Authorize]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

    }
}
