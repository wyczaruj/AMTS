namespace AMTS
{
    partial class TeamRegistrations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamRegistrations));
            this.acceptButton = new System.Windows.Forms.Button();
            this.teamsListView = new System.Windows.Forms.ListView();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.playersListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.captainColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.closeButton = new System.Windows.Forms.Button();
            this.rejectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.acceptButton.Location = new System.Drawing.Point(500, 478);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(186, 39);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Zatwierdź zaznaczone";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // teamsListView
            // 
            this.teamsListView.CheckBoxes = true;
            this.teamsListView.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsListView.Location = new System.Drawing.Point(23, 22);
            this.teamsListView.MultiSelect = false;
            this.teamsListView.Name = "teamsListView";
            this.teamsListView.Size = new System.Drawing.Size(238, 445);
            this.teamsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.teamsListView.TabIndex = 4;
            this.teamsListView.UseCompatibleStateImageBehavior = false;
            this.teamsListView.View = System.Windows.Forms.View.SmallIcon;
            this.teamsListView.SelectedIndexChanged += new System.EventHandler(this.teamsListView_SelectedIndexChanged);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.selectAllButton.Location = new System.Drawing.Point(23, 478);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(238, 39);
            this.selectAllButton.TabIndex = 5;
            this.selectAllButton.Text = "Zaznacz wszystkie";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // playersListView
            // 
            this.playersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.lastNameColumnHeader,
            this.emailColumnHeader,
            this.captainColumnHeader});
            this.playersListView.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.playersListView.Location = new System.Drawing.Point(279, 22);
            this.playersListView.MultiSelect = false;
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(615, 445);
            this.playersListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.playersListView.TabIndex = 6;
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
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.Location = new System.Drawing.Point(692, 478);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(202, 39);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // rejectButton
            // 
            this.rejectButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.rejectButton.Location = new System.Drawing.Point(279, 478);
            this.rejectButton.Name = "rejectButton";
            this.rejectButton.Size = new System.Drawing.Size(215, 39);
            this.rejectButton.TabIndex = 8;
            this.rejectButton.Text = "Odrzuć zaznaczone";
            this.rejectButton.UseVisualStyleBackColor = true;
            this.rejectButton.Click += new System.EventHandler(this.rejectButton_Click);
            // 
            // TeamRegistrations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AMTS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(930, 529);
            this.Controls.Add(this.rejectButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.playersListView);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.teamsListView);
            this.Controls.Add(this.acceptButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeamRegistrations";
            this.Text = "Zgłoszenia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeamRegistrations_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.ListView teamsListView;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.ListView playersListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader captainColumnHeader;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button rejectButton;
    }
}