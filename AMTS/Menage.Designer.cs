using System;

namespace AMTS
{
    partial class Menage
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
            this.manege = new System.Windows.Forms.TabControl();
            this.kontakty = new System.Windows.Forms.TabPage();
            this.zmiany = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.Anuluj = new System.Windows.Forms.Button();
            this.Zapisz = new System.Windows.Forms.Button();
            this.Edytuj = new System.Windows.Forms.Button();
            this.daneKontaktowe = new System.Windows.Forms.DataGridView();
            this.pojedynki = new System.Windows.Forms.TabPage();
            this.Odśwież = new System.Windows.Forms.Button();
            this.Akceptuj = new System.Windows.Forms.Button();
            this.dotrzeciego = new System.Windows.Forms.Label();
            this.dodrugiego = new System.Windows.Forms.Label();
            this.dopierwszego = new System.Windows.Forms.Label();
            this.labMecz = new System.Windows.Forms.Label();
            this.trzeci = new System.Windows.Forms.ComboBox();
            this.drugi = new System.Windows.Forms.ComboBox();
            this.pierwszy = new System.Windows.Forms.ComboBox();
            this.mecz = new System.Windows.Forms.ComboBox();
            this.manege.SuspendLayout();
            this.kontakty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daneKontaktowe)).BeginInit();
            this.pojedynki.SuspendLayout();
            this.SuspendLayout();
            // 
            // manege
            // 
            this.manege.Controls.Add(this.kontakty);
            this.manege.Controls.Add(this.pojedynki);
            this.manege.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manege.Location = new System.Drawing.Point(0, 0);
            this.manege.Name = "manege";
            this.manege.SelectedIndex = 0;
            this.manege.Size = new System.Drawing.Size(657, 192);
            this.manege.TabIndex = 0;
            // 
            // kontakty
            // 
            this.kontakty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kontakty.Controls.Add(this.zmiany);
            this.kontakty.Controls.Add(this.mail);
            this.kontakty.Controls.Add(this.telefon);
            this.kontakty.Controls.Add(this.Anuluj);
            this.kontakty.Controls.Add(this.Zapisz);
            this.kontakty.Controls.Add(this.Edytuj);
            this.kontakty.Controls.Add(this.daneKontaktowe);
            this.kontakty.Location = new System.Drawing.Point(4, 25);
            this.kontakty.Name = "kontakty";
            this.kontakty.Padding = new System.Windows.Forms.Padding(3);
            this.kontakty.Size = new System.Drawing.Size(649, 163);
            this.kontakty.TabIndex = 0;
            this.kontakty.Text = "Dane kontaktowe";
            // 
            // zmiany
            // 
            this.zmiany.AutoSize = true;
            this.zmiany.ForeColor = System.Drawing.Color.Red;
            this.zmiany.Location = new System.Drawing.Point(413, 117);
            this.zmiany.Name = "zmiany";
            this.zmiany.Size = new System.Drawing.Size(215, 17);
            this.zmiany.TabIndex = 6;
            this.zmiany.Text = "Zmiany nie zostały wprowadzone";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.ForeColor = System.Drawing.Color.Red;
            this.mail.Location = new System.Drawing.Point(413, 100);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(174, 17);
            this.mail.TabIndex = 5;
            this.mail.Text = "Nieprawidłowy adres email";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.ForeColor = System.Drawing.Color.Red;
            this.telefon.Location = new System.Drawing.Point(413, 83);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(196, 17);
            this.telefon.TabIndex = 4;
            this.telefon.Text = "Nieprawidłowy numer telefonu";
            this.telefon.Click += new System.EventHandler(this.label1_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(523, 51);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 29);
            this.Anuluj.TabIndex = 3;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.button3_Click);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(442, 51);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(75, 29);
            this.Zapisz.TabIndex = 2;
            this.Zapisz.Text = "Zapisz";
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.button2_Click);
            // 
            // Edytuj
            // 
            this.Edytuj.Location = new System.Drawing.Point(442, 51);
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Size = new System.Drawing.Size(156, 29);
            this.Edytuj.TabIndex = 1;
            this.Edytuj.Text = "Edytuj";
            this.Edytuj.UseVisualStyleBackColor = true;
            this.Edytuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // daneKontaktowe
            // 
            this.daneKontaktowe.AllowUserToAddRows = false;
            this.daneKontaktowe.AllowUserToDeleteRows = false;
            this.daneKontaktowe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.daneKontaktowe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.daneKontaktowe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daneKontaktowe.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.daneKontaktowe.Location = new System.Drawing.Point(6, 6);
            this.daneKontaktowe.MultiSelect = false;
            this.daneKontaktowe.Name = "daneKontaktowe";
            this.daneKontaktowe.RowTemplate.Height = 24;
            this.daneKontaktowe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.daneKontaktowe.Size = new System.Drawing.Size(401, 148);
            this.daneKontaktowe.TabIndex = 0;
            // 
            // pojedynki
            // 
            this.pojedynki.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pojedynki.Controls.Add(this.Odśwież);
            this.pojedynki.Controls.Add(this.Akceptuj);
            this.pojedynki.Controls.Add(this.dotrzeciego);
            this.pojedynki.Controls.Add(this.dodrugiego);
            this.pojedynki.Controls.Add(this.dopierwszego);
            this.pojedynki.Controls.Add(this.labMecz);
            this.pojedynki.Controls.Add(this.trzeci);
            this.pojedynki.Controls.Add(this.drugi);
            this.pojedynki.Controls.Add(this.pierwszy);
            this.pojedynki.Controls.Add(this.mecz);
            this.pojedynki.Location = new System.Drawing.Point(4, 25);
            this.pojedynki.Name = "pojedynki";
            this.pojedynki.Padding = new System.Windows.Forms.Padding(3);
            this.pojedynki.Size = new System.Drawing.Size(649, 163);
            this.pojedynki.TabIndex = 1;
            this.pojedynki.Text = "Pojedynki";
            // 
            // Odśwież
            // 
            this.Odśwież.Location = new System.Drawing.Point(529, 48);
            this.Odśwież.Name = "Odśwież";
            this.Odśwież.Size = new System.Drawing.Size(75, 27);
            this.Odśwież.TabIndex = 9;
            this.Odśwież.Text = "Odśwież";
            this.Odśwież.UseVisualStyleBackColor = true;
            this.Odśwież.Click += new System.EventHandler(this.button5_Click);
            // 
            // Akceptuj
            // 
            this.Akceptuj.Location = new System.Drawing.Point(448, 48);
            this.Akceptuj.Name = "Akceptuj";
            this.Akceptuj.Size = new System.Drawing.Size(75, 27);
            this.Akceptuj.TabIndex = 8;
            this.Akceptuj.Text = "Zapisz";
            this.Akceptuj.UseVisualStyleBackColor = true;
            this.Akceptuj.Click += new System.EventHandler(this.button4_Click);
            // 
            // dotrzeciego
            // 
            this.dotrzeciego.AutoSize = true;
            this.dotrzeciego.Location = new System.Drawing.Point(29, 114);
            this.dotrzeciego.Name = "dotrzeciego";
            this.dotrzeciego.Size = new System.Drawing.Size(157, 17);
            this.dotrzeciego.TabIndex = 7;
            this.dotrzeciego.Text = "Do trzeciego pojedynku";
            // 
            // dodrugiego
            // 
            this.dodrugiego.AutoSize = true;
            this.dodrugiego.Location = new System.Drawing.Point(31, 84);
            this.dodrugiego.Name = "dodrugiego";
            this.dodrugiego.Size = new System.Drawing.Size(155, 17);
            this.dodrugiego.TabIndex = 6;
            this.dodrugiego.Text = "Do drugiego pojedynku";
            // 
            // dopierwszego
            // 
            this.dopierwszego.AutoSize = true;
            this.dopierwszego.Location = new System.Drawing.Point(16, 54);
            this.dopierwszego.Name = "dopierwszego";
            this.dopierwszego.Size = new System.Drawing.Size(170, 17);
            this.dopierwszego.TabIndex = 5;
            this.dopierwszego.Text = "Do pierwszego pojedynku";
            // 
            // labMecz
            // 
            this.labMecz.AutoSize = true;
            this.labMecz.Location = new System.Drawing.Point(141, 23);
            this.labMecz.Name = "labMecz";
            this.labMecz.Size = new System.Drawing.Size(45, 17);
            this.labMecz.TabIndex = 4;
            this.labMecz.Text = "Mecz:";
            // 
            // trzeci
            // 
            this.trzeci.FormattingEnabled = true;
            this.trzeci.Location = new System.Drawing.Point(192, 111);
            this.trzeci.Name = "trzeci";
            this.trzeci.Size = new System.Drawing.Size(209, 24);
            this.trzeci.Sorted = true;
            this.trzeci.TabIndex = 3;
            // 
            // drugi
            // 
            this.drugi.FormattingEnabled = true;
            this.drugi.Location = new System.Drawing.Point(192, 81);
            this.drugi.Name = "drugi";
            this.drugi.Size = new System.Drawing.Size(209, 24);
            this.drugi.Sorted = true;
            this.drugi.TabIndex = 2;
            // 
            // pierwszy
            // 
            this.pierwszy.FormattingEnabled = true;
            this.pierwszy.Location = new System.Drawing.Point(192, 51);
            this.pierwszy.Name = "pierwszy";
            this.pierwszy.Size = new System.Drawing.Size(209, 24);
            this.pierwszy.Sorted = true;
            this.pierwszy.TabIndex = 1;
            // 
            // mecz
            // 
            this.mecz.FormattingEnabled = true;
            this.mecz.Location = new System.Drawing.Point(192, 20);
            this.mecz.Name = "mecz";
            this.mecz.Size = new System.Drawing.Size(209, 24);
            this.mecz.TabIndex = 0;
            this.mecz.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            // 
            // Menage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 192);
            this.Controls.Add(this.manege);
            this.Name = "Menage";
            this.Text = "Menage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menage_FormClosed);
            this.manege.ResumeLayout(false);
            this.kontakty.ResumeLayout(false);
            this.kontakty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daneKontaktowe)).EndInit();
            this.pojedynki.ResumeLayout(false);
            this.pojedynki.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl manege;
        private System.Windows.Forms.TabPage kontakty;
        private System.Windows.Forms.TabPage pojedynki;
        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.Button Edytuj;
        private System.Windows.Forms.DataGridView daneKontaktowe;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.Label zmiany;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label dotrzeciego;
        private System.Windows.Forms.Label dodrugiego;
        private System.Windows.Forms.Label dopierwszego;
        private System.Windows.Forms.Label labMecz;
        private System.Windows.Forms.ComboBox trzeci;
        private System.Windows.Forms.ComboBox drugi;
        private System.Windows.Forms.ComboBox pierwszy;
        private System.Windows.Forms.ComboBox mecz;
        private System.Windows.Forms.Button Odśwież;
        private System.Windows.Forms.Button Akceptuj;
    }
}