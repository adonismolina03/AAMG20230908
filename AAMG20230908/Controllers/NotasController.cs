using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AAMG20230908.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        static List<object> data = new List<object>();
        // GET: api/<TestsController>
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<object> Get()
        {
            return data;
        }

        // POST api/<TestsController>
        [Authorize]
        [HttpPost]
        public IActionResult Post(string name, string lastname)
        {
            data.Add(new { name, lastname });
            return Ok(data);
        }


    }
}
