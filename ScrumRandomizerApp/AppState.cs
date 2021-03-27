using System.Threading.Tasks;

namespace ScrumRandomizerApp
{
    public static class AppState
    {
        public static async Task<AppSettingsItem> GetAppSettings()
        {
            AppSettingsItem appSettingsItem = null;

            var db = await AppDatabase.Instance;
            appSettingsItem = await db.GetAppSettings();

            return appSettingsItem 
                ?? new AppSettingsItem();
        }
    }
}