using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Models;
using Universidad.Models.Entities;
using UniversidadSARR.Business.Abstract;

namespace UniversidadSARR.Business.Services
{
    public class TipoUsuariosServices : ITipoUsuarioAbstract
    {
        private readonly ApplicationDbContext _Context;

        public TipoUsuariosServices(ApplicationDbContext context/*, IMapper mapper*/)
        {
            //_mapper = mapper;
            _Context = context;
        }

        public async Task<List<TipoUsuario>> ListaUsuarios()
        {
            var result = _Context.TipoUsuarios.ToListAsync();

            return await result;
        }

        public async Task<TipoUsuario> ObtenerTipoUsuarioPorId(int TipoUsuarioId)
        {
            var result = _Context.TipoUsuarios.FirstOrDefaultAsync(x => x.Id == TipoUsuarioId);

            return await result;
        }
    }
}
