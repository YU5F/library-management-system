using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    public class CRUD
    {
        static DataTable dt;
        public static DataTable Sort(string q)
        {
            dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(q, DTConncetion.con);
            adapter.Fill(dt);
            return dt;
        }
    }
}
