using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aulla_BD_22_09_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "insert into Pessoa (Nome) Values('Adalberto')";
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

        }
    }
}
