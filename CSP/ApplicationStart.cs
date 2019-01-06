using CSP.Unity;
using Unity;

namespace CSP
{
    public class ApplicationStart
    {
        // Register all dependencies here
        public static UnityContainer Initialize()
        {
            var container = new UnityContainer();

            container.RegisterType<ICar, BMW>();

            return container;
        }
    }
}