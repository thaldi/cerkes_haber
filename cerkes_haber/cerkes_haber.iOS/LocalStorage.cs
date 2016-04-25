using cerkes_haber.LocalStorage;
using System;
using System.Collections.Generic;
using System.Text;
using cerkes_haber.model;
using SQLite;
using System.IO;

namespace cerkes_haber.iOS
{
    public class LocalStorage : ISqLite
    {
        public SQLiteConnection SQLiteConnection()
        {
            var fileName = "iOSDatabase.db3";

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            string libraryPath = Path.Combine(docPath, "..", "Library");

            var path = Path.Combine(libraryPath, fileName);

            if (File.Exists(path))
                File.Copy(fileName, path);


            var connection = new SQLite.SQLiteConnection(path);
            return connection;

        }
    }
}
