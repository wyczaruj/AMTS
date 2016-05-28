namespace AMTS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.messageBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.messagesButton = new System.Windows.Forms.Button();
            this.confirmConfirmationButton = new System.Windows.Forms.Button();
            this.myRegistrationButton = new System.Windows.Forms.Button();
            this.numberOfTeamRegistrationsLabel = new System.Windows.Forms.Label();
            this.teamRegistrationsButton = new System.Windows.Forms.Button();
            this.niezalogowany = new System.Windows.Forms.Label();
            this.registerTeamButton = new System.Windows.Forms.Button();
            this.regulaminButton = new System.Windows.Forms.Button();
            this.wynikiButton = new System.Windows.Forms.Button();
            this.klasyfikacjaButton = new System.Windows.Forms.Button();
            this.terminarzButton = new System.Windows.Forms.Button();
            this.teamLabel = new System.Windows.Forms.Label();
            this.druzynaLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.LabelZJ = new System.Windows.Forms.Label();
            this.usunDruz = new System.Windows.Forms.Button();
            this.usunUzyt = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // messageBackgroundWorker
            // 
            this.messageBackgroundWorker.WorkerReportsProgress = true;
            this.messageBackgroundWorker.WorkerSupportsCancellation = true;
            this.messageBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.messageBackgroundWorker_DoWork);
            this.messageBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.messageBackgroundWorker_ProgressChanged);
            // 
            // messagesButton
            // 
            this.messagesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.messagesButton.FlatAppearance.BorderSize = 0;
            this.messagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messagesButton.Image = global::AMTS.Properties.Resources.greyMailImage;
            this.messagesButton.Location = new System.Drawing.Point(1271, 5);
            this.messagesButton.Margin = new System.Windows.Forms.Padding(2);
            this.messagesButton.Name = "messagesButton";
            this.messagesButton.Size = new System.Drawing.Size(50, 55);
            this.messagesButton.TabIndex = 17;
            this.messagesButton.UseVisualStyleBackColor = false;
            this.messagesButton.Visible = false;
            this.messagesButton.Click += new System.EventHandler(this.messagesButton_Click);
            // 
            // confirmConfirmationButton
            // 
            this.confirmConfirmationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmConfirmationButton.Location = new System.Drawing.Point(1420, 182);
            this.confirmConfirmationButton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmConfirmationButton.Name = "confirmConfirmationButton";
            this.confirmConfirmationButton.Size = new System.Drawing.Size(113, 36);
            this.confirmConfirmationButton.TabIndex = 16;
            this.confirmConfirmationButton.Text = "Potwierdź swój udział";
            this.confirmConfirmationButton.UseVisualStyleBackColor = true;
            this.confirmConfirmationButton.Visible = false;
            this.confirmConfirmationButton.Click += new System.EventHandler(this.confirmConfirmationButton_Click);
            // 
            // myRegistrationButton
            // 
            this.myRegistrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.myRegistrationButton.Location = new System.Drawing.Point(1422, 222);
            this.myRegistrationButton.Margin = new System.Windows.Forms.Padding(2);
            this.myRegistrationButton.Name = "myRegistrationButton";
            this.myRegistrationButton.Size = new System.Drawing.Size(111, 36);
            this.myRegistrationButton.TabIndex = 15;
            this.myRegistrationButton.Text = "Moje zgłoszenie";
            this.myRegistrationButton.UseVisualStyleBackColor = true;
            this.myRegistrationButton.Visible = false;
            this.myRegistrationButton.Click += new System.EventHandler(this.myRegistrationButton_Click);
            // 
            // numberOfTeamRegistrationsLabel
            // 
            this.numberOfTeamRegistrationsLabel.AutoSize = true;
            this.numberOfTeamRegistrationsLabel.Location = new System.Drawing.Point(1380, 194);
            this.numberOfTeamRegistrationsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfTeamRegistrationsLabel.Name = "numberOfTeamRegistrationsLabel";
            this.numberOfTeamRegistrationsLabel.Size = new System.Drawing.Size(25, 13);
            this.numberOfTeamRegistrationsLabel.TabIndex = 14;
            this.numberOfTeamRegistrationsLabel.Text = "(14)";
            this.numberOfTeamRegistrationsLabel.Visible = false;
            // 
            // teamRegistrationsButton
            // 
            this.teamRegistrationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.teamRegistrationsButton.Location = new System.Drawing.Point(1270, 184);
            this.teamRegistrationsButton.Margin = new System.Windows.Forms.Padding(2);
            this.teamRegistrationsButton.Name = "teamRegistrationsButton";
            this.teamRegistrationsButton.Size = new System.Drawing.Size(106, 36);
            this.teamRegistrationsButton.TabIndex = 13;
            this.teamRegistrationsButton.Text = "Zgłoszenia drużyn";
            this.teamRegistrationsButton.UseVisualStyleBackColor = true;
            this.teamRegistrationsButton.Visible = false;
            this.teamRegistrationsButton.Click += new System.EventHandler(this.teamRegistrationsButton_Click);
            // 
            // niezalogowany
            // 
            this.niezalogowany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.niezalogowany.AutoSize = true;
            this.niezalogowany.ForeColor = System.Drawing.Color.Red;
            this.niezalogowany.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.niezalogowany.Location = new System.Drawing.Point(1449, 157);
            this.niezalogowany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.niezalogowany.Name = "niezalogowany";
            this.niezalogowany.Size = new System.Drawing.Size(61, 13);
            this.niezalogowany.TabIndex = 12;
            this.niezalogowany.Text = "Zaloguj się.";
            this.niezalogowany.Visible = false;
            // 
            // registerTeamButton
            // 
            this.registerTeamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTeamButton.Location = new System.Drawing.Point(1425, 128);
            this.registerTeamButton.Name = "registerTeamButton";
            this.registerTeamButton.Size = new System.Drawing.Size(105, 25);
            this.registerTeamButton.TabIndex = 11;
            this.registerTeamButton.Text = "Zgłoś drużynę";
            this.registerTeamButton.UseVisualStyleBackColor = true;
            this.registerTeamButton.Click += new System.EventHandler(this.registerTeam_Click);
            // 
            // regulaminButton
            // 
            this.regulaminButton.Location = new System.Drawing.Point(1039, 128);
            this.regulaminButton.Name = "regulaminButton";
            this.regulaminButton.Size = new System.Drawing.Size(186, 23);
            this.regulaminButton.TabIndex = 10;
            this.regulaminButton.Text = "Regulamin";
            this.regulaminButton.UseVisualStyleBackColor = true;
            this.regulaminButton.Click += new System.EventHandler(this.regulaminButton_Click);
            // 
            // wynikiButton
            // 
            this.wynikiButton.Location = new System.Drawing.Point(831, 128);
            this.wynikiButton.Name = "wynikiButton";
            this.wynikiButton.Size = new System.Drawing.Size(192, 23);
            this.wynikiButton.TabIndex = 9;
            this.wynikiButton.Text = "Wyniki";
            this.wynikiButton.UseVisualStyleBackColor = true;
            this.wynikiButton.Click += new System.EventHandler(this.wynikiButton_Click);
            // 
            // klasyfikacjaButton
            // 
            this.klasyfikacjaButton.Location = new System.Drawing.Point(195, 128);
            this.klasyfikacjaButton.Name = "klasyfikacjaButton";
            this.klasyfikacjaButton.Size = new System.Drawing.Size(196, 23);
            this.klasyfikacjaButton.TabIndex = 8;
            this.klasyfikacjaButton.Text = "Klasyfikacja";
            this.klasyfikacjaButton.UseVisualStyleBackColor = true;
            this.klasyfikacjaButton.Click += new System.EventHandler(this.klasyfikacjaButton_Click);
            // 
            // terminarzButton
            // 
            this.terminarzButton.Location = new System.Drawing.Point(12, 128);
            this.terminarzButton.Name = "terminarzButton";
            this.terminarzButton.Size = new System.Drawing.Size(167, 23);
            this.terminarzButton.TabIndex = 7;
            this.terminarzButton.Text = "Terminarz";
            this.terminarzButton.UseVisualStyleBackColor = true;
            this.terminarzButton.Click += new System.EventHandler(this.terminarzButton_Click);
            // 
            // teamLabel
            // 
            this.teamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(1371, 27);
            this.teamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(159, 13);
            this.teamLabel.TabIndex = 6;
            this.teamLabel.Text = "druzyna [NIEZATWIERDZONA]";
            // 
            // druzynaLabel
            // 
            this.druzynaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.druzynaLabel.AutoSize = true;
            this.druzynaLabel.Location = new System.Drawing.Point(1325, 27);
            this.druzynaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.druzynaLabel.Name = "druzynaLabel";
            this.druzynaLabel.Size = new System.Drawing.Size(49, 13);
            this.druzynaLabel.TabIndex = 5;
            this.druzynaLabel.Text = "Drużyna:";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Location = new System.Drawing.Point(1445, 46);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(78, 27);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Rejestracja";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.Location = new System.Drawing.Point(1382, 46);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(56, 27);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInButton.Location = new System.Drawing.Point(1360, 46);
            this.logInButton.Margin = new System.Windows.Forms.Padding(2);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(78, 27);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Zaloguj się";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Location = new System.Drawing.Point(1442, 5);
            this.LoggedInAsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(32, 13);
            this.LoggedInAsLabel.TabIndex = 1;
            this.LoggedInAsLabel.Text = "Gość";
            this.LoggedInAsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelZJ
            // 
            this.LabelZJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelZJ.AutoSize = true;
            this.LabelZJ.Location = new System.Drawing.Point(1347, 5);
            this.LabelZJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelZJ.Name = "LabelZJ";
            this.LabelZJ.Size = new System.Drawing.Size(91, 13);
            this.LabelZJ.TabIndex = 0;
            this.LabelZJ.Text = "Zalogowany jako:";
            // 
            // usunDruz
            // 
            this.usunDruz.Location = new System.Drawing.Point(1336, 156);
            this.usunDruz.Name = "usunDruz";
            this.usunDruz.Size = new System.Drawing.Size(78, 23);
            this.usunDruz.TabIndex = 18;
            this.usunDruz.Text = "Drużynę";
            this.usunDruz.UseVisualStyleBackColor = true;
            this.usunDruz.Visible = false;
            this.usunDruz.Click += new System.EventHandler(this.usunDruz_Click);
            // 
            // usunUzyt
            // 
            this.usunUzyt.Location = new System.Drawing.Point(1252, 156);
            this.usunUzyt.Name = "usunUzyt";
            this.usunUzyt.Size = new System.Drawing.Size(78, 23);
            this.usunUzyt.TabIndex = 19;
            this.usunUzyt.Text = "Użytkownika";
            this.usunUzyt.UseVisualStyleBackColor = true;
            this.usunUzyt.Visible = false;
            this.usunUzyt.Click += new System.EventHandler(this.usunUzyt_Click);
            // 
            // usun
            // 
            this.usun.AutoSize = true;
            this.usun.Location = new System.Drawing.Point(1311, 140);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(35, 13);
            this.usun.TabIndex = 20;
            this.usun.Text = "Usuń:";
            this.usun.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1149, 485);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(384, 43);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "\nSPOŁECZNOŚCIÓWKI (ikonki prowadzące do stron głównych kilku serwisów)";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1254, 96);
            this.richTextBox2.TabIndex = 22;
            this.richTextBox2.Text = "Cudaczna BELKA, bez której żadna strona nie może się dziś obejść (minus jeżdżenie" +
    " przy zsuwaniu ;P)";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(22, 184);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(973, 111);
            this.richTextBox3.TabIndex = 23;
            this.richTextBox3.Text = "OBRAZEK 1 (weźmiemy coś z Internetu, oczywiście z tych legalnych ;)";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(397, 46);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(428, 105);
            this.richTextBox4.TabIndex = 24;
            this.richTextBox4.Text = "\n\n\nLOGO (prawdopodobnie obrazek jak w naszej ikonce tylko z dodanym \"AL\" nad jedn" +
    "ą i \"TS\" nad drugą paletką)";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(1170, 308);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(363, 154);
            this.richTextBox5.TabIndex = 25;
            this.richTextBox5.Text = "\n\n\n\n\n\t\t\tREKLAMA";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(22, 363);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(973, 111);
            this.richTextBox6.TabIndex = 26;
            this.richTextBox6.Text = "OBRAZEK 2 (chyba że ktoś chce zapozować do zdjęcia :P)";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(555, 510);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(360, 42);
            this.richTextBox7.TabIndex = 27;
            this.richTextBox7.Text = "ALL RIGHTS RESERVED TO US (wstawi się tu nasze inicjały albo coś)";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(49, 308);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(208, 35);
            this.richTextBox8.TabIndex = 28;
            this.richTextBox8.Text = "???Jakiś TEKST na zajęcie miejsca???";
            // 
            // richTextBox9
            // 
            this.richTextBox9.Location = new System.Drawing.Point(1023, 163);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(224, 126);
            this.richTextBox9.TabIndex = 29;
            this.richTextBox9.Text = resources.GetString("richTextBox9.Text");
            // 
            // richTextBox10
            // 
            this.richTextBox10.Location = new System.Drawing.Point(49, 485);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(208, 35);
            this.richTextBox10.TabIndex = 30;
            this.richTextBox10.Text = "???Albo PODPIS???";
            // 
            // richTextBox11
            // 
            this.richTextBox11.Location = new System.Drawing.Point(1023, 308);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.Size = new System.Drawing.Size(110, 234);
            this.richTextBox11.TabIndex = 31;
            this.richTextBox11.Text = "TŁO będące stołem";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1542, 554);
            this.Controls.Add(this.richTextBox11);
            this.Controls.Add(this.richTextBox10);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.usunUzyt);
            this.Controls.Add(this.usunDruz);
            this.Controls.Add(this.messagesButton);
            this.Controls.Add(this.confirmConfirmationButton);
            this.Controls.Add(this.myRegistrationButton);
            this.Controls.Add(this.numberOfTeamRegistrationsLabel);
            this.Controls.Add(this.teamRegistrationsButton);
            this.Controls.Add(this.niezalogowany);
            this.Controls.Add(this.registerTeamButton);
            this.Controls.Add(this.regulaminButton);
            this.Controls.Add(this.wynikiButton);
            this.Controls.Add(this.klasyfikacjaButton);
            this.Controls.Add(this.terminarzButton);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.druzynaLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.LabelZJ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Amatorska Liga Tenisa Stołowego";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelZJ;
        private System.Windows.Forms.Label LoggedInAsLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label druzynaLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button terminarzButton;
        private System.Windows.Forms.Button klasyfikacjaButton;
        private System.Windows.Forms.Button wynikiButton;
        private System.Windows.Forms.Button regulaminButton;
        private System.Windows.Forms.Button registerTeamButton;
        private System.Windows.Forms.Label niezalogowany;
        private System.Windows.Forms.Button teamRegistrationsButton;
        private System.Windows.Forms.Label numberOfTeamRegistrationsLabel;
        private System.Windows.Forms.Button myRegistrationButton;
        private System.Windows.Forms.Button confirmConfirmationButton;
        private System.Windows.Forms.Button messagesButton;
        private System.ComponentModel.BackgroundWorker messageBackgroundWorker;
        private System.Windows.Forms.Button usunDruz;
        private System.Windows.Forms.Button usunUzyt;
        private System.Windows.Forms.Label usun;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.RichTextBox richTextBox11;
    }
}

