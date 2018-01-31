using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            setupChatPartners();



        }

        private void setupChatPartners()
        {
            String partnerString = MySQLCommands.MySQLSelectCommmand( "SELECT DISTINCT `SenderID` FROM `Nachrichten` WHERE `EmpfängerID` = '" + Variablen.ID + "'");

            String[] partners = partnerString.Split(';');
            foreach(String partner in partners)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = pictureBox2.Size;
                //byte[] imageinbytes = Encoding.UTF8.GetBytes(MySQLCommands.MySQLSelectCommmand("SELECT `Profilbild` FROM `Profile` WHERE `ID` = '" + partner + "'",1));
                //pictureBox.Image = byteArrayToImage(imageinbytes);
                flowLayoutPanel1.Controls.Add(pictureBox);
            }


        }


        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        private void buttonSend_Click(object sender, EventArgs e)
        {
            MySQLCommands.MySQLInsertCommmand("insert into Nachrichten (`SenderID`,`EmpfängerID`,`Nachricht`,`Zeit`) values ('" + textBoxSender.Text + "','" + textBoxEmpfänger.Text + "','" + textBoxMessage.Text + "','" + System.DateTime.Now.ToShortTimeString() + "')");
        }

        private void Chats_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
