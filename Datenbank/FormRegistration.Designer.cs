namespace RegistrierungForm
{
    partial class FormRegistration
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
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxPasswort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Button_Anmeldung = new Bunifu.Framework.UI.BunifuFlatButton();
            this.email_false = new System.Windows.Forms.Label();
            this.LabelLogin = new MonoFlat.Class1.MonoFlat_Label();
            this.SuspendLayout();
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.BackColor = System.Drawing.Color.Transparent;
            this.labelRegistration.Font = new System.Drawing.Font("Segoe UI Semilight", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRegistration.Location = new System.Drawing.Point(88, 29);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(231, 50);
            this.labelRegistration.TabIndex = 1;
            this.labelRegistration.Text = "Registrierung";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.BackColor = System.Drawing.Color.Transparent;
            this.labelEMail.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEMail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEMail.Location = new System.Drawing.Point(48, 133);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(68, 25);
            this.labelEMail.TabIndex = 4;
            this.labelEMail.Text = "E-Mail:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPassword.Location = new System.Drawing.Point(48, 289);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 25);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Passwort:";
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.BackColor = System.Drawing.Color.White;
            this.textBoxEMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEMail.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEMail.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxEMail.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxEMail.HintText = "";
            this.textBoxEMail.isPassword = false;
            this.textBoxEMail.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.textBoxEMail.LineIdleColor = System.Drawing.Color.White;
            this.textBoxEMail.LineMouseHoverColor = System.Drawing.Color.White;
            this.textBoxEMail.LineThickness = 3;
            this.textBoxEMail.Location = new System.Drawing.Point(53, 163);
            this.textBoxEMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(298, 41);
            this.textBoxEMail.TabIndex = 6;
            this.textBoxEMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.BackColor = System.Drawing.Color.White;
            this.textBoxPasswort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPasswort.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswort.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPasswort.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxPasswort.HintText = "";
            this.textBoxPasswort.isPassword = false;
            this.textBoxPasswort.LineFocusedColor = System.Drawing.Color.CadetBlue;
            this.textBoxPasswort.LineIdleColor = System.Drawing.Color.White;
            this.textBoxPasswort.LineMouseHoverColor = System.Drawing.Color.White;
            this.textBoxPasswort.LineThickness = 3;
            this.textBoxPasswort.Location = new System.Drawing.Point(53, 319);
            this.textBoxPasswort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.Size = new System.Drawing.Size(298, 41);
            this.textBoxPasswort.TabIndex = 7;
            this.textBoxPasswort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Button_Anmeldung
            // 
            this.Button_Anmeldung.Activecolor = System.Drawing.Color.CadetBlue;
            this.Button_Anmeldung.BackColor = System.Drawing.Color.LightCyan;
            this.Button_Anmeldung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Anmeldung.BorderRadius = 0;
            this.Button_Anmeldung.ButtonText = "Registrieren";
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
            this.Button_Anmeldung.Location = new System.Drawing.Point(79, 475);
            this.Button_Anmeldung.Name = "Button_Anmeldung";
            this.Button_Anmeldung.Normalcolor = System.Drawing.Color.LightCyan;
            this.Button_Anmeldung.OnHovercolor = System.Drawing.Color.CadetBlue;
            this.Button_Anmeldung.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Anmeldung.selected = false;
            this.Button_Anmeldung.Size = new System.Drawing.Size(241, 48);
            this.Button_Anmeldung.TabIndex = 9;
            this.Button_Anmeldung.Text = "Registrieren";
            this.Button_Anmeldung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Anmeldung.Textcolor = System.Drawing.Color.Gray;
            this.Button_Anmeldung.TextFont = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Anmeldung.Click += new System.EventHandler(this.buttonRegistrate_Click);
            // 
            // email_false
            // 
            this.email_false.AutoSize = true;
            this.email_false.BackColor = System.Drawing.Color.Transparent;
            this.email_false.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_false.ForeColor = System.Drawing.Color.Red;
            this.email_false.Location = new System.Drawing.Point(130, 550);
            this.email_false.Name = "email_false";
            this.email_false.Size = new System.Drawing.Size(143, 20);
            this.email_false.TabIndex = 10;
            this.email_false.Text = "Ungültige Eingabe/n";
            this.email_false.Visible = false;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.BackColor = System.Drawing.Color.Transparent;
            this.LabelLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.LabelLogin.Location = new System.Drawing.Point(328, 9);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(67, 15);
            this.LabelLogin.TabIndex = 11;
            this.LabelLogin.Text = "Anmelden?";
            this.LabelLogin.Click += new System.EventHandler(this.LabelLogin_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Datenbank.Properties.Resources.thumb_1920_536245;
            this.ClientSize = new System.Drawing.Size(407, 591);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.email_false);
            this.Controls.Add(this.Button_Anmeldung);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.labelRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegistration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxEMail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPasswort;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Anmeldung;
        private System.Windows.Forms.Label email_false;
        private MonoFlat.Class1.MonoFlat_Label LabelLogin;
    }
}

