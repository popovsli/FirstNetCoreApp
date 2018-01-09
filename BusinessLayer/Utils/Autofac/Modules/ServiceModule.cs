using Autofac;
using BusinessEntities.Models;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Reflaction = System.Reflection;
using System.Threading.Tasks;

namespace BusinessLayer.Utils.Autofac.Modules
{
    public class ServiceModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            var executingAssembly = Reflaction.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(executingAssembly)
                .Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();

            //To exclude types from scanning, use the Except() predicate:
            //builder.RegisterAssemblyTypes(asm).Except<MyUnwantedType>();

            //builder.RegisterType<MovieContext>().AsSelf();
            //builder.RegisterType<MovieService>().As<IMovieService>().InstancePerLifetimeScope();
        }
    }
}
