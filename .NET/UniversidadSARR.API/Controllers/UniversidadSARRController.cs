using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Universidad.Models.DTO;
using Universidad.Models.Entities;
using UniversidadSARR.Business.Abstract;

namespace UniversidadSARR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversidadSARRController : ControllerBase
    {
        private readonly IUniversidadAbstract _context;

        public UniversidadSARRController(IUniversidadAbstract context)
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

        [HttpGet("Nombre")]

        public async Task<ActionResult> GetUsuarioByName(string Nombre)
        {
            var result = _context.ObtenerUsuariosPorNombre(Nombre);

            return Ok(await result);
        }



        [HttpPost]

        public async Task<ActionResult> Create(UsuarioDTO usuarioDto)
        {
            if (ModelState.IsValid)
            {
                _context.Crear(usuarioDto);
                await _context.GuardarCambios();
                return Ok(await _context.ListaUsuarios());
            }
            else
            {
                return BadRequest("El modelo no es valido");
            }
        }

        [HttpPut("{UsuarioId}")]
        public async Task<IActionResult> PutUsuario(int UsuarioId, UpdateDTO usuario)
        {
            if (UsuarioId != usuario.Id)
            {
                return BadRequest("si");
            }

            _context.EditarUsuario(usuario);
            await _context.GuardarCambios();


            return Ok(await _context.ObtenerUsuariosPorId(UsuarioId));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.ObtenerUsuariosPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }

            await _context.EliminarUsuario(id);

            return Ok(await _context.ListaUsuarios());
        }
    }
}
