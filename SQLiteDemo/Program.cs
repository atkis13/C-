using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteD
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDatabase db = new ClassDatabase();

            // INSERT INTO
            string query = "insert into db('col1', 'col2')VALUES(@val1, @val2)";
            db.OpenConnection();
            SQLiteCommand com = new SQLiteCommand(query, db.con);
            com.Parameters.AddWithValue("@val1", "gyula");
            com.Parameters.AddWithValue("@val2", "pista");
            com.ExecuteNonQuery();
            db.CloseConnection();
            Console.ReadKey();


            // SELECT FROM

            string query = "SELECT * FROM db";
            db.OpenConnection();
            SQLiteCommand com = new SQLiteCommand(query, db.con);
            db.OpenConnection();
            SQLiteDataReader result = com.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Console.WriteLine("Artist: {0}, Album: {1}", result["col1"], result["col2"]);
                }
            }
            
           
            db.CloseConnection();
            Console.ReadKey();


        }
         public static void getDatatoGridView(DataGridView dg)
         {
            c = new Connection();
            string query = "Select * From worklog";
            c.OpenConnection();
            SQLiteDataAdapter dataap = new SQLiteDataAdapter(query, c.con);
            //SQLiteCommand comm = new SQLiteCommand(query, c.con);
            DataSet ds = new System.Data.DataSet();
            dataap.Fill(ds);
            dg.DataSource = ds.Tables[0];
           
            c.CloseConnection();
          }
            
    }
}
