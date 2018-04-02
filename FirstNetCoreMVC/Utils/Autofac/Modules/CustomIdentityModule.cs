using System;
using System.Collections.Generic;
using System.Linq;
using Reflaction = System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using AutofacRef = Autofac;
using Autofac;
using BusinessLayer.Services.Identity;

namespace FirstNetCoreMVC.Utils.Autofac.Modules
{
    public class CustomIdentityModule : AutofacRef.Module
    {
        protected override void Load(AutofacRef.ContainerBuilder builder)
        {
            var executingAssembly = Reflaction.Assembly.Load(nameof(BusinessLayer));

            //Register all custom stores
            builder.RegisterAssemblyTypes(executingAssembly)
                .Where(x => x.Name.EndsWith("Store")).AsImplementedInterfaces().InstancePerLifetimeScope();

            //Register custom UserManagers
            builder.RegisterGeneric(typeof(CustomUserManager<>)).AsSelf().InstancePerLifetimeScope();

            //Register custom RoleManagers
            builder.RegisterGeneric(typeof(CustomRoleManager<>)).AsSelf().InstancePerLifetimeScope();
            
            //builder.RegisterAssemblyTypes(executingAssembly)
            //   .Where(x => x.BaseType != null && x.BaseType.IsGenericType 
            //   && x.BaseType.GetGenericTypeDefinition() == typeof(UserManager<>).GetGenericTypeDefinition()).AsSelf().InstancePerLifetimeScope();

            //To exclude types from scanning, use the Except() predicate:
            //builder.RegisterAssemblyTypes(asm).Except<MyUnwantedType>();
        }
    }
}
