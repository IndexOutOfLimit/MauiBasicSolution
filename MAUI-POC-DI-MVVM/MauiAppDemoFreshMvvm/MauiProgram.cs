using FreshMvvm.Maui.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace MauiAppDemoFreshMvvm
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            builder.Services.Add(ServiceDescriptor.Transient<MainPageModel, MainPageModel>());
            builder.Services.Add(ServiceDescriptor.Transient<MainPage, MainPage>());

            //builder.Services.AddTransient<MainPageModel>();
            //builder.Services.AddTransient<MainPage>();

            builder.Services.UseFreshMvvm();

            return builder.Build();
        }
    }
}