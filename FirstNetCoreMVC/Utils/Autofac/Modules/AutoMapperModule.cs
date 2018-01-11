using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using Reflaction = System.Reflection;
using System.Threading.Tasks;
using AutoMapper;

namespace FirstNetCoreMVC.Utils.Autofac.Modules
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(Mapper.Instance)
                .As<IMapper>()
                .SingleInstance();
        }
    }
}
