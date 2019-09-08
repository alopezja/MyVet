using Prism.Navigation;

namespace MyVet.Prism.ViewModels
{
    public class PetsPageViewModel : ViewModelBase
    {
        public PetsPageViewModel(
            INavigationService navigationService) : base(navigationService)
        {
            Title = "Pets";
        }
    }
}
