using BusinessEntities.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Factory
{
    public static class Factory<ReturnType>
    {

        static IUnityContainer container = null;

        static Factory()
        {
            //container.RegisterType<ReturnType, Movie>("Movie");
        }

        public static ReturnType Create<InstanceType>(Type instanceType)
        {

            return container.Resolve<ReturnType>(instanceType.Name);
        }
    }
}
