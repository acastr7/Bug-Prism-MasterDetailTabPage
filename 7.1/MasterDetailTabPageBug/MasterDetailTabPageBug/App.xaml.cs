using System;
using Prism;
using Prism.Ioc;
using MasterDetailTabPageBug.ViewModels;
using MasterDetailTabPageBug.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MasterDetailTabPageBug
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync(new Uri($"app:///{nameof(PrismMasterDetailPage)}/{nameof(PrismTabbedPage)}"));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<PrismMasterDetailPage, PrismMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<PrismTabbedPage, PrismTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<PageA, PageAViewModel>();
            containerRegistry.RegisterForNavigation<PageB, PageBViewModel>();
            containerRegistry.RegisterForNavigation<PageC, PageCViewModel>();
            containerRegistry.RegisterForNavigation<PageD, PageDViewModel>();
        }
    }
}
