using SQLite;
using System.Threading.Tasks;

namespace ScrumRandomizerApp
{
    public class AppDatabase
    {
        static SQLiteAsyncConnection Database = new SQLiteAsyncConnection(Globals.DatabasePath);

        public static readonly AsyncLazy<AppDatabase> Instance = new AsyncLazy<AppDatabase>(async () =>
        {
            var instance = new AppDatabase();
            CreateTableResult result = await Database.CreateTableAsync<AppSettingsItem>();
            return instance;
        });

        public Task<AppSettingsItem> GetAppSettings()
        {
            return Database.Table<AppSettingsItem>().FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(AppSettingsItem item)
        {
            if (item.Id != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(AppSettingsItem item)
        {
            return Database.DeleteAsync(item);
        }
    }
}