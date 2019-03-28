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
            CreateMap<Cliente, ClienteModel>();
        }
    }
}