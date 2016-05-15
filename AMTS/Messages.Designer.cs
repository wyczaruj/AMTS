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
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.subjectListView.Location = new System.Drawing.Point(232, 31);
            this.subjectListView.MultiSelect = false;
            this.subjectListView.Name = "subjectListView";
            this.subjectListView.Size = new System.Drawing.Size(199, 348);
            this.subjectListView.TabIndex = 1;
            this.subjectListView.UseCompatibleStateImageBehavior = false;
            this.subjectListView.View = System.Windows.Forms.View.SmallIcon;
            this.subjectListView.SelectedIndexChanged += new System.EventHandler(this.subjectListView_SelectedIndexChanged);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(437, 31);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(643, 348);
            this.messageTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nadawca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wiadomość";
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
            this.ClientSize = new System.Drawing.Size(1227, 425);
            this.Controls.Add(this.sendNewMessageButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendNewMessageButton;
    }
}