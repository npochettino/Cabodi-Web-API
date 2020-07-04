using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cabodi.Data.Entities;
using Cabodi.Models;

namespace Cabodi.Data.Mapping
{
    public class ListaPrecioMappingProfile : Profile
    {
        public ListaPrecioMappingProfile()
        {
            CreateMap<ListaPrecio, ListaPrecioModel>();
        }
    }
}