namespace AMTS
{
    partial class Regulamin
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
            this.Zamknij = new System.Windows.Forms.Button();
            this.tresc = new System.Windows.Forms.RichTextBox();
            this.wczytaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(441, 359);
            this.Zamknij.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(77, 26);
            this.Zamknij.TabIndex = 2;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // tresc
            // 
            this.tresc.Location = new System.Drawing.Point(3, 3);
            this.tresc.Name = "tresc";
            this.tresc.Size = new System.Drawing.Size(515, 342);
            this.tresc.TabIndex = 3;
            this.tresc.Text = "";
            // 
            // wczytaj
            // 
            this.wczytaj.Location = new System.Drawing.Point(3, 362);
            this.wczytaj.Name = "wczytaj";
            this.wczytaj.Size = new System.Drawing.Size(75, 23);
            this.wczytaj.TabIndex = 4;
            this.wczytaj.Text = "Wczytaj plik";
            this.wczytaj.UseVisualStyleBackColor = true;
            // 
            // Regulamin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 396);
            this.Controls.Add(this.wczytaj);
            this.Controls.Add(this.tresc);
            this.Controls.Add(this.Zamknij);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Regulamin";
            this.Text = "Regulamin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regulamin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.RichTextBox tresc;
        private System.Windows.Forms.Button wczytaj;
    }
}