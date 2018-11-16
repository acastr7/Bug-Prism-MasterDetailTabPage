using Prism.Commands;
using Prism.Navigation;

namespace MasterDetailTabPageBug.ViewModels
{
    public class PrismMasterDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand<string> NavigateCommand { get; }
        public PrismMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }

        private async void OnNavigateCommandExecuted(string path)
        {
            var navigationResult = await _navigationService.NavigateAsync(path, useModalNavigation: false);
            if (!navigationResult.Success)
            {
                System.Diagnostics.Debug.WriteLine(navigationResult.Exception?.StackTrace);
            }
        }
    }
}
