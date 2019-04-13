using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Cabodi.Models;
using Cabodi.Models.Input;

namespace Cabodi.Data.Mapping
{
    public class PreventaMappingProfile : Profile
    {
        public PreventaMappingProfile()
        {
            CreateMap<PreVenta, PreventaInternalModel>()
                .ForMember(dest => dest.FechaDesde, opt => opt.MapFrom(src => src.FCRMVH_FCHDES))
                .ForMember(dest => dest.FechaHasta, opt => opt.MapFrom(src => src.FCRMVH_FCHHAS))
                .ForMember(dest => dest.FechaMovimiento, opt => opt.MapFrom(src => src.FCRMVH_FCHMOV))
                .ForMember(dest => dest.NumeroCliente, opt => opt.MapFrom(src => src.FCRMVH_NROCTA))
                .ForMember(dest => dest.NumeroPreventa, opt => opt.MapFrom(src => src.FCRMVH_NROFOR))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.FCRMVH_VNDDOR));    
            //.ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.RoleFeatures.Select(rf => rf.Feature)));
        }
    }
}