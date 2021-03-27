using SQLite;
using System;
using System.IO;

namespace ScrumRandomizerApp.Persistancy
{
    public static class Globals
    {
        private const string DatabaseFilename = "ScrumRandomizer.db3";

        public const SQLiteOpenFlags CustomOpenFlags =
        SQLiteOpenFlags.ReadWrite |
        SQLiteOpenFlags.Create |
        SQLiteOpenFlags.SharedCache;

        public const CreateFlags CustomCreateFlags =
            CreateFlags.AllImplicit |
            CreateFlags.AutoIncPK;

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