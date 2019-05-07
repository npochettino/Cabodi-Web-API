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
            CreateMap<Cliente, ClienteModel>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter()
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.USR_VTMCLH_CONAPP))
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.VTMCLH_NOMBRE))
                .ForMember(dest => dest.NroVendedor, opt => opt.MapFrom(src => src.VTMCLH_NRODIS))
                .ForMember(dest => dest.NroCuenta, opt => opt.MapFrom(src => src.VTMCLH_NROCTA));
        }
    }
}