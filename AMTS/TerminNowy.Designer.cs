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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminNowy));
            this.DwieTakieSameDruzyny = new System.Windows.Forms.Label();
            this.NoDruzyna = new System.Windows.Forms.Label();
            this.numericRunda = new System.Windows.Forms.NumericUpDown();
            this.wybórDaty = new System.Windows.Forms.DateTimePicker();
            this.Przeciwnik = new System.Windows.Forms.ComboBox();
            this.Druzyna = new System.Windows.Forms.ComboBox();
            this.druzyna2 = new System.Windows.Forms.Label();
            this.druzyna1 = new System.Windows.Forms.Label();
            this.runda = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.discard = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericRunda)).BeginInit();
            this.SuspendLayout();
            // 
            // DwieTakieSameDruzyny
            // 
            this.DwieTakieSameDruzyny.AutoSize = true;
            this.DwieTakieSameDruzyny.BackColor = System.Drawing.Color.Transparent;
            this.DwieTakieSameDruzyny.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.DwieTakieSameDruzyny.ForeColor = System.Drawing.Color.Tomato;
            this.DwieTakieSameDruzyny.Location = new System.Drawing.Point(315, 113);
            this.DwieTakieSameDruzyny.Name = "DwieTakieSameDruzyny";
            this.DwieTakieSameDruzyny.Size = new System.Drawing.Size(143, 18);
            this.DwieTakieSameDruzyny.TabIndex = 27;
            this.DwieTakieSameDruzyny.Text = "Wybierz inną drużynę";
            // 
            // NoDruzyna
            // 
            this.NoDruzyna.AutoSize = true;
            this.NoDruzyna.BackColor = System.Drawing.Color.Transparent;
            this.NoDruzyna.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.NoDruzyna.ForeColor = System.Drawing.Color.Tomato;
            this.NoDruzyna.Location = new System.Drawing.Point(315, 81);
            this.NoDruzyna.Name = "NoDruzyna";
            this.NoDruzyna.Size = new System.Drawing.Size(136, 18);
            this.NoDruzyna.TabIndex = 26;
            this.NoDruzyna.Text = "Niewybrano drużyny";
            // 
            // numericRunda
            // 
            this.numericRunda.Location = new System.Drawing.Point(117, 48);
            this.numericRunda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericRunda.Name = "numericRunda";
            this.numericRunda.Size = new System.Drawing.Size(53, 22);
            this.numericRunda.TabIndex = 21;
            this.numericRunda.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // wybórDaty
            // 
            this.wybórDaty.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.wybórDaty.Location = new System.Drawing.Point(117, 22);
            this.wybórDaty.Margin = new System.Windows.Forms.Padding(4);
            this.wybórDaty.MaxDate = new System.DateTime(2100, 5, 4, 0, 0, 0, 0);
            this.wybórDaty.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.wybórDaty.Name = "wybórDaty";
            this.wybórDaty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wybórDaty.Size = new System.Drawing.Size(191, 22);
            this.wybórDaty.TabIndex = 20;
            this.wybórDaty.Value = new System.DateTime(2016, 5, 4, 0, 0, 0, 0);
            // 
            // Przeciwnik
            // 
            this.Przeciwnik.FormattingEnabled = true;
            this.Przeciwnik.Location = new System.Drawing.Point(117, 106);
            this.Przeciwnik.Margin = new System.Windows.Forms.Padding(4);
            this.Przeciwnik.Name = "Przeciwnik";
            this.Przeciwnik.Size = new System.Drawing.Size(191, 24);
            this.Przeciwnik.TabIndex = 19;
            // 
            // Druzyna
            // 
            this.Druzyna.FormattingEnabled = true;
            this.Druzyna.Location = new System.Drawing.Point(117, 74);
            this.Druzyna.Margin = new System.Windows.Forms.Padding(4);
            this.Druzyna.Name = "Druzyna";
            this.Druzyna.Size = new System.Drawing.Size(191, 24);
            this.Druzyna.TabIndex = 18;
            // 
            // druzyna2
            // 
            this.druzyna2.AutoSize = true;
            this.druzyna2.BackColor = System.Drawing.Color.Transparent;
            this.druzyna2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.druzyna2.Location = new System.Drawing.Point(34, 108);
            this.druzyna2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.druzyna2.Name = "druzyna2";
            this.druzyna2.Size = new System.Drawing.Size(75, 18);
            this.druzyna2.TabIndex = 5;
            this.druzyna2.Text = "Przeciwnik";
            // 
            // druzyna1
            // 
            this.druzyna1.AutoSize = true;
            this.druzyna1.BackColor = System.Drawing.Color.Transparent;
            this.druzyna1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.druzyna1.Location = new System.Drawing.Point(48, 76);
            this.druzyna1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.druzyna1.Name = "druzyna1";
            this.druzyna1.Size = new System.Drawing.Size(58, 18);
            this.druzyna1.TabIndex = 4;
            this.druzyna1.Text = "Drużyna";
            // 
            // runda
            // 
            this.runda.AutoSize = true;
            this.runda.BackColor = System.Drawing.Color.Transparent;
            this.runda.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.runda.Location = new System.Drawing.Point(58, 49);
            this.runda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.runda.Name = "runda";
            this.runda.Size = new System.Drawing.Size(47, 18);
            this.runda.TabIndex = 3;
            this.runda.Text = "Runda";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.BackColor = System.Drawing.Color.Transparent;
            this.data.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.data.Location = new System.Drawing.Point(70, 24);
            this.data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(36, 18);
            this.data.TabIndex = 2;
            this.data.Text = "Data";
            // 
            // discard
            // 
            this.discard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.discard.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.discard.Location = new System.Drawing.Point(16, 171);
            this.discard.Margin = new System.Windows.Forms.Padding(4);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(100, 28);
            this.discard.TabIndex = 1;
            this.discard.Text = "Anuluj";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.save.Location = new System.Drawing.Point(411, 171);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 28);
            this.save.TabIndex = 0;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // TerminNowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::AMTS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 212);
            this.Controls.Add(this.DwieTakieSameDruzyny);
            this.Controls.Add(this.NoDruzyna);
            this.Controls.Add(this.numericRunda);
            this.Controls.Add(this.wybórDaty);
            this.Controls.Add(this.Przeciwnik);
            this.Controls.Add(this.Druzyna);
            this.Controls.Add(this.druzyna2);
            this.Controls.Add(this.druzyna1);
            this.Controls.Add(this.runda);
            this.Controls.Add(this.data);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.save);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TerminNowy";
            this.Text = "Dodaj termin";
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
        private System.Windows.Forms.ComboBox Druzyna;
        private System.Windows.Forms.ComboBox Przeciwnik;
        private System.Windows.Forms.DateTimePicker wybórDaty;
        private System.Windows.Forms.NumericUpDown numericRunda;
        private System.Windows.Forms.Label NoDruzyna;
        private System.Windows.Forms.Label DwieTakieSameDruzyny;
    }
}