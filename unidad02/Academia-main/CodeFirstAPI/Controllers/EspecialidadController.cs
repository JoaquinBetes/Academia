using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadController : ControllerBase
    {
        private AcademiaContext _context;

        public EspecialidadController(AcademiaContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Especialidad> Get() => _context.Especialidades.ToList();
    }
}
