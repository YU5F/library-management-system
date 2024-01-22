using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class DTConncetion
    {
        public static SQLiteConnection con = new SQLiteConnection("Data source=.\\db\\lms.db;Version=3");
    }
}
