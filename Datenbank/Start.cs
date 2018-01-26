﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Transitions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using RegistrierungForm;

namespace Datenbank
{
    public partial class Start : System.Windows.Forms.Form
    {
        String serverName = "Cytexal.com";
        String db = "upChat";
        String userID = "ITA";
        String password = "Hansel987";
        MySqlConnection connection;
        string cs;

        public MySqlConnection Connection { get => connection; set => connection = value; }
        public string Cs { get => cs; set => cs = value; }

        public Start()
        {
            InitializeComponent();
            cs = "Database = " + db + "; Server = " + serverName + "; Uid = " + userID + "; Password = " + password + "; pooling = false; CharSet = utf8; port = 3306";
            Connection = new MySqlConnection();
            Connection.ConnectionString = cs;
            Connection.Open();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MySQLCommands.MySQLSelectCommmand(Connection, "select * from Anmeldeinformationen"));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            MySQLCommands.MySQLInsertCommmand(Connection, "INSERT INTO Test (Test) Values('Hallo"+rnd.Next(100)+"')");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Anmeldung_Click(object sender, EventArgs e)
        {
            if(TextBox_Mail.Text == "")
            { Label_Mail.ForeColor = Color.IndianRed; }
            else
            { Label_Mail.ForeColor = Color.White; }
            

            if (TextBox_Passwort.Text == "")
            { Label_Passwort.ForeColor = Color.IndianRed;}
            else
            { Label_Passwort.ForeColor = Color.White; }


            if (TextBox_Passwort.Text != "" && TextBox_Mail.Text != "")
            {
                {
                    if (MySQLCommands.MySQLSelectCommmand(Connection, "SELECT ID FROM `Anmeldeinformationen` WHERE EMail like '" + TextBox_Mail.Text + "' AND Passwort like '" + TextBox_Passwort.Text + "'", 1) == "")
                    {
                        TextBox_Passwort.Text = "";
                        label1.Show();
                    }
                    else
                    {
                        
                        label1.Hide();
                        Variablen.ID = MySQLCommands.MySQLSelectCommmand(Connection, "SELECT ID FROM `Anmeldeinformationen` WHERE EMail like '" + TextBox_Mail.Text + "' AND Passwort like '" + TextBox_Passwort.Text + "'", 1);
                        TextBox_Passwort.Text = "";
                        TextBox_Mail.Text = "";

                        pictureBox1.Image = ResizeImage(pictureBox1.Image, 96, 96);
                        monoFlat_Label1.Hide();
                        Transition t = new Transition(new TransitionType_EaseInEaseOut(6000));
                        t.add(TextBox_Mail, "Left", -500);
                        t.add(TextBox_Passwort, "Left", -500);
                        t.add(Label_Mail, "Left", -500);
                        t.add(Label_Passwort, "Left", -500);
                        t.add(Button_Anmeldung, "Left", -500);
                        t.add(label1, "Left", -500);
                        if (MySQLCommands.MySQLSelectCommmand(Connection, "SELECT Anzeigename FROM `Profile` WHERE ID like '" + Variablen.ID + "'", 1) == "")
                        {
                            t.add(TextBox_Name, "Left", TextBox_Name.Location.X - 661);
                            t.add(Label_Name, "Left", Label_Name.Location.X - 661);
                            t.add(pictureBox1, "Left", pictureBox1.Location.X - 661);
                            t.add(Button_Apply, "Left", Button_Apply.Location.X - 661);
                        }
                        MySQLCommands.MySQLInsertCommmand(Connection, "UPDATE `Anmeldeinformationen` SET `Letzter_Login`='"+System.DateTime.Now.ToShortTimeString()+"' WHERE `ID`='" + Variablen.ID + "'");
                        
                        t.run();
                    }
                }
            }
        }

        private void Button_Apply_Click(object sender, EventArgs e)
        {
            if(TextBox_Name.Text == "")
            {Label_Name.ForeColor = Color.IndianRed; }
            else
            {
                Label_Name.ForeColor = Color.White;
                byte[] imagebytes = imageToByteArray(pictureBox1.Image);
                String imagebyteString = "";
                foreach (byte b in imagebytes)
                {
                    imagebyteString += b.ToString();
                }
                MySQLCommands.MySQLInsertCommmand(Connection, "INSERT INTO `Profile`(`ID`, `Anzeigename`, `Status`,`Profilbild`) VALUES ('"+Variablen.ID+"','"+TextBox_Name.Text+"','Hallo ich benutzte UpChat','"+imagebyteString+"')");

            }






        }


        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }



        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }


        private void ProfileImage_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (ProfileImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = ResizeImage(Image.FromFile(ProfileImage.FileName),96,96);
            }
        }

        private void monoFlat_Label1_Click(object sender, EventArgs e)
        {
            
            FormRegistration reg = new FormRegistration(this.Location);
            reg.Show();
            this.Hide();
        }
    }
}