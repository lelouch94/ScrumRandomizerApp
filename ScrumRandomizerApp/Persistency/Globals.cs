using System;
using System.IO;

namespace ScrumRandomizerApp.Persistancy
{
    public static class Globals
    {
        public const string DatabaseFilename = "ScrumRandomizer.db3";

        public const SQLite.SQLiteOpenFlags Flags =
        SQLite.SQLiteOpenFlags.ReadWrite |
        SQLite.SQLiteOpenFlags.Create |
        SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}