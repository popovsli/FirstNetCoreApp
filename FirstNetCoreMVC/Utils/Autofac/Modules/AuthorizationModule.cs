using BusinessLayer.Services.Authorization;
using Microsoft.AspNetCore.Authorization;
using Reflaction = System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using AutofacRef = Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;

namespace FirstNetCoreMVC.Utils.Autofac.Modules
{
    /// <summary>
    /// Register AuthorizationHandlers 
    /// </summary>
    public class AuthorizationModule : AutofacRef.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var executingAssembly = Reflaction.Assembly.Load(nameof(BusinessLayer));
            
            builder.RegisterAssemblyTypes(executingAssembly)
            .Where(x => x.Name.EndsWith("AuthorizationHandler")).As<IAuthorizationHandler>().SingleInstance() //Singleton
            .Except<ContactIsOwnerAuthorizationHandler>(option => option.As<IAuthorizationHandler>().InstancePerLifetimeScope());
        }
    }
}
