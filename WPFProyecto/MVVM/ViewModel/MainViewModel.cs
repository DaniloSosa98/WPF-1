using WPFProyecto.Core;

namespace WPFProyecto.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand => new RelayCommand(execute=> this.CurrentView = HomeVM);
        public RelayCommand DiscoveryViewCommand => new RelayCommand(execute => this.CurrentView = DiscoveryVM);

        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() 
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();

            CurrentView = HomeVM;
        }

        public void toHomeView()
        {
            this.CurrentView = HomeVM;
        }

        public void toDiscoveryView()
        {
            this.CurrentView = DiscoveryVM;
        }
    }
}
