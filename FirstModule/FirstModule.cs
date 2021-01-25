using System;
using Prism.Regions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using FirstModuleProject.Views;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace FirstModuleProject
{
    public class FirstModule : IModule
    {
        IRegionManager regionManager;
        IUnityContainer unityContainer;

        public FirstModule(IRegionManager regionManager,IUnityContainer unityContainer)
        {
            this.regionManager = regionManager;
            this.unityContainer = unityContainer;
        }

        public void Initialize()
        {
            unityContainer.RegisterTypeForNavigation<ViewA>();
            unityContainer.RegisterTypeForNavigation<ViewB>();

            unityContainer.RegisterTypeForNavigation<ViewA1>();
            unityContainer.RegisterTypeForNavigation<ViewA2>();

            regionManager.RequestNavigate("ContentRegion", "ViewB");
        }
    }
}
