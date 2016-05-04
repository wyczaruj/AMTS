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
            this.LabelZJ = new System.Windows.Forms.Label();
            this.LoggedInAsLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.druzynaLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.terminarz = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.registerTeam = new System.Windows.Forms.Button();
            this.niezalogowany = new System.Windows.Forms.Label();
            this.teamRegistrationsButton = new System.Windows.Forms.Button();
            this.numberOfTeamRegistrationsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelZJ
            // 
            this.LabelZJ.AutoSize = true;
            this.LabelZJ.Location = new System.Drawing.Point(695, 15);
            this.LabelZJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelZJ.Name = "LabelZJ";
            this.LabelZJ.Size = new System.Drawing.Size(91, 13);
            this.LabelZJ.TabIndex = 0;
            this.LabelZJ.Text = "Zalogowany jako:";
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Location = new System.Drawing.Point(788, 15);
            this.LoggedInAsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(32, 13);
            this.LoggedInAsLabel.TabIndex = 1;
            this.LoggedInAsLabel.Text = "Gość";
            this.LoggedInAsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(844, 38);
            this.logInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(78, 27);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Zaloguj się";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(867, 38);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(56, 27);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(844, 77);
            this.registerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(78, 27);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Rejestracja";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // druzynaLabel
            // 
            this.druzynaLabel.AutoSize = true;
            this.druzynaLabel.Location = new System.Drawing.Point(695, 77);
            this.druzynaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.druzynaLabel.Name = "druzynaLabel";
            this.druzynaLabel.Size = new System.Drawing.Size(49, 13);
            this.druzynaLabel.TabIndex = 5;
            this.druzynaLabel.Text = "Drużyna:";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(750, 77);
            this.teamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(159, 13);
            this.teamLabel.TabIndex = 6;
            this.teamLabel.Text = "druzyna [NIEZATWIERDZONA]";
            // 
            // terminarz
            // 
            this.terminarz.Location = new System.Drawing.Point(12, 5);
            this.terminarz.Name = "terminarz";
            this.terminarz.Size = new System.Drawing.Size(75, 23);
            this.terminarz.TabIndex = 7;
            this.terminarz.Text = "Terminarz";
            this.terminarz.UseVisualStyleBackColor = true;
            this.terminarz.Click += new System.EventHandler(this.terminarz_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Klasyfikacja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Użytkownicy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(289, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Regulamin";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // registerTeam
            // 
            this.registerTeam.Location = new System.Drawing.Point(818, 214);
            this.registerTeam.Name = "registerTeam";
            this.registerTeam.Size = new System.Drawing.Size(105, 25);
            this.registerTeam.TabIndex = 11;
            this.registerTeam.Text = "Zgłoś drużynę";
            this.registerTeam.UseVisualStyleBackColor = true;
            this.registerTeam.Click += new System.EventHandler(this.registerTeam_Click);
            // 
            // niezalogowany
            // 
            this.niezalogowany.AutoSize = true;
            this.niezalogowany.ForeColor = System.Drawing.Color.Red;
            this.niezalogowany.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.niezalogowany.Location = new System.Drawing.Point(842, 242);
            this.niezalogowany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.niezalogowany.Name = "niezalogowany";
            this.niezalogowany.Size = new System.Drawing.Size(61, 13);
            this.niezalogowany.TabIndex = 12;
            this.niezalogowany.Text = "Zaloguj się.";
            this.niezalogowany.Visible = false;
            // 
            // teamRegistrationsButton
            // 
            this.teamRegistrationsButton.Location = new System.Drawing.Point(817, 354);
            this.teamRegistrationsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teamRegistrationsButton.Name = "teamRegistrationsButton";
            this.teamRegistrationsButton.Size = new System.Drawing.Size(106, 28);
            this.teamRegistrationsButton.TabIndex = 13;
            this.teamRegistrationsButton.Text = "Zgłoszenia drużyn";
            this.teamRegistrationsButton.UseVisualStyleBackColor = true;
            this.teamRegistrationsButton.Visible = false;
            this.teamRegistrationsButton.Click += new System.EventHandler(this.teamRegistrationsButton_Click);
            // 
            // numberOfTeamRegistrationsLabel
            // 
            this.numberOfTeamRegistrationsLabel.AutoSize = true;
            this.numberOfTeamRegistrationsLabel.Location = new System.Drawing.Point(787, 362);
            this.numberOfTeamRegistrationsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfTeamRegistrationsLabel.Name = "numberOfTeamRegistrationsLabel";
            this.numberOfTeamRegistrationsLabel.Size = new System.Drawing.Size(25, 13);
            this.numberOfTeamRegistrationsLabel.TabIndex = 14;
            this.numberOfTeamRegistrationsLabel.Text = "(14)";
            this.numberOfTeamRegistrationsLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 392);
            this.Controls.Add(this.numberOfTeamRegistrationsLabel);
            this.Controls.Add(this.teamRegistrationsButton);
            this.Controls.Add(this.niezalogowany);
            this.Controls.Add(this.registerTeam);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.terminarz);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.druzynaLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.LoggedInAsLabel);
            this.Controls.Add(this.LabelZJ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button terminarz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button registerTeam;
        private System.Windows.Forms.Label niezalogowany;
        private System.Windows.Forms.Button teamRegistrationsButton;
        private System.Windows.Forms.Label numberOfTeamRegistrationsLabel;
    }
}

