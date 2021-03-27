using ScrumRandomizerApp.Configuration.Models;
using ScrumRandomizerApp.Persistancy;
using ScrumRandomizerApp.Scrum;
using SQLite;

namespace ScrumRandomizerApp.Persistency
{
    public class AppDatabase
    {
        public AppDatabase()
        {
            var db = new SQLiteConnection(Globals.DatabasePath, Globals.CustomOpenFlags);
            db.CreateTable<AppSettingsItem>(Globals.CustomCreateFlags);
            db.CreateTable<ScrumParticipant>(Globals.CustomCreateFlags);
        }
    }
}