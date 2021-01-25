using FirstModuleProject;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace RegionMemberLifeTimeFromAllaev
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        Bootstrapper bootstrapper;

        public App()
        {

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
