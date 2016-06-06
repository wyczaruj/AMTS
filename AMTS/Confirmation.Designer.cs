namespace AMTS
{
    partial class Confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.teamsListView = new System.Windows.Forms.ListView();
            this.playersListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.captainColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.confirmationColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamsListView
            // 
            this.teamsListView.Font = new System.Drawing.Font("Calibri", 15.2F);
            this.teamsListView.Location = new System.Drawing.Point(12, 21);
            this.teamsListView.MultiSelect = false;
            this.teamsListView.Name = "teamsListView";
            this.teamsListView.Size = new System.Drawing.Size(238, 454);
            this.teamsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.teamsListView.TabIndex = 11;
            this.teamsListView.UseCompatibleStateImageBehavior = false;
            this.teamsListView.View = System.Windows.Forms.View.SmallIcon;
            this.teamsListView.SelectedIndexChanged += new System.EventHandler(this.teamsListView_SelectedIndexChanged);
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
            this.playersListView.Location = new System.Drawing.Point(256, 21);
            this.playersListView.MultiSelect = false;
            this.playersListView.Name = "playersListView";
            this.playersListView.Size = new System.Drawing.Size(664, 393);
            this.playersListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.playersListView.TabIndex = 10;
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
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 16.2F);
            this.confirmButton.Location = new System.Drawing.Point(256, 420);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(664, 55);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Potwierdź swój udział w drużynie ";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AMTS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 494);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.teamsListView);
            this.Controls.Add(this.playersListView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Confirmation";
            this.Text = "Potwierdzenie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Confirmation_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView teamsListView;
        private System.Windows.Forms.ListView playersListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader lastNameColumnHeader;
        private System.Windows.Forms.ColumnHeader emailColumnHeader;
        private System.Windows.Forms.ColumnHeader captainColumnHeader;
        private System.Windows.Forms.ColumnHeader confirmationColumnHeader;
        private System.Windows.Forms.Button confirmButton;
    }
}