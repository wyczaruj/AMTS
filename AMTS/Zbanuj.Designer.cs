namespace AMTS
{
    partial class Zbanuj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zbanuj));
            this.banowanie = new System.Windows.Forms.Button();
            this.ktoraOsoba = new System.Windows.Forms.Label();
            this.spisOsob = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // banowanie
            // 
            this.banowanie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.banowanie.Location = new System.Drawing.Point(277, 32);
            this.banowanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.banowanie.Name = "banowanie";
            this.banowanie.Size = new System.Drawing.Size(100, 28);
            this.banowanie.TabIndex = 5;
            this.banowanie.Text = "Zablokuj";
            this.banowanie.UseVisualStyleBackColor = true;
            this.banowanie.Click += new System.EventHandler(this.banowanie_Click);
            // 
            // ktoraOsoba
            // 
            this.ktoraOsoba.AutoSize = true;
            this.ktoraOsoba.BackColor = System.Drawing.Color.Transparent;
            this.ktoraOsoba.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ktoraOsoba.Location = new System.Drawing.Point(3, 11);
            this.ktoraOsoba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ktoraOsoba.Name = "ktoraOsoba";
            this.ktoraOsoba.Size = new System.Drawing.Size(145, 18);
            this.ktoraOsoba.TabIndex = 4;
            this.ktoraOsoba.Text = "Wybierz użytkownika:";
            // 
            // spisOsob
            // 
            this.spisOsob.Font = new System.Drawing.Font("Calibri", 9F);
            this.spisOsob.FormattingEnabled = true;
            this.spisOsob.Location = new System.Drawing.Point(7, 32);
            this.spisOsob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spisOsob.Name = "spisOsob";
            this.spisOsob.Size = new System.Drawing.Size(261, 26);
            this.spisOsob.TabIndex = 3;
            // 
            // Zbanuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::AMTS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 80);
            this.Controls.Add(this.banowanie);
            this.Controls.Add(this.ktoraOsoba);
            this.Controls.Add(this.spisOsob);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Zbanuj";
            this.Text = "Zbanuj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button banowanie;
        private System.Windows.Forms.Label ktoraOsoba;
        private System.Windows.Forms.ComboBox spisOsob;
    }
}