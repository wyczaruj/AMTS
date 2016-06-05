namespace AMTS
{
    partial class UsunDruzyne
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
            this.ktoraDruzna = new System.Windows.Forms.Label();
            this.spisDruzyn = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usuwanie
            // 
            this.usuwanie.Location = new System.Drawing.Point(206, 21);
            this.usuwanie.Name = "usuwanie";
            this.usuwanie.Size = new System.Drawing.Size(75, 23);
            this.usuwanie.TabIndex = 5;
            this.usuwanie.Text = "Usuń";
            this.usuwanie.UseVisualStyleBackColor = true;
            this.usuwanie.Click += new System.EventHandler(this.usuwanie_Click);
            // 
            // ktoraDruzna
            // 
            this.ktoraDruzna.AutoSize = true;
            this.ktoraDruzna.Location = new System.Drawing.Point(0, 4);
            this.ktoraDruzna.Name = "ktoraDruzna";
            this.ktoraDruzna.Size = new System.Drawing.Size(85, 13);
            this.ktoraDruzna.TabIndex = 4;
            this.ktoraDruzna.Text = "Wybierz drużynę";
            // 
            // spisDruzyn
            // 
            this.spisDruzyn.FormattingEnabled = true;
            this.spisDruzyn.Location = new System.Drawing.Point(3, 21);
            this.spisDruzyn.Name = "spisDruzyn";
            this.spisDruzyn.Size = new System.Drawing.Size(197, 21);
            this.spisDruzyn.TabIndex = 3;
            // 
            // UsunDruzyne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 58);
            this.Controls.Add(this.usuwanie);
            this.Controls.Add(this.ktoraDruzna);
            this.Controls.Add(this.spisDruzyn);
            this.Name = "UsunDruzyne";
            this.Text = "UsunDruzyne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button usuwanie;
        private System.Windows.Forms.Label ktoraDruzna;
        private System.Windows.Forms.ComboBox spisDruzyn;
    }
}