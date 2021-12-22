using FreshMvvm.Maui;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiAppDemoFreshMvvm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            var basicNavContainer = new FreshNavigationContainer(page);
            MainPage = basicNavContainer;
        }
    }
}
