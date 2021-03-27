using ScrumRandomizerApp.Configuration.Interfaces;
using ScrumRandomizerApp.Configuration.Models;
using System.Threading.Tasks;

namespace ScrumRandomizerApp.Configuration.Repositories
{
    public class AppSettingsRepository : IAppSettingsRepository
    {
        public Task<AppSettingsItem> GetAppSettings()
        {
            var appSettings = new AppSettingsItem();

            return Task.FromResult(appSettings);
        }
    }
}