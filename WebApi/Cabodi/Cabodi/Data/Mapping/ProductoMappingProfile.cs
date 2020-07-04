using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cabodi.Models;

namespace Cabodi.Data.Mapping
{
    public class ProductoMappingProfile : Profile
    {
        public ProductoMappingProfile()
        {
            CreateMap<Producto, ProductoModel>();
        }
    }
}