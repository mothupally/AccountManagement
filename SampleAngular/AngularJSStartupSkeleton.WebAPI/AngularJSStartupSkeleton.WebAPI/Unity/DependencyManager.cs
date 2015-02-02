using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace AngularJS.WebAPI.Unity
{
    public static class DependencyManager
    {
        public static IUnityContainer Container;

        static DependencyManager()
        {
            Container = new UnityContainer();
            RegisterDependencies();
        }

        private static void RegisterDependencies()
        {
            Container.LoadConfiguration();   
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        public static T Resolve<T>(string name)
        {
            return Container.Resolve<T>(name);
        }       
    }
}
