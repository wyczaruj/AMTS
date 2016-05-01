namespace AMTS
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.acceptCheckBox = new System.Windows.Forms.CheckBox();
            this.regulaminLinkLabel = new System.Windows.Forms.LinkLabel();
            this.accLabel = new System.Windows.Forms.Label();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.PESELTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.hasloTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.incorrectLastName = new System.Windows.Forms.Label();
            this.incorrectName = new System.Windows.Forms.Label();
            this.incorrectPESEL = new System.Windows.Forms.Label();
            this.incorrectMail = new System.Windows.Forms.Label();
            this.incorrectPassword = new System.Windows.Forms.Label();
            this.incorrectPhone = new System.Windows.Forms.Label();
            this.MailTaken = new System.Windows.Forms.Label();
            this.nameTaken = new System.Windows.Forms.Label();
            this.PESELTaken = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PESEL*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres e-mail*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasło*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon";
            // 
            // acceptCheckBox
            // 
            this.acceptCheckBox.AutoSize = true;
            this.acceptCheckBox.Location = new System.Drawing.Point(45, 219);
            this.acceptCheckBox.Name = "acceptCheckBox";
            this.acceptCheckBox.Size = new System.Drawing.Size(142, 21);
            this.acceptCheckBox.TabIndex = 6;
            this.acceptCheckBox.Text = "Przeczytałem/-am";
            this.acceptCheckBox.UseVisualStyleBackColor = true;
            this.acceptCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // regulaminLinkLabel
            // 
            this.regulaminLinkLabel.AutoSize = true;
            this.regulaminLinkLabel.Location = new System.Drawing.Point(193, 220);
            this.regulaminLinkLabel.Name = "regulaminLinkLabel";
            this.regulaminLinkLabel.Size = new System.Drawing.Size(89, 17);
            this.regulaminLinkLabel.TabIndex = 7;
            this.regulaminLinkLabel.TabStop = true;
            this.regulaminLinkLabel.Text = "REGULAMIN";
            this.regulaminLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regulaminLinkLabel_LinkClicked);
            // 
            // accLabel
            // 
            this.accLabel.AutoSize = true;
            this.accLabel.Location = new System.Drawing.Point(288, 220);
            this.accLabel.Name = "accLabel";
            this.accLabel.Size = new System.Drawing.Size(100, 17);
            this.accLabel.TabIndex = 8;
            this.accLabel.Text = "i go akceptuję.";
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(140, 35);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(182, 22);
            this.imieTextBox.TabIndex = 9;
            this.imieTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(140, 63);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(182, 22);
            this.nazwiskoTextBox.TabIndex = 10;
            this.nazwiskoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // PESELTextBox
            // 
            this.PESELTextBox.Location = new System.Drawing.Point(140, 91);
            this.PESELTextBox.Name = "PESELTextBox";
            this.PESELTextBox.Size = new System.Drawing.Size(182, 22);
            this.PESELTextBox.TabIndex = 11;
            this.PESELTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(140, 119);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(182, 22);
            this.mailTextBox.TabIndex = 12;
            this.mailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // hasloTextBox
            // 
            this.hasloTextBox.Location = new System.Drawing.Point(140, 147);
            this.hasloTextBox.Name = "hasloTextBox";
            this.hasloTextBox.PasswordChar = '*';
            this.hasloTextBox.Size = new System.Drawing.Size(182, 22);
            this.hasloTextBox.TabIndex = 13;
            this.hasloTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(140, 175);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(182, 22);
            this.telefonTextBox.TabIndex = 14;
            this.telefonTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxes_KeyDown);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(368, 287);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(96, 31);
            this.registerButton.TabIndex = 15;
            this.registerButton.Text = "Rejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(25, 287);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 31);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // incorrectLastName
            // 
            this.incorrectLastName.AutoSize = true;
            this.incorrectLastName.ForeColor = System.Drawing.Color.Red;
            this.incorrectLastName.Location = new System.Drawing.Point(328, 68);
            this.incorrectLastName.Name = "incorrectLastName";
            this.incorrectLastName.Size = new System.Drawing.Size(152, 17);
            this.incorrectLastName.TabIndex = 17;
            this.incorrectLastName.Text = "Niepoprawne nazwisko";
            this.incorrectLastName.Visible = false;
            // 
            // incorrectName
            // 
            this.incorrectName.AutoSize = true;
            this.incorrectName.ForeColor = System.Drawing.Color.Red;
            this.incorrectName.Location = new System.Drawing.Point(328, 40);
            this.incorrectName.Name = "incorrectName";
            this.incorrectName.Size = new System.Drawing.Size(120, 17);
            this.incorrectName.TabIndex = 18;
            this.incorrectName.Text = "Niepoprawne imię";
            this.incorrectName.Visible = false;
            // 
            // incorrectPESEL
            // 
            this.incorrectPESEL.AutoSize = true;
            this.incorrectPESEL.ForeColor = System.Drawing.Color.Red;
            this.incorrectPESEL.Location = new System.Drawing.Point(326, 96);
            this.incorrectPESEL.Name = "incorrectPESEL";
            this.incorrectPESEL.Size = new System.Drawing.Size(138, 17);
            this.incorrectPESEL.TabIndex = 19;
            this.incorrectPESEL.Text = "Niepoprawny PESEL";
            this.incorrectPESEL.Visible = false;
            // 
            // incorrectMail
            // 
            this.incorrectMail.AutoSize = true;
            this.incorrectMail.ForeColor = System.Drawing.Color.Red;
            this.incorrectMail.Location = new System.Drawing.Point(326, 124);
            this.incorrectMail.Name = "incorrectMail";
            this.incorrectMail.Size = new System.Drawing.Size(130, 17);
            this.incorrectMail.TabIndex = 20;
            this.incorrectMail.Text = "Niepoprawny adres";
            this.incorrectMail.Visible = false;
            // 
            // incorrectPassword
            // 
            this.incorrectPassword.AutoSize = true;
            this.incorrectPassword.ForeColor = System.Drawing.Color.Red;
            this.incorrectPassword.Location = new System.Drawing.Point(328, 152);
            this.incorrectPassword.Name = "incorrectPassword";
            this.incorrectPassword.Size = new System.Drawing.Size(129, 17);
            this.incorrectPassword.TabIndex = 21;
            this.incorrectPassword.Text = "Niepoprawne hasło";
            this.incorrectPassword.Visible = false;
            // 
            // incorrectPhone
            // 
            this.incorrectPhone.AutoSize = true;
            this.incorrectPhone.ForeColor = System.Drawing.Color.Red;
            this.incorrectPhone.Location = new System.Drawing.Point(328, 180);
            this.incorrectPhone.Name = "incorrectPhone";
            this.incorrectPhone.Size = new System.Drawing.Size(134, 17);
            this.incorrectPhone.TabIndex = 22;
            this.incorrectPhone.Text = "Niepoprawny numer";
            this.incorrectPhone.Visible = false;
            // 
            // MailTaken
            // 
            this.MailTaken.AutoSize = true;
            this.MailTaken.ForeColor = System.Drawing.Color.Red;
            this.MailTaken.Location = new System.Drawing.Point(328, 124);
            this.MailTaken.Name = "MailTaken";
            this.MailTaken.Size = new System.Drawing.Size(86, 17);
            this.MailTaken.TabIndex = 23;
            this.MailTaken.Text = "Adres zajęty";
            this.MailTaken.Visible = false;
            // 
            // nameTaken
            // 
            this.nameTaken.AutoSize = true;
            this.nameTaken.ForeColor = System.Drawing.Color.Red;
            this.nameTaken.Location = new System.Drawing.Point(45, 247);
            this.nameTaken.Name = "nameTaken";
            this.nameTaken.Size = new System.Drawing.Size(317, 17);
            this.nameTaken.TabIndex = 24;
            this.nameTaken.Text = "Użytkownik o takim imieniu i nazwisku już istnieje.";
            this.nameTaken.Visible = false;
            // 
            // PESELTaken
            // 
            this.PESELTaken.AutoSize = true;
            this.PESELTaken.ForeColor = System.Drawing.Color.Red;
            this.PESELTaken.Location = new System.Drawing.Point(328, 96);
            this.PESELTaken.Name = "PESELTaken";
            this.PESELTaken.Size = new System.Drawing.Size(95, 17);
            this.PESELTaken.TabIndex = 25;
            this.PESELTaken.Text = "Zajęty PESEL";
            this.PESELTaken.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 347);
            this.Controls.Add(this.PESELTaken);
            this.Controls.Add(this.nameTaken);
            this.Controls.Add(this.MailTaken);
            this.Controls.Add(this.incorrectPhone);
            this.Controls.Add(this.incorrectPassword);
            this.Controls.Add(this.incorrectMail);
            this.Controls.Add(this.incorrectPESEL);
            this.Controls.Add(this.incorrectName);
            this.Controls.Add(this.incorrectLastName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.hasloTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.PESELTextBox);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.accLabel);
            this.Controls.Add(this.regulaminLinkLabel);
            this.Controls.Add(this.acceptCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "Rejestracja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox acceptCheckBox;
        private System.Windows.Forms.LinkLabel regulaminLinkLabel;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox PESELTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox hasloTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label incorrectLastName;
        private System.Windows.Forms.Label incorrectName;
        private System.Windows.Forms.Label incorrectPESEL;
        private System.Windows.Forms.Label incorrectMail;
        private System.Windows.Forms.Label incorrectPassword;
        private System.Windows.Forms.Label incorrectPhone;
        private System.Windows.Forms.Label MailTaken;
        private System.Windows.Forms.Label accLabel;
        private System.Windows.Forms.Label nameTaken;
        private System.Windows.Forms.Label PESELTaken;
    }
}