using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrierungForm // Hi
{
    public partial class FormRegistration : Form
    {
        string ConnectionString;
        MySqlConnection sqlConnection;
        MySqlCommand CommandInsert = new MySqlCommand();
        MySqlCommand CommandCheck = new MySqlCommand();
        MySqlDataReader Reader;
        public FormRegistration(Point location)
        {
            InitializeComponent();
            ConnectionString = "Database =upChat; Server =cytexal.com; Uid =ITA; Password =Hansel987; pooling = false; CharSet = utf8; port = 3306";
            this.Location = location;
            sqlConnection = new MySqlConnection(ConnectionString);
            CommandCheck.Connection = sqlConnection;
            CommandInsert.Connection = sqlConnection;
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (Check())
            {
                CommandInsert.CommandText = "insert into Anmeldeinformationen (`EMail`,`Passwort`) values ('" + textBoxEMail.Text + "','" + textBoxPasswort.Text + "')";
                Reader = CommandInsert.ExecuteReader();
                this.Hide();
                Application.OpenForms[0].Show();
            }
            else
            {
                email_false.Show(); 
            }
            sqlConnection.Close();
            

        }

        private bool Check()
        {
            bool AlreadyUsed = true;
            bool IsEmail = false;
            bool PWlongEnough = false;

            // Check if Email is already used
            CommandCheck.CommandText = "select * from Anmeldeinformationen where EMail = '" + textBoxEMail.Text + "'";
            Reader = CommandCheck.ExecuteReader();
            int C = 0;
            while (Reader.Read())
            {
                C++;
            }
            if (C == 0)
            {
                AlreadyUsed = false;
                email_false.Hide();
            }
            else
            {
                AlreadyUsed = true;
                email_false.Show();
            }

            // Check if Text is EMail
            if (textBoxEMail.Text.Contains("@"))
            {
                IsEmail = true;
                email_false.Hide();
            }
            else
            {
                IsEmail = false;
                email_false.Show();
            }

            // Check Password
            if (textBoxPasswort.Text.Length >= 5)
                PWlongEnough ^= true;

            Reader.Close();
            // return
            if (!AlreadyUsed && IsEmail && PWlongEnough)
            {
                return true;
            }
            return false;
        }

        private void FormRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void LabelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
