using Prism.Navigation;

namespace test.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Name = "Hello";
            MyName = "Wold";
        }
        
        public string Name { get; set; }
        public string MyName { get; set; }

    }
}
