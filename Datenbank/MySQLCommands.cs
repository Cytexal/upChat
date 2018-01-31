using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Datenbank
{
    class MySQLCommands
    {
        public static string MySQLSelectCommmand(String Befehl)
        {
            MySqlCommand command = Variablen.connection.CreateCommand();
            command.CommandText = Befehl;
            MySqlDataReader Reader;

            Reader = command.ExecuteReader();
            string row = "";
            while (Reader.Read())
            {
                
                for (int i = 0; i < Reader.FieldCount; i++)
                    row += Reader.GetValue(i).ToString() + ";";
            }
            Variablen.connection.Close();
            OpenConnection();
            return row;
        }

        public static string MySQLSelectCommmand(String Befehl, int Rückgabewert_Nummer)
        {
            try
            {
                MySqlCommand command = Variablen.connection.CreateCommand();
                command.CommandText = Befehl;
                MySqlDataReader Reader;

                Reader = command.ExecuteReader();
                string row = "";
                Reader.Read();
                row += Reader.GetValue((Rückgabewert_Nummer - 1)).ToString();
                Variablen.connection.Close();
                OpenConnection();
                return row;
            }
            catch
            {
                Variablen.connection.Close();
                OpenConnection();
                return "";
            }
            
        }


        public static void MySQLInsertCommmand(String Befehl)
        {
            string myInsertQuery = Befehl;
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = Variablen.connection;
            myCommand.ExecuteNonQuery();
            Variablen.connection.Close();
            OpenConnection();
        }

        public static void OpenConnection()
        {
            Variablen.connection = new MySqlConnection();
            Variablen.connection.ConnectionString = Variablen.cs;
            Variablen.connection.Open();
        }
    }
}
