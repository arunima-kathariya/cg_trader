using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CG_trader
{
    public class DBConnection
    {
       public static MySqlConnection DBConnect()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = @"Server =localhost; Database =cg_trader; Uid=root; Pwd=";
           if(conn.State != ConnectionState.Open)
           {
               conn.Open();
           }
           return conn;

        }
        public static DataTable gettablebyquery(string SqlQuery)
       {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch(Exception)
            {
                throw;
            }
       }
        public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            
        }
    }
}
