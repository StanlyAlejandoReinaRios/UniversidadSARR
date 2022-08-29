using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversidadSARR.Business.Abstract;

namespace UniversidadSARR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private readonly ITipoUsuarioAbstract _context;

        public TipoUsuarioController(ITipoUsuarioAbstract context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult> GetUsuarios()
        {
            var result = _context.ListaUsuarios();

            if (result == null)
            {
                return BadRequest("No hay datos");
            }

            return Ok(await result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetTypeUsuariobyid(int id)
        {
            var result = _context.ObtenerTipoUsuarioPorId(id);

            return Ok(await result);
        }

    }
}
