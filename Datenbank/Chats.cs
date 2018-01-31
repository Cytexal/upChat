using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datenbank
{
    public partial class Chats : Form
    {
        string ConnectionString;
        MySqlConnection sqlConnection;

        List<string> ListChats = new List<string>();
        public Chats()
        {
            InitializeComponent();
            ConnectionString = "Database =upChat; Server =cytexal.com; Uid =ITA; Password =Hansel987; pooling = false; CharSet = utf8; port = 3306";
            sqlConnection = new MySqlConnection(ConnectionString);
            sqlConnection.Open();
            // Get values into ListChats
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            MySQLCommands.MySQLInsertCommmand(sqlConnection, "insert into Nachrichten (`SenderID`,`EmpfängerID`,`Nachricht`,`Zeit`) values ('" + textBoxSender.Text + "','" + textBoxEmpfänger.Text + "','" + textBoxMessage.Text + "','" + System.DateTime.Now.ToShortTimeString() + "')");
        }

        private void Chats_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
