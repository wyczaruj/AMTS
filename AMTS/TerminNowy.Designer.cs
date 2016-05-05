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
            this.comboBoxDruzyna = new System.Windows.Forms.ComboBox();
            this.comboBoxPrzeciwnik = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericRunda = new System.Windows.Forms.NumericUpDown();
            this.numericDuzeDruzyny = new System.Windows.Forms.NumericUpDown();
            this.numericDuzePrzeciwnika = new System.Windows.Forms.NumericUpDown();
            this.numericMaleDruzyny = new System.Windows.Forms.NumericUpDown();
            this.numericMalePrzeciwnika = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericRunda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuzeDruzyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuzePrzeciwnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaleDruzyny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMalePrzeciwnika)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(224, 273);
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
            this.discard.Location = new System.Drawing.Point(7, 273);
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
            this.data.Location = new System.Drawing.Point(128, 9);
            this.data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(38, 17);
            this.data.TabIndex = 2;
            this.data.Text = "Data";
            // 
            // runda
            // 
            this.runda.AutoSize = true;
            this.runda.Location = new System.Drawing.Point(119, 43);
            this.runda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.runda.Name = "runda";
            this.runda.Size = new System.Drawing.Size(50, 17);
            this.runda.TabIndex = 3;
            this.runda.Text = "Runda";
            // 
            // druzyna2
            // 
            this.druzyna2.AutoSize = true;
            this.druzyna2.Location = new System.Drawing.Point(93, 107);
            this.druzyna2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.druzyna2.Name = "druzyna2";
            this.druzyna2.Size = new System.Drawing.Size(74, 17);
            this.druzyna2.TabIndex = 5;
            this.druzyna2.Text = "Przeciwnik";
            // 
            // druzyna1
            // 
            this.druzyna1.AutoSize = true;
            this.druzyna1.Location = new System.Drawing.Point(109, 79);
            this.druzyna1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.druzyna1.Name = "druzyna1";
            this.druzyna1.Size = new System.Drawing.Size(61, 17);
            this.druzyna1.TabIndex = 4;
            this.druzyna1.Text = "Drużyna";
            // 
            // malePunkty1
            // 
            this.malePunkty1.AutoSize = true;
            this.malePunkty1.Location = new System.Drawing.Point(32, 201);
            this.malePunkty1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.malePunkty1.Name = "malePunkty1";
            this.malePunkty1.Size = new System.Drawing.Size(138, 17);
            this.malePunkty1.TabIndex = 9;
            this.malePunkty1.Text = "Male punkty druzyny";
            // 
            // duzePunkty2
            // 
            this.duzePunkty2.AutoSize = true;
            this.duzePunkty2.Location = new System.Drawing.Point(3, 171);
            this.duzePunkty2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.duzePunkty2.Name = "duzePunkty2";
            this.duzePunkty2.Size = new System.Drawing.Size(164, 17);
            this.duzePunkty2.TabIndex = 8;
            this.duzePunkty2.Text = "Duze punkty przecwinika";
            // 
            // malePunkty2
            // 
            this.malePunkty2.AutoSize = true;
            this.malePunkty2.Location = new System.Drawing.Point(5, 233);
            this.malePunkty2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.malePunkty2.Name = "malePunkty2";
            this.malePunkty2.Size = new System.Drawing.Size(161, 17);
            this.malePunkty2.TabIndex = 7;
            this.malePunkty2.Text = "Male punkty przeciwnika";
            // 
            // duzePunkty1
            // 
            this.duzePunkty1.AutoSize = true;
            this.duzePunkty1.Location = new System.Drawing.Point(29, 139);
            this.duzePunkty1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.duzePunkty1.Name = "duzePunkty1";
            this.duzePunkty1.Size = new System.Drawing.Size(141, 17);
            this.duzePunkty1.TabIndex = 6;
            this.duzePunkty1.Text = "Duże punkty drużyny";
            // 
            // comboBoxDruzyna
            // 
            this.comboBoxDruzyna.FormattingEnabled = true;
            this.comboBoxDruzyna.Location = new System.Drawing.Point(179, 72);
            this.comboBoxDruzyna.Name = "comboBoxDruzyna";
            this.comboBoxDruzyna.Size = new System.Drawing.Size(144, 24);
            this.comboBoxDruzyna.TabIndex = 18;
            // 
            // comboBoxPrzeciwnik
            // 
            this.comboBoxPrzeciwnik.FormattingEnabled = true;
            this.comboBoxPrzeciwnik.Location = new System.Drawing.Point(179, 107);
            this.comboBoxPrzeciwnik.Name = "comboBoxPrzeciwnik";
            this.comboBoxPrzeciwnik.Size = new System.Drawing.Size(144, 24);
            this.comboBoxPrzeciwnik.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 11);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 5, 4, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 22);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.Value = new System.DateTime(2016, 5, 4, 0, 0, 0, 0);
            // 
            // numericRunda
            // 
            this.numericRunda.Location = new System.Drawing.Point(179, 43);
            this.numericRunda.Name = "numericRunda";
            this.numericRunda.Size = new System.Drawing.Size(53, 22);
            this.numericRunda.TabIndex = 21;
            this.numericRunda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericDuzeDruzyny
            // 
            this.numericDuzeDruzyny.Location = new System.Drawing.Point(179, 139);
            this.numericDuzeDruzyny.Name = "numericDuzeDruzyny";
            this.numericDuzeDruzyny.Size = new System.Drawing.Size(53, 22);
            this.numericDuzeDruzyny.TabIndex = 22;
            // 
            // numericDuzePrzeciwnika
            // 
            this.numericDuzePrzeciwnika.Location = new System.Drawing.Point(179, 171);
            this.numericDuzePrzeciwnika.Name = "numericDuzePrzeciwnika";
            this.numericDuzePrzeciwnika.Size = new System.Drawing.Size(53, 22);
            this.numericDuzePrzeciwnika.TabIndex = 23;
            // 
            // numericMaleDruzyny
            // 
            this.numericMaleDruzyny.Location = new System.Drawing.Point(179, 205);
            this.numericMaleDruzyny.Name = "numericMaleDruzyny";
            this.numericMaleDruzyny.Size = new System.Drawing.Size(53, 22);
            this.numericMaleDruzyny.TabIndex = 24;
            // 
            // numericMalePrzeciwnika
            // 
            this.numericMalePrzeciwnika.Location = new System.Drawing.Point(179, 233);
            this.numericMalePrzeciwnika.Name = "numericMalePrzeciwnika";
            this.numericMalePrzeciwnika.Size = new System.Drawing.Size(53, 22);
            this.numericMalePrzeciwnika.TabIndex = 25;
            // 
            // TerminNowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 313);
            this.Controls.Add(this.numericMalePrzeciwnika);
            this.Controls.Add(this.numericMaleDruzyny);
            this.Controls.Add(this.numericDuzePrzeciwnika);
            this.Controls.Add(this.numericDuzeDruzyny);
            this.Controls.Add(this.numericRunda);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxPrzeciwnik);
            this.Controls.Add(this.comboBoxDruzyna);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TerminNowy";
            this.Text = "TerminNowy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TerminNowy_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericRunda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuzeDruzyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuzePrzeciwnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaleDruzyny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMalePrzeciwnika)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBoxDruzyna;
        private System.Windows.Forms.ComboBox comboBoxPrzeciwnik;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericRunda;
        private System.Windows.Forms.NumericUpDown numericDuzeDruzyny;
        private System.Windows.Forms.NumericUpDown numericDuzePrzeciwnika;
        private System.Windows.Forms.NumericUpDown numericMaleDruzyny;
        private System.Windows.Forms.NumericUpDown numericMalePrzeciwnika;
    }
}