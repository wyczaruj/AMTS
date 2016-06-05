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
            this.usuwanie.Location = new System.Drawing.Point(275, 26);
            this.usuwanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuwanie.Name = "usuwanie";
            this.usuwanie.Size = new System.Drawing.Size(100, 28);
            this.usuwanie.TabIndex = 5;
            this.usuwanie.Text = "Usuń";
            this.usuwanie.UseVisualStyleBackColor = true;
            this.usuwanie.Click += new System.EventHandler(this.usuwanie_Click);
            // 
            // ktoraDruzna
            // 
            this.ktoraDruzna.AutoSize = true;
            this.ktoraDruzna.Location = new System.Drawing.Point(0, 5);
            this.ktoraDruzna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ktoraDruzna.Name = "ktoraDruzna";
            this.ktoraDruzna.Size = new System.Drawing.Size(114, 17);
            this.ktoraDruzna.TabIndex = 4;
            this.ktoraDruzna.Text = "Wybierz drużynę";
            // 
            // spisDruzyn
            // 
            this.spisDruzyn.FormattingEnabled = true;
            this.spisDruzyn.Location = new System.Drawing.Point(4, 26);
            this.spisDruzyn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spisDruzyn.Name = "spisDruzyn";
            this.spisDruzyn.Size = new System.Drawing.Size(261, 24);
            this.spisDruzyn.TabIndex = 3;
            // 
            // UsunDruzyne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.usuwanie);
            this.Controls.Add(this.ktoraDruzna);
            this.Controls.Add(this.spisDruzyn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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