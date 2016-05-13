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
            this.comboBoxDruzyna = new System.Windows.Forms.ComboBox();
            this.comboBoxPrzeciwnik = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericRunda = new System.Windows.Forms.NumericUpDown();
            this.NoDruzyna = new System.Windows.Forms.Label();
            this.DwieTakieSameDruzyny = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericRunda)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(193, 124);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 28);
            this.save.TabIndex = 0;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // discard
            // 
            this.discard.Location = new System.Drawing.Point(41, 124);
            this.discard.Margin = new System.Windows.Forms.Padding(4);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(100, 28);
            this.discard.TabIndex = 1;
            this.discard.Text = "Anuluj";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(49, 12);
            this.data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(38, 17);
            this.data.TabIndex = 2;
            this.data.Text = "Data";
            // 
            // runda
            // 
            this.runda.AutoSize = true;
            this.runda.Location = new System.Drawing.Point(37, 37);
            this.runda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.runda.Name = "runda";
            this.runda.Size = new System.Drawing.Size(50, 17);
            this.runda.TabIndex = 3;
            this.runda.Text = "Runda";
            // 
            // druzyna2
            // 
            this.druzyna2.AutoSize = true;
            this.druzyna2.Location = new System.Drawing.Point(13, 96);
            this.druzyna2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.druzyna2.Name = "druzyna2";
            this.druzyna2.Size = new System.Drawing.Size(74, 17);
            this.druzyna2.TabIndex = 5;
            this.druzyna2.Text = "Przeciwnik";
            // 
            // druzyna1
            // 
            this.druzyna1.AutoSize = true;
            this.druzyna1.Location = new System.Drawing.Point(26, 65);
            this.druzyna1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.druzyna1.Name = "druzyna1";
            this.druzyna1.Size = new System.Drawing.Size(61, 17);
            this.druzyna1.TabIndex = 4;
            this.druzyna1.Text = "Drużyna";
            // 
            // comboBoxDruzyna
            // 
            this.comboBoxDruzyna.FormattingEnabled = true;
            this.comboBoxDruzyna.Location = new System.Drawing.Point(88, 63);
            this.comboBoxDruzyna.Name = "comboBoxDruzyna";
            this.comboBoxDruzyna.Size = new System.Drawing.Size(144, 24);
            this.comboBoxDruzyna.TabIndex = 18;
            // 
            // comboBoxPrzeciwnik
            // 
            this.comboBoxPrzeciwnik.FormattingEnabled = true;
            this.comboBoxPrzeciwnik.Location = new System.Drawing.Point(88, 93);
            this.comboBoxPrzeciwnik.Name = "comboBoxPrzeciwnik";
            this.comboBoxPrzeciwnik.Size = new System.Drawing.Size(144, 24);
            this.comboBoxPrzeciwnik.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 7);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 5, 4, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 22);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.Value = new System.DateTime(2016, 5, 4, 0, 0, 0, 0);
            // 
            // numericRunda
            // 
            this.numericRunda.Location = new System.Drawing.Point(88, 35);
            this.numericRunda.Name = "numericRunda";
            this.numericRunda.Size = new System.Drawing.Size(53, 22);
            this.numericRunda.TabIndex = 21;
            this.numericRunda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NoDruzyna
            // 
            this.NoDruzyna.AutoSize = true;
            this.NoDruzyna.ForeColor = System.Drawing.Color.Red;
            this.NoDruzyna.Location = new System.Drawing.Point(238, 66);
            this.NoDruzyna.Name = "NoDruzyna";
            this.NoDruzyna.Size = new System.Drawing.Size(136, 17);
            this.NoDruzyna.TabIndex = 26;
            this.NoDruzyna.Text = "Niewybrano drużyny";
            // 
            // DwieTakieSameDruzyny
            // 
            this.DwieTakieSameDruzyny.AutoSize = true;
            this.DwieTakieSameDruzyny.ForeColor = System.Drawing.Color.Red;
            this.DwieTakieSameDruzyny.Location = new System.Drawing.Point(238, 96);
            this.DwieTakieSameDruzyny.Name = "DwieTakieSameDruzyny";
            this.DwieTakieSameDruzyny.Size = new System.Drawing.Size(145, 17);
            this.DwieTakieSameDruzyny.TabIndex = 27;
            this.DwieTakieSameDruzyny.Text = "Wybierz inną drużynę";
            // 
            // TerminNowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 172);
            this.Controls.Add(this.DwieTakieSameDruzyny);
            this.Controls.Add(this.NoDruzyna);
            this.Controls.Add(this.numericRunda);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxPrzeciwnik);
            this.Controls.Add(this.comboBoxDruzyna);
            this.Controls.Add(this.druzyna2);
            this.Controls.Add(this.druzyna1);
            this.Controls.Add(this.runda);
            this.Controls.Add(this.data);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.save);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TerminNowy";
            this.Text = "TerminNowy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TerminNowy_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericRunda)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxDruzyna;
        private System.Windows.Forms.ComboBox comboBoxPrzeciwnik;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericRunda;
        private System.Windows.Forms.Label NoDruzyna;
        private System.Windows.Forms.Label DwieTakieSameDruzyny;
    }
}