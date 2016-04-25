using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using cerkes_haber.LocalStorage;
using cerkes_haber.model;
using SQLite;
using System.IO;

namespace cerkes_haber.Droid
{
    public class LocalStorage : ISqLite
    {    
        public SQLiteConnection SQLiteConnection()
        {
            var fileName = "AndroidDatabase.db3";

            string destinationFile = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(destinationFile, fileName);

            if (File.Exists(path))
                File.Copy(fileName, path);

            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}