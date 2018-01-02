using FlexGridStudy.Views;
using System.Windows;
using Prism.Modularity;
using DryIoc;
using Prism.DryIoc;
using FlexGridStudy.Usecases;
using FlexGridStudy.ViewModels;

namespace FlexGridStudy
{
    class Bootstrapper : DryIocBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            var moduleCatalog = (ModuleCatalog)ModuleCatalog;
            //moduleCatalog.AddModule(typeof(YOUR_MODULE));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterTypeForNavigation<ProductListView>();

            Container.Register<IReferenceProducts, ReferenceProducts>();
        }
    }
}
