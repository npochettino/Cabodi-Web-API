using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using Cabodi.Controllers;
using Cabodi.Data;
using Cabodi.Data.Mapping;
using Cabodi.Data.Repository;
using Cabodi.Models;

namespace Cabodi.App_Start
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var bldr = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            bldr.RegisterApiControllers(Assembly.GetExecutingAssembly());
            RegisterServices(bldr);
            bldr.RegisterWebApiFilterProvider(config);
            bldr.RegisterWebApiModelBinderProvider();
            var container = bldr.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void RegisterServices(ContainerBuilder bldr)
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile(new ClienteMappingProfile()); });

            var config2 = new MapperConfiguration(cfg => { cfg.AddProfile(new ListaPrecioMappingProfile()); });

            var config3 = new MapperConfiguration(cfg => { cfg.AddProfile(new ProductoMappingProfile()); });

            bldr.RegisterInstance(config.CreateMapper())
                .As<IMapper>()
                .SingleInstance();

            bldr.RegisterInstance(config2.CreateMapper())
                .As<IMapper>()
                .SingleInstance();

            bldr.RegisterInstance(config3.CreateMapper())
                .As<IMapper>()
                .SingleInstance();

            bldr.RegisterType<CabodiContext>()
                .InstancePerRequest();

            bldr.RegisterType<CabodiRepository>()
                .As<ICabodiRepository>()
                .InstancePerRequest();

            bldr.RegisterApiControllers(Assembly.GetExecutingAssembly());
        }
    }
}