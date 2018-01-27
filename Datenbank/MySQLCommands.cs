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
        public static string MySQLSelectCommmand(MySqlConnection connection,String Befehl)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = Befehl;
            MySqlDataReader Reader;

            Reader = command.ExecuteReader();
            string row = "";
            while (Reader.Read())
            {
                
                for (int i = 0; i < Reader.FieldCount; i++)
                    row += Reader.GetValue(i).ToString() + ";";
            }
            connection.Close();
            OpenConnection();
            return row;
        }

        public static string MySQLSelectCommmand(MySqlConnection connection, String Befehl, int Rückgabewert_Nummer)
        {
            try
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = Befehl;
                MySqlDataReader Reader;

                Reader = command.ExecuteReader();
                string row = "";
                Reader.Read();
                row += Reader.GetValue((Rückgabewert_Nummer - 1)).ToString();
                connection.Close();
                OpenConnection();
                return row;
            }
            catch
            {
                connection.Close();
                OpenConnection();
                return "";
            }
            
        }


        public static void MySQLInsertCommmand(MySqlConnection connection, String Befehl)
        {
            string myInsertQuery = Befehl;
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = connection;
            myCommand.ExecuteNonQuery();
            connection.Close();
            OpenConnection();
        }

        public static void OpenConnection()
        {
            ((Start)Application.OpenForms[0]).Connection = new MySqlConnection();
            ((Start)Application.OpenForms[0]).Connection.ConnectionString = ((Start)Application.OpenForms[0]).Cs;
            ((Start)Application.OpenForms[0]).Connection.Open();
        }
    }
}
