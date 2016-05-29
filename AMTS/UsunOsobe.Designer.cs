namespace AMTS
{
    partial class UsunOsobe
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
            this.usuwanie = new System.Windows.Forms.Button();
            this.ktoraOsoba = new System.Windows.Forms.Label();
            this.spisOsob = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usuwanie
            // 
            this.usuwanie.Location = new System.Drawing.Point(209, 26);
            this.usuwanie.Name = "usuwanie";
            this.usuwanie.Size = new System.Drawing.Size(75, 23);
            this.usuwanie.TabIndex = 2;
            this.usuwanie.Text = "Usuń";
            this.usuwanie.UseVisualStyleBackColor = true;
            this.usuwanie.Click += new System.EventHandler(this.usuwanie_Click);
            // 
            // ktoraOsoba
            // 
            this.ktoraOsoba.AutoSize = true;
            this.ktoraOsoba.Location = new System.Drawing.Point(3, 9);
            this.ktoraOsoba.Name = "ktoraOsoba";
            this.ktoraOsoba.Size = new System.Drawing.Size(110, 13);
            this.ktoraOsoba.TabIndex = 1;
            this.ktoraOsoba.Text = "Wybierz użytkownika:";
            // 
            // spisOsob
            // 
            this.spisOsob.FormattingEnabled = true;
            this.spisOsob.Location = new System.Drawing.Point(6, 26);
            this.spisOsob.Name = "spisOsob";
            this.spisOsob.Size = new System.Drawing.Size(197, 21);
            this.spisOsob.TabIndex = 0;
            // 
            // UsunOsobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.usuwanie);
            this.Controls.Add(this.ktoraOsoba);
            this.Controls.Add(this.spisOsob);
            this.Name = "UsunOsobe";
            this.Text = "Usuń użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox spisOsob;
        private System.Windows.Forms.Label ktoraOsoba;
        private System.Windows.Forms.Button usuwanie;
    }
}