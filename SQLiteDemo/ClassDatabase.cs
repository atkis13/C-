using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SQLiteD
{

    
    class ClassDatabase
    {
        public SQLiteConnection con;
        public ClassDatabase()
        {
            con = new SQLiteConnection("Data Source = data.sqlite3");
            if (File.Exists("./data.sqlite3"))
            {
                SQLiteConnection.CreateFile("data.sqlite3");
            }

        }

        public void OpenConnection()
        {
            if(con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if(con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
        }
    }
}
