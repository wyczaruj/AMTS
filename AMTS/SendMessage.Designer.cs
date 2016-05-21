namespace AMTS
{
    partial class SendMessage
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
            this.usersListView = new System.Windows.Forms.ListView();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.TematLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.teamMessageCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usersListView
            // 
            this.usersListView.Location = new System.Drawing.Point(12, 28);
            this.usersListView.MultiSelect = false;
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(222, 284);
            this.usersListView.TabIndex = 0;
            this.usersListView.UseCompatibleStateImageBehavior = false;
            this.usersListView.View = System.Windows.Forms.View.SmallIcon;
            this.usersListView.SelectedIndexChanged += new System.EventHandler(this.usersListView_SelectedIndexChanged);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(241, 76);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(404, 236);
            this.messageTextBox.TabIndex = 11;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Enabled = false;
            this.subjectTextBox.Location = new System.Drawing.Point(241, 28);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(404, 22);
            this.subjectTextBox.TabIndex = 10;
            // 
            // TematLabel
            // 
            this.TematLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TematLabel.AutoSize = true;
            this.TematLabel.Location = new System.Drawing.Point(238, 9);
            this.TematLabel.Name = "TematLabel";
            this.TematLabel.Size = new System.Drawing.Size(48, 17);
            this.TematLabel.TabIndex = 3;
            this.TematLabel.Text = "Temat";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wiadomość";
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendMessageButton.Enabled = false;
            this.sendMessageButton.Location = new System.Drawing.Point(241, 318);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(404, 42);
            this.sendMessageButton.TabIndex = 12;
            this.sendMessageButton.Text = "Wyślij";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(13, 319);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(221, 41);
            this.selectAllButton.TabIndex = 13;
            this.selectAllButton.Text = "Zaznacz wszystkich";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Visible = false;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // teamMessageCheckBox
            // 
            this.teamMessageCheckBox.AutoSize = true;
            this.teamMessageCheckBox.Location = new System.Drawing.Point(13, 330);
            this.teamMessageCheckBox.Name = "teamMessageCheckBox";
            this.teamMessageCheckBox.Size = new System.Drawing.Size(211, 21);
            this.teamMessageCheckBox.TabIndex = 14;
            this.teamMessageCheckBox.Text = "Wyślij wiadomość drużynową";
            this.teamMessageCheckBox.UseVisualStyleBackColor = true;
            this.teamMessageCheckBox.Visible = false;
            this.teamMessageCheckBox.CheckedChanged += new System.EventHandler(this.teamMessageCheckBox_CheckedChanged);
            // 
            // SendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 383);
            this.Controls.Add(this.teamMessageCheckBox);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TematLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.usersListView);
            this.Name = "SendMessage";
            this.Text = "SendMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SendMessage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView usersListView;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label TematLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.CheckBox teamMessageCheckBox;
    }
}