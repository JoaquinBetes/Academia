using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private AcademiaContext _context;

        public PersonaController(AcademiaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Persona> Get() => _context.Personas.ToList();

        [HttpPost]
        public IActionResult Post([FromBody] Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Personas.Add(persona);
                _context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

    }
}
