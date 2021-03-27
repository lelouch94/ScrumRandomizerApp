using ScrumRandomizerApp.Configuration.Models;
using System.Threading.Tasks;

namespace ScrumRandomizerApp.Configuration.Interfaces
{
    public interface IAppSettingsRepository
    {
        Task<AppSettingsItem> GetAppSettings();
    }
}