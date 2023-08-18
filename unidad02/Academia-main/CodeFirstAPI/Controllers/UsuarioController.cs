using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private AcademiaContext _context;

        public UsuarioController(AcademiaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Usuario> Get() => _context.Usuarios.ToList();

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
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
