using MasterDetailTabPageBug.ViewModels;
using Prism.Navigation;
using Xamarin.Forms;

namespace MasterDetailTabPageBug.Views
{
    public partial class PrismTabbedPage : TabbedPage, INavigatingAware
    {
        public PrismTabbedPage()
        {
            InitializeComponent();
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            var selectedTab = parameters?.GetValue<string>(KnownNavigationParameters.SelectedTab);

            foreach (var child in Children)
            {
                var element = child;
                if (element is NavigationPage navigationPage)
                {
                    //if the child page is a navigation page get its root page
                    element = navigationPage.RootPage;
                }

                (element as INavigatingAware)?.OnNavigatingTo(parameters);
                (element?.BindingContext as ViewModelBase)?.OnNavigatingTo(parameters);

                if (!string.IsNullOrWhiteSpace(selectedTab))
                {
                    if (element.GetType() == PageNavigationRegistry.GetPageType(selectedTab))
                    {
                        this.CurrentPage = child;
                    }
                }
            }
        }
    }
}
