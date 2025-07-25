using Microsoft.AspNetCore.Mvc;

namespace GymTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TreinosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API funcionando: lista de treinos.");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok("API funcionando: lista de treinos.");
        }
        [HttpPost]
        public IActionResult Post([FromBody] string treino)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, treino);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string treino)
        {
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
