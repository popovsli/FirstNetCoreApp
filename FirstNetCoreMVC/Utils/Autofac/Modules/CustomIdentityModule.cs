using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using Reflaction = System.Reflection;
using System.Threading.Tasks;

namespace FirstNetCoreMVC.Utils.Autofac.Modules
{
    public class CustomIdentityModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var executingAssembly = Reflaction.Assembly.Load(nameof(BusinessLayer));

            builder.RegisterAssemblyTypes(executingAssembly)
                .Where(x => x.Name.EndsWith("Store")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(executingAssembly)
               .Where(x => x.Name.EndsWith("Manager")).AsSelf().InstancePerLifetimeScope();

            //To exclude types from scanning, use the Except() predicate:
            //builder.RegisterAssemblyTypes(asm).Except<MyUnwantedType>();
        }
    }
}
