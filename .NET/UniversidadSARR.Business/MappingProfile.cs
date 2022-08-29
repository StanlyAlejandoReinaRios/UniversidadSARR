using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad.Models.DTO;
using Universidad.Models.Entities;

namespace UniversidadSARR.Business
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UsuarioDTO, Usuario>().ForMember(d => d.Nombre, o => o.MapFrom(d => d.Nombre))
                                .ForMember(d => d.Telefono, o => o.MapFrom(d => d.Telefono))
                                .ForMember(d => d.Correo, o => o.MapFrom(d => d.Correo));

        }
    }
}
