using System.Windows.Input;
using FlexGridStudy.Usecases;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace FlexGridStudy.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private string _title = "Prism Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ICommand InitializeCommand => new DelegateCommand(() => { _regionManager.Regions["ContentRegion"].RequestNavigate("ProductListView"); });

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
    }
}
