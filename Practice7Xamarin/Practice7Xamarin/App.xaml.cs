using Practice7Xamarin.ViewModels;
using Practice7Xamarin.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace Practice7Xamarin
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync($"{NavigationConstants.NavigationPage}/{NavigationConstants.TabbedPage}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(NavigationConstants.NavigationPage);
            containerRegistry.RegisterForNavigation<CustomTabbedPage, CustomTabbedPageViewModel>(NavigationConstants.TabbedPage);
            containerRegistry.RegisterForNavigation<DependencyServicePage, DependencyServiceViewModel>(NavigationConstants.DependencyService);
            containerRegistry.RegisterForNavigation<CustomRenderPage, CustomRenderPageViewModel>(NavigationConstants.CustomRender);
            containerRegistry.RegisterForNavigation<FocusedEffectPage, FocusedEffectPageViewModel>(NavigationConstants.Focusedeffect);
        }
    }
}
