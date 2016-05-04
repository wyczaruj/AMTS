namespace AMTS
{
    partial class TerminNowy
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
            this.save = new System.Windows.Forms.Button();
            this.discard = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Label();
            this.runda = new System.Windows.Forms.Label();
            this.druzyna2 = new System.Windows.Forms.Label();
            this.druzyna1 = new System.Windows.Forms.Label();
            this.malePunkty1 = new System.Windows.Forms.Label();
            this.duzePunkty2 = new System.Windows.Forms.Label();
            this.malePunkty2 = new System.Windows.Forms.Label();
            this.duzePunkty1 = new System.Windows.Forms.Label();
            this.duzePunkty2Box = new System.Windows.Forms.TextBox();
            this.malePunkty1Box = new System.Windows.Forms.TextBox();
            this.rundaBox = new System.Windows.Forms.TextBox();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.druzyna2Box = new System.Windows.Forms.TextBox();
            this.druzyna1Box = new System.Windows.Forms.TextBox();
            this.malePunkty2Box = new System.Windows.Forms.TextBox();
            this.duzePunkty1Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(168, 222);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 0;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // discard
            // 
            this.discard.Location = new System.Drawing.Point(5, 222);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(75, 23);
            this.discard.TabIndex = 1;
            this.discard.Text = "Anuluj";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(43, 9);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(85, 13);
            this.data.TabIndex = 2;
            this.data.Text = "Data [rrrr-mm-dd]";
            // 
            // runda
            // 
            this.runda.AutoSize = true;
            this.runda.Location = new System.Drawing.Point(89, 35);
            this.runda.Name = "runda";
            this.runda.Size = new System.Drawing.Size(39, 13);
            this.runda.TabIndex = 3;
            this.runda.Text = "Runda";
            // 
            // druzyna2
            // 
            this.druzyna2.AutoSize = true;
            this.druzyna2.Location = new System.Drawing.Point(70, 87);
            this.druzyna2.Name = "druzyna2";
            this.druzyna2.Size = new System.Drawing.Size(58, 13);
            this.druzyna2.TabIndex = 5;
            this.druzyna2.Text = "Przeciwnik";
            // 
            // druzyna1
            // 
            this.druzyna1.AutoSize = true;
            this.druzyna1.Location = new System.Drawing.Point(82, 64);
            this.druzyna1.Name = "druzyna1";
            this.druzyna1.Size = new System.Drawing.Size(46, 13);
            this.druzyna1.TabIndex = 4;
            this.druzyna1.Text = "Drużyna";
            // 
            // malePunkty1
            // 
            this.malePunkty1.AutoSize = true;
            this.malePunkty1.Location = new System.Drawing.Point(24, 163);
            this.malePunkty1.Name = "malePunkty1";
            this.malePunkty1.Size = new System.Drawing.Size(104, 13);
            this.malePunkty1.TabIndex = 9;
            this.malePunkty1.Text = "Male punkty druzyny";
            // 
            // duzePunkty2
            // 
            this.duzePunkty2.AutoSize = true;
            this.duzePunkty2.Location = new System.Drawing.Point(2, 139);
            this.duzePunkty2.Name = "duzePunkty2";
            this.duzePunkty2.Size = new System.Drawing.Size(126, 13);
            this.duzePunkty2.TabIndex = 8;
            this.duzePunkty2.Text = "Duze punkty przecwinika";
            // 
            // malePunkty2
            // 
            this.malePunkty2.AutoSize = true;
            this.malePunkty2.Location = new System.Drawing.Point(4, 189);
            this.malePunkty2.Name = "malePunkty2";
            this.malePunkty2.Size = new System.Drawing.Size(124, 13);
            this.malePunkty2.TabIndex = 7;
            this.malePunkty2.Text = "Male punkty przeciwnika";
            // 
            // duzePunkty1
            // 
            this.duzePunkty1.AutoSize = true;
            this.duzePunkty1.Location = new System.Drawing.Point(22, 113);
            this.duzePunkty1.Name = "duzePunkty1";
            this.duzePunkty1.Size = new System.Drawing.Size(106, 13);
            this.duzePunkty1.TabIndex = 6;
            this.duzePunkty1.Text = "Duże punkty drużyny";
            // 
            // duzePunkty2Box
            // 
            this.duzePunkty2Box.Location = new System.Drawing.Point(134, 136);
            this.duzePunkty2Box.Name = "duzePunkty2Box";
            this.duzePunkty2Box.Size = new System.Drawing.Size(24, 20);
            this.duzePunkty2Box.TabIndex = 10;
            // 
            // malePunkty1Box
            // 
            this.malePunkty1Box.Location = new System.Drawing.Point(134, 160);
            this.malePunkty1Box.Name = "malePunkty1Box";
            this.malePunkty1Box.Size = new System.Drawing.Size(24, 20);
            this.malePunkty1Box.TabIndex = 11;
            // 
            // rundaBox
            // 
            this.rundaBox.Location = new System.Drawing.Point(134, 32);
            this.rundaBox.Name = "rundaBox";
            this.rundaBox.Size = new System.Drawing.Size(24, 20);
            this.rundaBox.TabIndex = 13;
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(134, 6);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(84, 20);
            this.dataBox.TabIndex = 12;
            // 
            // druzyna2Box
            // 
            this.druzyna2Box.Location = new System.Drawing.Point(134, 84);
            this.druzyna2Box.Name = "druzyna2Box";
            this.druzyna2Box.Size = new System.Drawing.Size(109, 20);
            this.druzyna2Box.TabIndex = 17;
            // 
            // druzyna1Box
            // 
            this.druzyna1Box.Location = new System.Drawing.Point(134, 61);
            this.druzyna1Box.Name = "druzyna1Box";
            this.druzyna1Box.Size = new System.Drawing.Size(109, 20);
            this.druzyna1Box.TabIndex = 16;
            // 
            // malePunkty2Box
            // 
            this.malePunkty2Box.Location = new System.Drawing.Point(134, 186);
            this.malePunkty2Box.Name = "malePunkty2Box";
            this.malePunkty2Box.Size = new System.Drawing.Size(24, 20);
            this.malePunkty2Box.TabIndex = 15;
            // 
            // duzePunkty1Box
            // 
            this.duzePunkty1Box.Location = new System.Drawing.Point(134, 110);
            this.duzePunkty1Box.Name = "duzePunkty1Box";
            this.duzePunkty1Box.Size = new System.Drawing.Size(24, 20);
            this.duzePunkty1Box.TabIndex = 14;
            // 
            // TerminNowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 254);
            this.Controls.Add(this.druzyna2Box);
            this.Controls.Add(this.druzyna1Box);
            this.Controls.Add(this.malePunkty2Box);
            this.Controls.Add(this.duzePunkty1Box);
            this.Controls.Add(this.rundaBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.malePunkty1Box);
            this.Controls.Add(this.duzePunkty2Box);
            this.Controls.Add(this.malePunkty1);
            this.Controls.Add(this.duzePunkty2);
            this.Controls.Add(this.malePunkty2);
            this.Controls.Add(this.duzePunkty1);
            this.Controls.Add(this.druzyna2);
            this.Controls.Add(this.druzyna1);
            this.Controls.Add(this.runda);
            this.Controls.Add(this.data);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.save);
            this.Name = "TerminNowy";
            this.Text = "TerminNowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button discard;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label runda;
        private System.Windows.Forms.Label druzyna2;
        private System.Windows.Forms.Label druzyna1;
        private System.Windows.Forms.Label malePunkty1;
        private System.Windows.Forms.Label duzePunkty2;
        private System.Windows.Forms.Label malePunkty2;
        private System.Windows.Forms.Label duzePunkty1;
        private System.Windows.Forms.TextBox duzePunkty2Box;
        private System.Windows.Forms.TextBox malePunkty1Box;
        private System.Windows.Forms.TextBox rundaBox;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.TextBox druzyna2Box;
        private System.Windows.Forms.TextBox druzyna1Box;
        private System.Windows.Forms.TextBox malePunkty2Box;
        private System.Windows.Forms.TextBox duzePunkty1Box;

    }
}