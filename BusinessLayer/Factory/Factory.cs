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

        static IUnityContainer _container = null;
        static Type _validationType = null;

        static Factory()
        {
            LoadValidationType();

            _container = new UnityContainer();
            
            if (_validationType != null)
                _container.RegisterType<ReturnType, BaseType>(typeof(BaseType).Name, new InjectionConstructor(Activator.CreateInstance(_validationType)));
            else
                _container.RegisterType<ReturnType, BaseType>(typeof(BaseType).Name);
        }

        public static ReturnType Create()
        {
            //if (!typeof(ReturnType).IsInterface)
            //    throw new Exception(); //TODO 

            return _container.Resolve<ReturnType>(typeof(BaseType).Name);
        }

        public static void LoadValidationType()
        {
            _validationType = Assembly.Load("BusinessEntities").GetTypes().FirstOrDefault(x => x.Name == (typeof(BaseType).Name + "Validation"));
        }
    }
}
