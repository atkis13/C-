using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SLQTest
{
    
    class Connection
    {
        public SQLiteConnection con;
        public Connection()
        {
            con = new SQLiteConnection("Data Source = Test.sqlite");
            //if (File.Exists("./data.sqlite3"))
            //{
            //    SQLiteConnection.CreateFile("data.sqlite3");
            //}

        }
        public void OpenConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }

        }

        public Boolean IsCon()
        {
            bool result;
            if (con.State == System.Data.ConnectionState.Open)
            {
                result =  true;
            }
            else
            {
                result = false;
            }

            return result;
        }


    }

    

   
}


