using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KluCareer.WebMvc.DependencyResolver.Autofac
{
    public class AutofacDependencyResolver
    {
        private static ContainerBuilder _containerBuilder;
        private static IContainer _autofacContainer;

        public static void SetAutofacContainer(ContainerBuilder container)
        {
            _containerBuilder = container;
        }

        public static T Resolve<T>()
        {
            if (_containerBuilder == null)
            {
                throw new ArgumentNullException($"{nameof(_containerBuilder)} can not be null!");
            }

            if (_autofacContainer == null)
            {
                _autofacContainer = _containerBuilder.Build();
            }

            return _autofacContainer.Resolve<T>();
        }
    }
}
