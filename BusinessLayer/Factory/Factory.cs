using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BusinessEntities.Factory
{
    public static class Factory<ReturnType, BaseType>
        where ReturnType : class
        where BaseType : ReturnType
    {

        static IUnityContainer container = null;

        static Factory()
        {
            container = new UnityContainer();
            var validationType = Assembly.Load("BusinessEntities").GetTypes().FirstOrDefault(x => x.Name.Contains(typeof(BaseType).Name + "Validation"));
            if (validationType != null)
                container.RegisterType<ReturnType, BaseType>(typeof(BaseType).Name, new InjectionConstructor(Activator.CreateInstance(validationType)));
        }

        public static ReturnType Create()
        {
            if (!typeof(ReturnType).IsInterface)
                throw new Exception();

            return container.Resolve<ReturnType>(typeof(BaseType).Name);
        }
    }
}
