namespace AMTS
{
    partial class Messages
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
            this.sendersListView = new System.Windows.Forms.ListView();
            this.subjectListView = new System.Windows.Forms.ListView();
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subjectColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.nadawca = new System.Windows.Forms.Label();
            this.wiadomość = new System.Windows.Forms.Label();
            this.sendNewMessageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendersListView
            // 
            this.sendersListView.Location = new System.Drawing.Point(22, 31);
            this.sendersListView.MultiSelect = false;
            this.sendersListView.Name = "sendersListView";
            this.sendersListView.Size = new System.Drawing.Size(204, 348);
            this.sendersListView.TabIndex = 0;
            this.sendersListView.UseCompatibleStateImageBehavior = false;
            this.sendersListView.View = System.Windows.Forms.View.SmallIcon;
            this.sendersListView.SelectedIndexChanged += new System.EventHandler(this.sendersListView_SelectedIndexChanged);
            // 
            // subjectListView
            // 
            this.subjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumnHeader,
            this.subjectColumnHeader});
            this.subjectListView.FullRowSelect = true;
            this.subjectListView.Location = new System.Drawing.Point(232, 31);
            this.subjectListView.MultiSelect = false;
            this.subjectListView.Name = "subjectListView";
            this.subjectListView.Size = new System.Drawing.Size(338, 348);
            this.subjectListView.TabIndex = 1;
            this.subjectListView.UseCompatibleStateImageBehavior = false;
            this.subjectListView.View = System.Windows.Forms.View.Details;
            this.subjectListView.SelectedIndexChanged += new System.EventHandler(this.subjectListView_SelectedIndexChanged);
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Data";
            this.dateColumnHeader.Width = 120;
            // 
            // subjectColumnHeader
            // 
            this.subjectColumnHeader.Text = "Temat";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(576, 31);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(504, 348);
            this.messageTextBox.TabIndex = 2;
            // 
            // nadawca
            // 
            this.nadawca.AutoSize = true;
            this.nadawca.Location = new System.Drawing.Point(19, 9);
            this.nadawca.Name = "nadawca";
            this.nadawca.Size = new System.Drawing.Size(66, 17);
            this.nadawca.TabIndex = 3;
            this.nadawca.Text = "Nadawca";
            // 
            // wiadomość
            // 
            this.wiadomość.AutoSize = true;
            this.wiadomość.Location = new System.Drawing.Point(573, 9);
            this.wiadomość.Name = "wiadomość";
            this.wiadomość.Size = new System.Drawing.Size(81, 17);
            this.wiadomość.TabIndex = 5;
            this.wiadomość.Text = "Wiadomość";
            // 
            // sendNewMessageButton
            // 
            this.sendNewMessageButton.Location = new System.Drawing.Point(1086, 31);
            this.sendNewMessageButton.Name = "sendNewMessageButton";
            this.sendNewMessageButton.Size = new System.Drawing.Size(115, 348);
            this.sendNewMessageButton.TabIndex = 6;
            this.sendNewMessageButton.Text = "Wyślij nową wiadomość";
            this.sendNewMessageButton.UseVisualStyleBackColor = true;
            this.sendNewMessageButton.Click += new System.EventHandler(this.sendNewMessageButton_Click);
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1227, 425);
            this.Controls.Add(this.sendNewMessageButton);
            this.Controls.Add(this.wiadomość);
            this.Controls.Add(this.nadawca);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.subjectListView);
            this.Controls.Add(this.sendersListView);
            this.Name = "Messages";
            this.Text = "Messages";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Messages_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView sendersListView;
        private System.Windows.Forms.ListView subjectListView;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label nadawca;
        private System.Windows.Forms.Label wiadomość;
        private System.Windows.Forms.Button sendNewMessageButton;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.ColumnHeader subjectColumnHeader;
    }
}