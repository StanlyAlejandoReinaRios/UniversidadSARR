using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Models;
using Universidad.Models.DTO;
using Universidad.Models.Entities;
using UniversidadSARR.Business.Abstract;

namespace UniversidadSARR.Business.Services
{
    public class UniversidadServices : IUniversidadAbstract
    {
            private readonly ApplicationDbContext _Context;
            //private readonly IMapper _mapper;
            public UniversidadServices(ApplicationDbContext context/*, IMapper mapper*/)
            {
                //_mapper = mapper;
                _Context = context;
            }

            public async Task<bool> GuardarCambios()
            {
                return await _Context.SaveChangesAsync() > 0;
            }

            public async Task<List<Usuario>> ListaUsuarios()
            {
                var result = _Context.Usuarios.ToListAsync();

                return await result;
            }



            public async Task<Usuario> ObtenerUsuariosPorNombre(string nombre)
            {
                var result = _Context.Usuarios.FirstOrDefaultAsync(x => x.Nombre == nombre);

                return await result;
            }

            public async Task<Usuario> ObtenerUsuariosPorId(int UsuarioId)
            {
                var result = _Context.Usuarios.FirstOrDefaultAsync(x => x.Id == UsuarioId);

                return await result;
            }

            public void Crear(UsuarioDTO request)
            {
            //var usuario = _mapper.Map<Usuario>(request);

            var usuario = new Usuario()
            {
                Nombre = request.Nombre,
                Telefono = request.Telefono,
                Correo = request.Correo,
                TipoUsuarioId = request.TipoUsuarioId
            };
                _Context.Add(usuario);
              
            }

            public void EditarUsuario(UpdateDTO request /*Usuario usuario*/)
            {
            var usuario = new Usuario()
            {
                Id = request.Id,
                Nombre = request.Nombre,
                Telefono = request.Telefono,
                Correo = request.Correo,
                TipoUsuarioId = request.TipoUsuarioId
            };

            _Context.Update(usuario);
            }

            public async Task EliminarUsuario(int id)
            {
                var usuario = await ObtenerUsuariosPorId(id);
                _Context.Remove(usuario);
                await _Context.SaveChangesAsync();
            }
        }
    }

