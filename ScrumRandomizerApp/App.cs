using Microsoft.Extensions.DependencyInjection;
using Microsoft.MobileBlazorBindings;
using ScrumRandomizerApp.Components;
using Xamarin.Forms;

namespace ScrumRandomizerApp
{
    public class App : Application
    {
        public App()
        {
            var host = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {

                })
                .Build();
            MainPage = new ContentPage();
            host.AddComponent<MainComponent>(parent: MainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}