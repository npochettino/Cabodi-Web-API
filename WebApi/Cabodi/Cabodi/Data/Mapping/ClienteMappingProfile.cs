using AutoMapper;
using Cabodi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cabodi.Data
{
    public class ClienteMappingProfile : Profile
    {
        public ClienteMappingProfile()
        {
            CreateMap<Cliente, ClienteModel>().IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
            //.ForMember(dest => dest.USR_VTMCLH_CONAPP, opt => opt.MapFrom(src => src.USR_VTMCLH_CONAPP))
            //.ForMember(dest => dest.VTMCLH_NOMBRE, opt => opt.MapFrom(src => src.VTMCLH_NOMBRE))
            //.ForMember(dest => dest.VTMCLH_NROCTA, opt => opt.MapFrom(src => src.VTMCLH_NROCTA));
        }
    }
}