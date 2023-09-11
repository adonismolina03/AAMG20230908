using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AAMG20230908.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MtariculasController : ControllerBase
    {
        static List<Matricula> data = new List<Matricula>();
        public class Matricula
        {
            public int Id { get; set; }
            public string Alumno { get; set; }
            public string Grado { get; set; }
            public string Seccion { get; set; }
        }

        // GET api/<MtariculasController>/5
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= data.Count)
            {
                return NotFound(); 
            }

            return Ok(data[id]);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Post([FromBody] Matricula nuevaMatricula)
        {
            if (nuevaMatricula == null)
            {
                return NotFound();
            }
            data.Add(nuevaMatricula);   
            return Ok(data);
        }

        // PUT api/<MtariculasController>/5
        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Matricula matriculaActualizada)
        {
            if (id < 0 || id >= data.Count || matriculaActualizada == null)
            {
                return BadRequest(); 
            }

            data[id] = matriculaActualizada;
            return Ok();
        }

    }
}
