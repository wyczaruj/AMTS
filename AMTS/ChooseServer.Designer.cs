namespace AMTS
{
    partial class ChooseServer
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
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.startPWButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverComboBox
            // 
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Items.AddRange(new object[] {
            "KLAUDIA_PC",
            "KLAUDIA_LAPTOP",
            "PATRYK",
            "PATRYKS",
            "DOROTA",
            "ALTS"});
            this.serverComboBox.Location = new System.Drawing.Point(77, 39);
            this.serverComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.Size = new System.Drawing.Size(341, 24);
            this.serverComboBox.TabIndex = 0;
            this.serverComboBox.SelectedIndexChanged += new System.EventHandler(this.serverComboBox_SelectedIndexChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(186, 156);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(132, 50);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Visible = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "HAS£O:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(139, 112);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '$';
            this.passwordTextBox.Size = new System.Drawing.Size(212, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // startPWButton
            // 
            this.startPWButton.Location = new System.Drawing.Point(186, 156);
            this.startPWButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startPWButton.Name = "startPWButton";
            this.startPWButton.Size = new System.Drawing.Size(132, 50);
            this.startPWButton.TabIndex = 4;
            this.startPWButton.Text = "START";
            this.startPWButton.UseVisualStyleBackColor = true;
            this.startPWButton.Click += new System.EventHandler(this.startPWButton_Click);
            // 
            // ChooseServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 283);
            this.Controls.Add(this.startPWButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.serverComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChooseServer";
            this.Text = "ChooseServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serverComboBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button startPWButton;
    }
}
