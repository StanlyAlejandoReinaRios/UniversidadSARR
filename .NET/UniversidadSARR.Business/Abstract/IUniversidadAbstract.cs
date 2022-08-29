using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Models.DTO;
using Universidad.Models.Entities;

namespace UniversidadSARR.Business.Abstract
{
    public interface IUniversidadAbstract
    {
        Task<bool> GuardarCambios();

        Task<List<Usuario>> ListaUsuarios();

        Task<Usuario> ObtenerUsuariosPorNombre(string nombre);

        Task<Usuario> ObtenerUsuariosPorId(int UsuarioId);

        void Crear(UsuarioDTO request);

        void EditarUsuario(/*Usuario usuario*/ UpdateDTO request);

        Task EliminarUsuario(int id);


    }
}
