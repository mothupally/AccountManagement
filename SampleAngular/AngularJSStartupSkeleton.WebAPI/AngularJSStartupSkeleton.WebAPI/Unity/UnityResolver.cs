using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace AngularJS.WebAPI.Unity
{
    public class UnityResolver : IDependencyResolver
    {
        //http://www.asp.net/web-api/overview/extensibility/using-the-web-api-dependency-resolver

        protected IUnityContainer Container;

        public UnityResolver(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            Container = container;
        }

        public object GetService(Type serviceType)
        {
            return Container.IsRegistered(serviceType) ? Container.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return Container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        public IDependencyScope BeginScope()
        {
            var child = Container.CreateChildContainer();
            return new UnityResolver(child);
        }

        public void Dispose()
        {
            Container.Dispose();
        }
    }
}
