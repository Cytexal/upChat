namespace Datenbank
{
    partial class Start
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.UpChat = new System.Windows.Forms.Label();
            this.TextBox_Mail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBox_Passwort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_Mail = new MonoFlat.Class1.MonoFlat_Label();
            this.Label_Passwort = new MonoFlat.Class1.MonoFlat_Label();
            this.Button_Anmeldung = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Label_Name = new MonoFlat.Class1.MonoFlat_Label();
            this.Button_Apply = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProfileImage = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monoFlat_Label1 = new MonoFlat.Class1.MonoFlat_Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpChat
            // 
            this.UpChat.AutoSize = true;
            this.UpChat.BackColor = System.Drawing.Color.Transparent;
            this.UpChat.Font = new System.Drawing.Font("Segoe UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpChat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpChat.Location = new System.Drawing.Point(144, 20);
            this.UpChat.Name = "UpChat";
            this.UpChat.Size = new System.Drawing.Size(110, 50);
            this.UpChat.TabIndex = 2;
            this.UpChat.Text = "LogIn";
            // 
            // TextBox_Mail
            // 
            this.TextBox_Mail.BackColor = System.Drawing.Color.White;
            this.TextBox_Mail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Mail.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Mail.ForeColor = System.Drawing.Color.DarkGray;
            this.TextBox_Mail.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Mail.HintText = "";
            this.TextBox_Mail.isPassword = false;
            this.TextBox_Mail.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.TextBox_Mail.LineIdleColor = System.Drawing.Color.White;
            this.TextBox_Mail.LineMouseHoverColor = System.Drawing.Color.White;
            this.TextBox_Mail.LineThickness = 3;
            this.TextBox_Mail.Location = new System.Drawing.Point(51, 166);
            this.TextBox_Mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_Mail.Name = "TextBox_Mail";
            this.TextBox_Mail.Size = new System.Drawing.Size(298, 41);
            this.TextBox_Mail.TabIndex = 3;
            this.TextBox_Mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBox_Passwort
            // 
            this.TextBox_Passwort.BackColor = System.Drawing.Color.White;
            this.TextBox_Passwort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Passwort.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Passwort.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_Passwort.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Passwort.HintText = "";
            this.TextBox_Passwort.isPassword = true;
            this.TextBox_Passwort.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.TextBox_Passwort.LineIdleColor = System.Drawing.Color.White;
            this.TextBox_Passwort.LineMouseHoverColor = System.Drawing.Color.White;
            this.TextBox_Passwort.LineThickness = 3;
            this.TextBox_Passwort.Location = new System.Drawing.Point(51, 333);
            this.TextBox_Passwort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_Passwort.Name = "TextBox_Passwort";
            this.TextBox_Passwort.Size = new System.Drawing.Size(298, 41);
            this.TextBox_Passwort.TabIndex = 4;
            this.TextBox_Passwort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label_Mail
            // 
            this.Label_Mail.AutoSize = true;
            this.Label_Mail.BackColor = System.Drawing.Color.Transparent;
            this.Label_Mail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Mail.ForeColor = System.Drawing.Color.White;
            this.Label_Mail.Location = new System.Drawing.Point(46, 125);
            this.Label_Mail.Name = "Label_Mail";
            this.Label_Mail.Size = new System.Drawing.Size(71, 25);
            this.Label_Mail.TabIndex = 5;
            this.Label_Mail.Text = "E-Mail:";
            // 
            // Label_Passwort
            // 
            this.Label_Passwort.AutoSize = true;
            this.Label_Passwort.BackColor = System.Drawing.Color.Transparent;
            this.Label_Passwort.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Passwort.ForeColor = System.Drawing.Color.White;
            this.Label_Passwort.Location = new System.Drawing.Point(46, 296);
            this.Label_Passwort.Name = "Label_Passwort";
            this.Label_Passwort.Size = new System.Drawing.Size(90, 25);
            this.Label_Passwort.TabIndex = 6;
            this.Label_Passwort.Text = "Passwort:";
            // 
            // Button_Anmeldung
            // 
            this.Button_Anmeldung.Activecolor = System.Drawing.Color.CadetBlue;
            this.Button_Anmeldung.BackColor = System.Drawing.Color.LightCyan;
            this.Button_Anmeldung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Anmeldung.BorderRadius = 0;
            this.Button_Anmeldung.ButtonText = "Anmelden";
            this.Button_Anmeldung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Anmeldung.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Anmeldung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Anmeldung.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Anmeldung.Iconimage = null;
            this.Button_Anmeldung.Iconimage_right = null;
            this.Button_Anmeldung.Iconimage_right_Selected = null;
            this.Button_Anmeldung.Iconimage_Selected = null;
            this.Button_Anmeldung.IconMarginLeft = 0;
            this.Button_Anmeldung.IconMarginRight = 0;
            this.Button_Anmeldung.IconRightVisible = true;
            this.Button_Anmeldung.IconRightZoom = 0D;
            this.Button_Anmeldung.IconVisible = true;
            this.Button_Anmeldung.IconZoom = 90D;
            this.Button_Anmeldung.IsTab = false;
            this.Button_Anmeldung.Location = new System.Drawing.Point(85, 459);
            this.Button_Anmeldung.Name = "Button_Anmeldung";
            this.Button_Anmeldung.Normalcolor = System.Drawing.Color.LightCyan;
            this.Button_Anmeldung.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.Button_Anmeldung.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Anmeldung.selected = false;
            this.Button_Anmeldung.Size = new System.Drawing.Size(241, 48);
            this.Button_Anmeldung.TabIndex = 8;
            this.Button_Anmeldung.Text = "Anmelden";
            this.Button_Anmeldung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Anmeldung.Textcolor = System.Drawing.Color.Gray;
            this.Button_Anmeldung.TextFont = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Anmeldung.Click += new System.EventHandler(this.Button_Anmeldung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(116, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ungültige Anmeldedaten.";
            this.label1.Visible = false;
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.BackColor = System.Drawing.Color.White;
            this.TextBox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Name.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Name.ForeColor = System.Drawing.Color.DarkGray;
            this.TextBox_Name.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox_Name.HintText = "";
            this.TextBox_Name.isPassword = false;
            this.TextBox_Name.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.TextBox_Name.LineIdleColor = System.Drawing.Color.White;
            this.TextBox_Name.LineMouseHoverColor = System.Drawing.Color.White;
            this.TextBox_Name.LineThickness = 3;
            this.TextBox_Name.Location = new System.Drawing.Point(712, 342);
            this.TextBox_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(298, 41);
            this.TextBox_Name.TabIndex = 10;
            this.TextBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.BackColor = System.Drawing.Color.Transparent;
            this.Label_Name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.White;
            this.Label_Name.Location = new System.Drawing.Point(795, 296);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(131, 25);
            this.Label_Name.TabIndex = 11;
            this.Label_Name.Text = "Anzeigename:";
            // 
            // Button_Apply
            // 
            this.Button_Apply.Activecolor = System.Drawing.Color.CadetBlue;
            this.Button_Apply.BackColor = System.Drawing.Color.LightCyan;
            this.Button_Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Apply.BorderRadius = 0;
            this.Button_Apply.ButtonText = "Bestätigen";
            this.Button_Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Apply.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Apply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Apply.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_Apply.Iconimage = null;
            this.Button_Apply.Iconimage_right = null;
            this.Button_Apply.Iconimage_right_Selected = null;
            this.Button_Apply.Iconimage_Selected = null;
            this.Button_Apply.IconMarginLeft = 0;
            this.Button_Apply.IconMarginRight = 0;
            this.Button_Apply.IconRightVisible = true;
            this.Button_Apply.IconRightZoom = 0D;
            this.Button_Apply.IconVisible = true;
            this.Button_Apply.IconZoom = 90D;
            this.Button_Apply.IsTab = false;
            this.Button_Apply.Location = new System.Drawing.Point(745, 459);
            this.Button_Apply.Name = "Button_Apply";
            this.Button_Apply.Normalcolor = System.Drawing.Color.LightCyan;
            this.Button_Apply.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.Button_Apply.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Apply.selected = false;
            this.Button_Apply.Size = new System.Drawing.Size(241, 48);
            this.Button_Apply.TabIndex = 13;
            this.Button_Apply.Text = "Bestätigen";
            this.Button_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Apply.Textcolor = System.Drawing.Color.Gray;
            this.Button_Apply.TextFont = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Apply.Click += new System.EventHandler(this.Button_Apply_Click);
            // 
            // ProfileImage
            // 
            this.ProfileImage.FileName = "openFileDialog1";
            this.ProfileImage.Filter = "Bilder(*.png & *.jpg) |*.png;*.jpg;";
            this.ProfileImage.FileOk += new System.ComponentModel.CancelEventHandler(this.ProfileImage_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox1.Image = global::Datenbank.Properties.Resources.Profilbild_Symbolbild_maennlich_Standard_blau_weiss_image_1200;
            this.pictureBox1.Location = new System.Drawing.Point(797, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(321, 9);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(74, 15);
            this.monoFlat_Label1.TabIndex = 15;
            this.monoFlat_Label1.Text = "Registrieren?";
            this.monoFlat_Label1.Click += new System.EventHandler(this.monoFlat_Label1_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Datenbank.Properties.Resources.thumb_1920_536245;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(407, 591);
            this.Controls.Add(this.monoFlat_Label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_Apply);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Anmeldung);
            this.Controls.Add(this.Label_Passwort);
            this.Controls.Add(this.Label_Mail);
            this.Controls.Add(this.TextBox_Passwort);
            this.Controls.Add(this.TextBox_Mail);
            this.Controls.Add(this.UpChat);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Start";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UpChat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Mail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Passwort;
        private MonoFlat.Class1.MonoFlat_Label Label_Mail;
        private MonoFlat.Class1.MonoFlat_Label Label_Passwort;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Anmeldung;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox_Name;
        private MonoFlat.Class1.MonoFlat_Label Label_Name;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Apply;
        private System.Windows.Forms.OpenFileDialog ProfileImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MonoFlat.Class1.MonoFlat_Label monoFlat_Label1;
    }
}

