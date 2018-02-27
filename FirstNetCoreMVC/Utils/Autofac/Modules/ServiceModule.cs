using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using Reflaction = System.Reflection;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;

namespace FirstNetCoreMVC.Utils.Autofac.Modules
{
    public class ServiceModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            var executingAssembly = Reflaction.Assembly.Load(nameof(BusinessLayer));

            builder.RegisterAssemblyTypes(executingAssembly)
                .Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope()
                .Except<EmailSenderService>(option => option.As<IEmailSenderService>().InstancePerDependency());
               
            //To exclude types from scanning, use the Except() predicate:
            //builder.RegisterAssemblyTypes(asm).Except<MyUnwantedType>();
        }
    }
}
