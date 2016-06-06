namespace AMTS
{
    partial class DodajDruzyne
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajDruzyne));
            this.uzytkownicyComboBox = new System.Windows.Forms.ComboBox();
            this.nazwisko1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Label();
            this.i1 = new System.Windows.Forms.Label();
            this.imie1 = new System.Windows.Forms.TextBox();
            this.addPerson = new System.Windows.Forms.Button();
            this.cancelTeam = new System.Windows.Forms.Button();
            this.registerTeam = new System.Windows.Forms.Button();
            this.nazwisko2 = new System.Windows.Forms.TextBox();
            this.nazwisko4 = new System.Windows.Forms.TextBox();
            this.imie4 = new System.Windows.Forms.TextBox();
            this.nazwisko3 = new System.Windows.Forms.TextBox();
            this.imie3 = new System.Windows.Forms.TextBox();
            this.nazwisko8 = new System.Windows.Forms.TextBox();
            this.imie8 = new System.Windows.Forms.TextBox();
            this.nazwisko7 = new System.Windows.Forms.TextBox();
            this.imie7 = new System.Windows.Forms.TextBox();
            this.nazwisko6 = new System.Windows.Forms.TextBox();
            this.imie6 = new System.Windows.Forms.TextBox();
            this.nazwisko5 = new System.Windows.Forms.TextBox();
            this.imie5 = new System.Windows.Forms.TextBox();
            this.nazwisko10 = new System.Windows.Forms.TextBox();
            this.imie10 = new System.Windows.Forms.TextBox();
            this.nazwisko9 = new System.Windows.Forms.TextBox();
            this.imie9 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.imie2 = new System.Windows.Forms.TextBox();
            this.warningDownLabel = new System.Windows.Forms.Label();
            this.warningUpLabel = new System.Windows.Forms.Label();
            this.TeamNameTakenLabel = new System.Windows.Forms.Label();
            this.alreadyAddedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uzytkownicyComboBox
            // 
            this.uzytkownicyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uzytkownicyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.uzytkownicyComboBox.Font = new System.Drawing.Font("Calibri", 9F);
            this.uzytkownicyComboBox.FormattingEnabled = true;
            this.uzytkownicyComboBox.Location = new System.Drawing.Point(117, 43);
            this.uzytkownicyComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.uzytkownicyComboBox.Name = "uzytkownicyComboBox";
            this.uzytkownicyComboBox.Size = new System.Drawing.Size(281, 26);
            this.uzytkownicyComboBox.Sorted = true;
            this.uzytkownicyComboBox.TabIndex = 1;
            // 
            // nazwisko1
            // 
            this.nazwisko1.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko1.Location = new System.Drawing.Point(56, 123);
            this.nazwisko1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko1.Name = "nazwisko1";
            this.nazwisko1.ReadOnly = true;
            this.nazwisko1.Size = new System.Drawing.Size(149, 26);
            this.nazwisko1.TabIndex = 14;
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.BackColor = System.Drawing.Color.Transparent;
            this.n1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.n1.Location = new System.Drawing.Point(53, 96);
            this.n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(67, 18);
            this.n1.TabIndex = 13;
            this.n1.Text = "Nazwisko";
            // 
            // i1
            // 
            this.i1.AutoSize = true;
            this.i1.BackColor = System.Drawing.Color.Transparent;
            this.i1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.i1.Location = new System.Drawing.Point(287, 96);
            this.i1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.i1.Name = "i1";
            this.i1.Size = new System.Drawing.Size(36, 18);
            this.i1.TabIndex = 12;
            this.i1.Text = "Imię";
            // 
            // imie1
            // 
            this.imie1.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie1.Location = new System.Drawing.Point(292, 123);
            this.imie1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie1.Name = "imie1";
            this.imie1.ReadOnly = true;
            this.imie1.Size = new System.Drawing.Size(156, 26);
            this.imie1.TabIndex = 11;
            // 
            // addPerson
            // 
            this.addPerson.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.addPerson.Location = new System.Drawing.Point(402, 38);
            this.addPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(71, 29);
            this.addPerson.TabIndex = 10;
            this.addPerson.Text = "Dodaj";
            this.addPerson.UseVisualStyleBackColor = true;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // cancelTeam
            // 
            this.cancelTeam.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.cancelTeam.Location = new System.Drawing.Point(8, 585);
            this.cancelTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelTeam.Name = "cancelTeam";
            this.cancelTeam.Size = new System.Drawing.Size(155, 38);
            this.cancelTeam.TabIndex = 17;
            this.cancelTeam.Text = "Anuluj";
            this.cancelTeam.UseVisualStyleBackColor = true;
            this.cancelTeam.Click += new System.EventHandler(this.cancelTeam_Click);
            // 
            // registerTeam
            // 
            this.registerTeam.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.registerTeam.Location = new System.Drawing.Point(323, 585);
            this.registerTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerTeam.Name = "registerTeam";
            this.registerTeam.Size = new System.Drawing.Size(155, 38);
            this.registerTeam.TabIndex = 18;
            this.registerTeam.Text = "Zatwierdź";
            this.registerTeam.UseVisualStyleBackColor = true;
            this.registerTeam.Click += new System.EventHandler(this.registerTeam_Click);
            // 
            // nazwisko2
            // 
            this.nazwisko2.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko2.Location = new System.Drawing.Point(56, 165);
            this.nazwisko2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko2.Name = "nazwisko2";
            this.nazwisko2.ReadOnly = true;
            this.nazwisko2.Size = new System.Drawing.Size(149, 26);
            this.nazwisko2.TabIndex = 22;
            this.nazwisko2.Visible = false;
            // 
            // nazwisko4
            // 
            this.nazwisko4.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko4.Location = new System.Drawing.Point(56, 247);
            this.nazwisko4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko4.Name = "nazwisko4";
            this.nazwisko4.ReadOnly = true;
            this.nazwisko4.Size = new System.Drawing.Size(149, 26);
            this.nazwisko4.TabIndex = 30;
            this.nazwisko4.Visible = false;
            // 
            // imie4
            // 
            this.imie4.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie4.Location = new System.Drawing.Point(292, 247);
            this.imie4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie4.Name = "imie4";
            this.imie4.ReadOnly = true;
            this.imie4.Size = new System.Drawing.Size(156, 26);
            this.imie4.TabIndex = 27;
            this.imie4.Visible = false;
            // 
            // nazwisko3
            // 
            this.nazwisko3.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko3.Location = new System.Drawing.Point(56, 205);
            this.nazwisko3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko3.Name = "nazwisko3";
            this.nazwisko3.ReadOnly = true;
            this.nazwisko3.Size = new System.Drawing.Size(149, 26);
            this.nazwisko3.TabIndex = 26;
            this.nazwisko3.Visible = false;
            // 
            // imie3
            // 
            this.imie3.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie3.Location = new System.Drawing.Point(292, 205);
            this.imie3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie3.Name = "imie3";
            this.imie3.ReadOnly = true;
            this.imie3.Size = new System.Drawing.Size(156, 26);
            this.imie3.TabIndex = 23;
            this.imie3.Visible = false;
            // 
            // nazwisko8
            // 
            this.nazwisko8.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko8.Location = new System.Drawing.Point(56, 412);
            this.nazwisko8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko8.Name = "nazwisko8";
            this.nazwisko8.ReadOnly = true;
            this.nazwisko8.Size = new System.Drawing.Size(149, 26);
            this.nazwisko8.TabIndex = 46;
            this.nazwisko8.Visible = false;
            // 
            // imie8
            // 
            this.imie8.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie8.Location = new System.Drawing.Point(292, 412);
            this.imie8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie8.Name = "imie8";
            this.imie8.ReadOnly = true;
            this.imie8.Size = new System.Drawing.Size(156, 26);
            this.imie8.TabIndex = 43;
            this.imie8.Visible = false;
            // 
            // nazwisko7
            // 
            this.nazwisko7.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko7.Location = new System.Drawing.Point(56, 370);
            this.nazwisko7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko7.Name = "nazwisko7";
            this.nazwisko7.ReadOnly = true;
            this.nazwisko7.Size = new System.Drawing.Size(149, 26);
            this.nazwisko7.TabIndex = 42;
            this.nazwisko7.Visible = false;
            // 
            // imie7
            // 
            this.imie7.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie7.Location = new System.Drawing.Point(292, 370);
            this.imie7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie7.Name = "imie7";
            this.imie7.ReadOnly = true;
            this.imie7.Size = new System.Drawing.Size(156, 26);
            this.imie7.TabIndex = 39;
            this.imie7.Visible = false;
            // 
            // nazwisko6
            // 
            this.nazwisko6.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko6.Location = new System.Drawing.Point(56, 330);
            this.nazwisko6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko6.Name = "nazwisko6";
            this.nazwisko6.ReadOnly = true;
            this.nazwisko6.Size = new System.Drawing.Size(149, 26);
            this.nazwisko6.TabIndex = 38;
            this.nazwisko6.Visible = false;
            // 
            // imie6
            // 
            this.imie6.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie6.Location = new System.Drawing.Point(292, 330);
            this.imie6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie6.Name = "imie6";
            this.imie6.ReadOnly = true;
            this.imie6.Size = new System.Drawing.Size(156, 26);
            this.imie6.TabIndex = 35;
            this.imie6.Visible = false;
            // 
            // nazwisko5
            // 
            this.nazwisko5.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko5.Location = new System.Drawing.Point(56, 288);
            this.nazwisko5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko5.Name = "nazwisko5";
            this.nazwisko5.ReadOnly = true;
            this.nazwisko5.Size = new System.Drawing.Size(149, 26);
            this.nazwisko5.TabIndex = 34;
            this.nazwisko5.Visible = false;
            // 
            // imie5
            // 
            this.imie5.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie5.Location = new System.Drawing.Point(292, 288);
            this.imie5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie5.Name = "imie5";
            this.imie5.ReadOnly = true;
            this.imie5.Size = new System.Drawing.Size(156, 26);
            this.imie5.TabIndex = 31;
            this.imie5.Visible = false;
            // 
            // nazwisko10
            // 
            this.nazwisko10.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko10.Location = new System.Drawing.Point(56, 495);
            this.nazwisko10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko10.Name = "nazwisko10";
            this.nazwisko10.ReadOnly = true;
            this.nazwisko10.Size = new System.Drawing.Size(149, 26);
            this.nazwisko10.TabIndex = 54;
            this.nazwisko10.Visible = false;
            // 
            // imie10
            // 
            this.imie10.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie10.Location = new System.Drawing.Point(290, 495);
            this.imie10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie10.Name = "imie10";
            this.imie10.ReadOnly = true;
            this.imie10.Size = new System.Drawing.Size(156, 26);
            this.imie10.TabIndex = 51;
            this.imie10.Visible = false;
            // 
            // nazwisko9
            // 
            this.nazwisko9.Font = new System.Drawing.Font("Calibri", 9F);
            this.nazwisko9.Location = new System.Drawing.Point(56, 453);
            this.nazwisko9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko9.Name = "nazwisko9";
            this.nazwisko9.ReadOnly = true;
            this.nazwisko9.Size = new System.Drawing.Size(149, 26);
            this.nazwisko9.TabIndex = 50;
            this.nazwisko9.Visible = false;
            // 
            // imie9
            // 
            this.imie9.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie9.Location = new System.Drawing.Point(292, 453);
            this.imie9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie9.Name = "imie9";
            this.imie9.ReadOnly = true;
            this.imie9.Size = new System.Drawing.Size(156, 26);
            this.imie9.TabIndex = 47;
            this.imie9.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(5, 17);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 18);
            this.label18.TabIndex = 58;
            this.label18.Text = "Nazwa drużyny";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Font = new System.Drawing.Font("Calibri", 9F);
            this.teamNameTextBox.Location = new System.Drawing.Point(116, 14);
            this.teamNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(282, 26);
            this.teamNameTextBox.TabIndex = 57;
            this.teamNameTextBox.TextChanged += new System.EventHandler(this.teamName_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(5, 78);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 18);
            this.label19.TabIndex = 59;
            this.label19.Text = "Członkowie:";
            // 
            // imie2
            // 
            this.imie2.Font = new System.Drawing.Font("Calibri", 9F);
            this.imie2.Location = new System.Drawing.Point(290, 165);
            this.imie2.Margin = new System.Windows.Forms.Padding(4);
            this.imie2.Name = "imie2";
            this.imie2.ReadOnly = true;
            this.imie2.Size = new System.Drawing.Size(159, 26);
            this.imie2.TabIndex = 62;
            this.imie2.Visible = false;
            // 
            // warningDownLabel
            // 
            this.warningDownLabel.AutoSize = true;
            this.warningDownLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningDownLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.warningDownLabel.ForeColor = System.Drawing.Color.Tomato;
            this.warningDownLabel.Location = new System.Drawing.Point(12, 538);
            this.warningDownLabel.Name = "warningDownLabel";
            this.warningDownLabel.Size = new System.Drawing.Size(225, 18);
            this.warningDownLabel.TabIndex = 63;
            this.warningDownLabel.Text = "Masz mniej niż trzech zawodników.";
            this.warningDownLabel.Visible = false;
            // 
            // warningUpLabel
            // 
            this.warningUpLabel.AutoSize = true;
            this.warningUpLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningUpLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.warningUpLabel.ForeColor = System.Drawing.Color.Tomato;
            this.warningUpLabel.Location = new System.Drawing.Point(12, 555);
            this.warningUpLabel.Name = "warningUpLabel";
            this.warningUpLabel.Size = new System.Drawing.Size(247, 18);
            this.warningUpLabel.TabIndex = 64;
            this.warningUpLabel.Text = "Nie możesz dodać więcej zawodników.";
            this.warningUpLabel.Visible = false;
            // 
            // TeamNameTakenLabel
            // 
            this.TeamNameTakenLabel.AutoSize = true;
            this.TeamNameTakenLabel.BackColor = System.Drawing.Color.Transparent;
            this.TeamNameTakenLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.TeamNameTakenLabel.ForeColor = System.Drawing.Color.Tomato;
            this.TeamNameTakenLabel.Location = new System.Drawing.Point(404, 19);
            this.TeamNameTakenLabel.Name = "TeamNameTakenLabel";
            this.TeamNameTakenLabel.Size = new System.Drawing.Size(89, 18);
            this.TeamNameTakenLabel.TabIndex = 65;
            this.TeamNameTakenLabel.Text = "Nazwa zajęta";
            this.TeamNameTakenLabel.Visible = false;
            // 
            // alreadyAddedLabel
            // 
            this.alreadyAddedLabel.AutoSize = true;
            this.alreadyAddedLabel.BackColor = System.Drawing.Color.Transparent;
            this.alreadyAddedLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.alreadyAddedLabel.ForeColor = System.Drawing.Color.Tomato;
            this.alreadyAddedLabel.Location = new System.Drawing.Point(12, 521);
            this.alreadyAddedLabel.Name = "alreadyAddedLabel";
            this.alreadyAddedLabel.Size = new System.Drawing.Size(183, 18);
            this.alreadyAddedLabel.TabIndex = 66;
            this.alreadyAddedLabel.Text = "Już dodałeś tego zawodnika.";
            this.alreadyAddedLabel.Visible = false;
            // 
            // DodajDruzyne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AMTS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(493, 629);
            this.Controls.Add(this.alreadyAddedLabel);
            this.Controls.Add(this.TeamNameTakenLabel);
            this.Controls.Add(this.warningUpLabel);
            this.Controls.Add(this.warningDownLabel);
            this.Controls.Add(this.imie2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.nazwisko10);
            this.Controls.Add(this.imie10);
            this.Controls.Add(this.nazwisko9);
            this.Controls.Add(this.imie9);
            this.Controls.Add(this.nazwisko8);
            this.Controls.Add(this.imie8);
            this.Controls.Add(this.nazwisko7);
            this.Controls.Add(this.imie7);
            this.Controls.Add(this.nazwisko6);
            this.Controls.Add(this.imie6);
            this.Controls.Add(this.nazwisko5);
            this.Controls.Add(this.imie5);
            this.Controls.Add(this.nazwisko4);
            this.Controls.Add(this.imie4);
            this.Controls.Add(this.nazwisko3);
            this.Controls.Add(this.imie3);
            this.Controls.Add(this.nazwisko2);
            this.Controls.Add(this.registerTeam);
            this.Controls.Add(this.cancelTeam);
            this.Controls.Add(this.nazwisko1);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.i1);
            this.Controls.Add(this.imie1);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.uzytkownicyComboBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DodajDruzyne";
            this.Text = "Zgłoś drużynę";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodajDruzyne_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uzytkownicyComboBox;
        private System.Windows.Forms.TextBox nazwisko1;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.TextBox imie1;
        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.Button cancelTeam;
        private System.Windows.Forms.Button registerTeam;
        private System.Windows.Forms.TextBox nazwisko2;
        private System.Windows.Forms.TextBox nazwisko4;
        private System.Windows.Forms.TextBox imie4;
        private System.Windows.Forms.TextBox nazwisko3;
        private System.Windows.Forms.TextBox imie3;
        private System.Windows.Forms.TextBox nazwisko8;
        private System.Windows.Forms.TextBox imie8;
        private System.Windows.Forms.TextBox nazwisko7;
        private System.Windows.Forms.TextBox imie7;
        private System.Windows.Forms.TextBox nazwisko6;
        private System.Windows.Forms.TextBox imie6;
        private System.Windows.Forms.TextBox nazwisko5;
        private System.Windows.Forms.TextBox imie5;
        private System.Windows.Forms.TextBox nazwisko10;
        private System.Windows.Forms.TextBox imie10;
        private System.Windows.Forms.TextBox nazwisko9;
        private System.Windows.Forms.TextBox imie9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label i1;
        private System.Windows.Forms.TextBox imie2;
        private System.Windows.Forms.Label warningDownLabel;
        private System.Windows.Forms.Label warningUpLabel;
        private System.Windows.Forms.Label TeamNameTakenLabel;
        private System.Windows.Forms.Label alreadyAddedLabel;
    }
}