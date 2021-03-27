using Microsoft.EntityFrameworkCore;
using ScrumRandomizerApp.Configuration.Models;
using ScrumRandomizerApp.Persistancy;
using ScrumRandomizerApp.Scrum;
using SQLite;

namespace ScrumRandomizerApp.Persistency
{
    public class AppDatabase
    {
        public static SQLiteConnection Database;

        public DbSet<ScrumParticipant> ScrumParticipants { get; set; }
        public DbSet<AppSettingsItem> AppSettingsItems { get; set; }

        static AppDatabase()
        {
            Database = new SQLiteConnection(Globals.DatabasePath, Globals.CustomOpenFlags);
            Database.CreateTable<AppSettingsItem>(Globals.CustomCreateFlags);
            Database.CreateTable<ScrumParticipant>(Globals.CustomCreateFlags);
        }
    }
}