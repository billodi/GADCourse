using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MetroLibrary
{
    
        public class DBIO
        {
            static SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");

            static DBIO()
            {
                sqlite_conn.Open();
            }
            // Create a new database connection:



            public static void IUD(String Query)
            {

                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = Query;
                sqlite_cmd.ExecuteNonQuery();
            }

            public static SQLiteDataReader Search(String Query)
            {

                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = Query;
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                return sqlite_datareader;
            }
        }
}


