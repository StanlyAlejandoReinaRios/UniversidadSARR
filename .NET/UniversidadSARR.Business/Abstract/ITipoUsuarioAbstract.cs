using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Models.Entities;

namespace UniversidadSARR.Business.Abstract
{
    public interface ITipoUsuarioAbstract
    {
        Task<List<TipoUsuario>> ListaUsuarios();

        Task<TipoUsuario> ObtenerTipoUsuarioPorId(int TipoUsuarioId);
    }
}
