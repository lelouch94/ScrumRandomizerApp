using Microsoft.MobileBlazorBindings;
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
            // var settings = AppState.GetAppSettings().Result;
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