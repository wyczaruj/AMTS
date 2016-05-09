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
            this.SuspendLayout();
            // 
            // confirmConfirmationButton
            // 
            this.confirmConfirmationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmConfirmationButton.Location = new System.Drawing.Point(12, 224);
            this.confirmConfirmationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmConfirmationButton.Name = "confirmConfirmationButton";
            this.confirmConfirmationButton.Size = new System.Drawing.Size(151, 44);
            this.confirmConfirmationButton.TabIndex = 16;
            this.confirmConfirmationButton.Text = "Potwierdź swój udział";
            this.confirmConfirmationButton.UseVisualStyleBackColor = true;
            this.confirmConfirmationButton.Visible = false;
            this.confirmConfirmationButton.Click += new System.EventHandler(this.confirmConfirmationButton_Click);
            // 
            // myRegistrationButton
            // 
            this.myRegistrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.myRegistrationButton.Location = new System.Drawing.Point(186, 224);
            this.myRegistrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myRegistrationButton.Name = "myRegistrationButton";
            this.myRegistrationButton.Size = new System.Drawing.Size(137, 44);
            this.myRegistrationButton.TabIndex = 15;
            this.myRegistrationButton.Text = "Moje zgłoszenie";
            this.myRegistrationButton.UseVisualStyleBackColor = true;
            this.myRegistrationButton.Visible = false;
            this.myRegistrationButton.Click += new System.EventHandler(this.myRegistrationButton_Click);
            // 
            // numberOfTeamRegistrationsLabel
            // 
            this.numberOfTeamRegistrationsLabel.AutoSize = true;
            this.numberOfTeamRegistrationsLabel.Location = new System.Drawing.Point(827, 446);
            this.numberOfTeamRegistrationsLabel.Name = "numberOfTeamRegistrationsLabel";
            this.numberOfTeamRegistrationsLabel.Size = new System.Drawing.Size(34, 17);
            this.numberOfTeamRegistrationsLabel.TabIndex = 14;
            this.numberOfTeamRegistrationsLabel.Text = "(14)";
            this.numberOfTeamRegistrationsLabel.Visible = false;
            // 
            // teamRegistrationsButton
            // 
            this.teamRegistrationsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.teamRegistrationsButton.Location = new System.Drawing.Point(417, 224);
            this.teamRegistrationsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamRegistrationsButton.Name = "teamRegistrationsButton";
            this.teamRegistrationsButton.Size = new System.Drawing.Size(141, 44);
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
            this.niezalogowany.Location = new System.Drawing.Point(450, 189);
            this.niezalogowany.Name = "niezalogowany";
            this.niezalogowany.Size = new System.Drawing.Size(81, 17);
            this.niezalogowany.TabIndex = 12;
            this.niezalogowany.Text = "Zaloguj się.";
            this.niezalogowany.Visible = false;
            // 
            // registerTeamButton
            // 
            this.registerTeamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerTeamButton.Location = new System.Drawing.Point(418, 154);
            this.registerTeamButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerTeamButton.Name = "registerTeamButton";
            this.registerTeamButton.Size = new System.Drawing.Size(140, 31);
            this.registerTeamButton.TabIndex = 11;
            this.registerTeamButton.Text = "Zgłoś drużynę";
            this.registerTeamButton.UseVisualStyleBackColor = true;
            this.registerTeamButton.Click += new System.EventHandler(this.registerTeam_Click);
            // 
            // regulaminButton
            // 
            this.regulaminButton.Location = new System.Drawing.Point(16, 42);
            this.regulaminButton.Margin = new System.Windows.Forms.Padding(4);
            this.regulaminButton.Name = "regulaminButton";
            this.regulaminButton.Size = new System.Drawing.Size(100, 28);
            this.regulaminButton.TabIndex = 10;
            this.regulaminButton.Text = "Regulamin";
            this.regulaminButton.UseVisualStyleBackColor = true;
            this.regulaminButton.Click += new System.EventHandler(this.regulaminButton_Click);
            // 
            // wynikiButton
            // 
            this.wynikiButton.Location = new System.Drawing.Point(143, 42);
            this.wynikiButton.Margin = new System.Windows.Forms.Padding(4);
            this.wynikiButton.Name = "wynikiButton";
            this.wynikiButton.Size = new System.Drawing.Size(100, 28);
            this.wynikiButton.TabIndex = 9;
            this.wynikiButton.Text = "Wyniki";
            this.wynikiButton.UseVisualStyleBackColor = true;
            this.wynikiButton.Visible = false;
            // 
            // klasyfikacjaButton
            // 
            this.klasyfikacjaButton.Location = new System.Drawing.Point(143, 6);
            this.klasyfikacjaButton.Margin = new System.Windows.Forms.Padding(4);
            this.klasyfikacjaButton.Name = "klasyfikacjaButton";
            this.klasyfikacjaButton.Size = new System.Drawing.Size(100, 28);
            this.klasyfikacjaButton.TabIndex = 8;
            this.klasyfikacjaButton.Text = "Klasyfikacja";
            this.klasyfikacjaButton.UseVisualStyleBackColor = true;
            this.klasyfikacjaButton.Click += new System.EventHandler(this.klasyfikacjaButton_Click);
            // 
            // terminarzButton
            // 
            this.terminarzButton.Location = new System.Drawing.Point(16, 6);
            this.terminarzButton.Margin = new System.Windows.Forms.Padding(4);
            this.terminarzButton.Name = "terminarzButton";
            this.terminarzButton.Size = new System.Drawing.Size(100, 28);
            this.terminarzButton.TabIndex = 7;
            this.terminarzButton.Text = "Terminarz";
            this.terminarzButton.UseVisualStyleBackColor = true;
            this.terminarzButton.Click += new System.EventHandler(this.terminarzButton_Click);
            // 
            // teamLabel
            // 
            this.teamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(325, 94);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(204, 17);
            this.teamLabel.TabIndex = 6;
            this.teamLabel.Text = "druzyna [NIEZATWIERDZONA]";
            // 
            // druzynaLabel
            // 
            this.druzynaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.druzynaLabel.AutoSize = true;
            this.druzynaLabel.Location = new System.Drawing.Point(264, 94);
            this.druzynaLabel.Name = "druzynaLabel";
            this.druzynaLabel.Size = new System.Drawing.Size(65, 17);
            this.druzynaLabel.TabIndex = 5;
            this.druzynaLabel.Text = "Drużyna:";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Location = new System.Drawing.Point(449, 94);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(104, 33);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Rejestracja";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.Location = new System.Drawing.Point(478, 11);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 33);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInButton.Location = new System.Drawing.Point(448, 11);
            this.logInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(104, 33);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Zaloguj się";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // LoggedInAsLabel
            // 
            this.LoggedInAsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoggedInAsLabel.AutoSize = true;
            this.LoggedInAsLabel.Location = new System.Drawing.Point(388, 17);
            this.LoggedInAsLabel.Name = "LoggedInAsLabel";
            this.LoggedInAsLabel.Size = new System.Drawing.Size(41, 17);
            this.LoggedInAsLabel.TabIndex = 1;
            this.LoggedInAsLabel.Text = "Gość";
            this.LoggedInAsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelZJ
            // 
            this.LabelZJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelZJ.AutoSize = true;
            this.LabelZJ.Location = new System.Drawing.Point(264, 17);
            this.LabelZJ.Name = "LabelZJ";
            this.LabelZJ.Size = new System.Drawing.Size(118, 17);
            this.LabelZJ.TabIndex = 0;
            this.LabelZJ.Text = "Zalogowany jako:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 279);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

