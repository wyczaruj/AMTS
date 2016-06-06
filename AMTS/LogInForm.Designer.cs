namespace AMTS
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.email = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.haslo = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.email.Location = new System.Drawing.Point(12, 37);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(87, 18);
            this.email.TabIndex = 0;
            this.email.Text = "Adres e-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(96, 37);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(163, 22);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTextBox_KeyDown);
            // 
            // haslo
            // 
            this.haslo.AutoSize = true;
            this.haslo.BackColor = System.Drawing.Color.Transparent;
            this.haslo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.haslo.Location = new System.Drawing.Point(13, 65);
            this.haslo.Name = "haslo";
            this.haslo.Size = new System.Drawing.Size(42, 18);
            this.haslo.TabIndex = 2;
            this.haslo.Text = "Hasło";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(96, 62);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(163, 22);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.BackColor = System.Drawing.Color.Transparent;
            this.incorrectLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.incorrectLabel.ForeColor = System.Drawing.Color.Tomato;
            this.incorrectLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.incorrectLabel.Location = new System.Drawing.Point(12, 9);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(348, 18);
            this.incorrectLabel.TabIndex = 4;
            this.incorrectLabel.Text = "Sprawdź wprowadzone informacje i spróbuj ponownie.";
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logInButton.Location = new System.Drawing.Point(279, 137);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 35);
            this.logInButton.TabIndex = 5;
            this.logInButton.Text = "Zaloguj";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Location = new System.Drawing.Point(15, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 31);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AMTS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.email);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInForm";
            this.Text = "Zaloguj się";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogInForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label haslo;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button cancelButton;
    }
}