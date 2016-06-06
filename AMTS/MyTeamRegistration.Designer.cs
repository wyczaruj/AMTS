namespace AMTS
{
    partial class MyTeamRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTeamRegistration));
            this.skład = new System.Windows.Forms.Label();
            this.playersListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.captainColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.confirmationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.nazwa = new System.Windows.Forms.Label();
            this.cancelRegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skład
            // 
            this.skład.AutoSize = true;
            this.skład.BackColor = System.Drawing.Color.Transparent;
            this.skład.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.skład.Location = new System.Drawing.Point(27, 69);
            this.skład.Name = "skład";
            this.skład.Size = new System.Drawing.Size(84, 35);
            this.skład.TabIndex = 2;
            this.skład.Text = "Skład:";
            // 
            // playersListView
            // 
            this.playersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.lastNameColumnHeader,
            this.emailColumnHeader,
            this.captainColumnHeader,
            this.confirmationColumnHeader});
            this.playersListView.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.playersListView.Location = new System.Drawing.Point(137, 69);
            this.playersListView.MultiSelect = false;
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(647, 371);
            this.playersListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.playersListView.TabIndex = 7;
            this.playersListView.UseCompatibleStateImageBehavior = false;
            this.playersListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Imię";
            this.nameColumnHeader.Width = 100;
            // 
            // lastNameColumnHeader
            // 
            this.lastNameColumnHeader.Text = "Nazwisko";
            this.lastNameColumnHeader.Width = 120;
            // 
            // emailColumnHeader
            // 
            this.emailColumnHeader.Text = "E-mail";
            this.emailColumnHeader.Width = 120;
            // 
            // captainColumnHeader
            // 
            this.captainColumnHeader.Text = "Kapitan";
            this.captainColumnHeader.Width = 81;
            // 
            // confirmationColumnHeader
            // 
            this.confirmationColumnHeader.Text = "Potwierdzenie";
            this.confirmationColumnHeader.Width = 140;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.teamNameLabel.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.teamNameLabel.Location = new System.Drawing.Point(259, 20);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(473, 35);
            this.teamNameLabel.TabIndex = 1;
            this.teamNameLabel.Text = "Przykładowa długa nazwa mojej drużyny";
            // 
            // nazwa
            // 
            this.nazwa.AutoSize = true;
            this.nazwa.BackColor = System.Drawing.Color.Transparent;
            this.nazwa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.nazwa.Location = new System.Drawing.Point(24, 20);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(198, 35);
            this.nazwa.TabIndex = 0;
            this.nazwa.Text = "Nazwa drużyny:";
            // 
            // cancelRegistrationButton
            // 
            this.cancelRegistrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelRegistrationButton.Location = new System.Drawing.Point(137, 446);
            this.cancelRegistrationButton.Name = "cancelRegistrationButton";
            this.cancelRegistrationButton.Size = new System.Drawing.Size(647, 39);
            this.cancelRegistrationButton.TabIndex = 8;
            this.cancelRegistrationButton.Text = "Anuluj zgłoszenie";
            this.cancelRegistrationButton.UseVisualStyleBackColor = true;
            this.cancelRegistrationButton.Visible = false;
            this.cancelRegistrationButton.Click += new System.EventHandler(this.cancelRegistrationButton_Click);
            // 
            // MyTeamRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AMTS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.cancelRegistrationButton);
            this.Controls.Add(this.playersListView);
            this.Controls.Add(this.skład);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.nazwa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyTeamRegistration";
            this.Text = "Moja drużyna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyTeamRegistration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label skład;
        private System.Windows.Forms.ListView playersListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader captainColumnHeader;
        private System.Windows.Forms.ColumnHeader confirmationColumnHeader;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label nazwa;
        private System.Windows.Forms.Button cancelRegistrationButton;
    }
}