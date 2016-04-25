using cerkes_haber.LocalStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cerkes_haber.model;
using SQLite;
using System.IO;
using Windows.Storage;

namespace cerkes_haber.WinPhone
{
    public class LocalStorage : ISqLite
    {
        public SQLiteConnection SQLiteConnection()
        {
            var fileName = "WindowsPhoneDatabase.db3";

            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, fileName);

            if (File.Exists(path))
                File.Copy(fileName, path);

            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}
