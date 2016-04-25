using cerkes_haber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cerkes_haber.LocalStorage
{
    public interface ISqLite
    {
        SQLite.SQLiteConnection SQLiteConnection();
    }
}
