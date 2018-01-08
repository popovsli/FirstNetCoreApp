using Autofac;
using BusinessEntities.Models;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstNetCoreMVC.Utils.Autofac.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<MovieContext>().AsSelf();
            builder.RegisterType<MovieService>().As<IMovieService>().InstancePerLifetimeScope();
        }
    }
}
