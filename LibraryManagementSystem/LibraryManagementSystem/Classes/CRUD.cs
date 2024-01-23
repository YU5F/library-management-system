using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public static bool ExecQuery(string q)
        {
            int verify = 0;
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(q, DTConncetion.con);
                DTConncetion.con.Open();
                verify = cmd.ExecuteNonQuery();
                DTConncetion.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            if(verify != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
