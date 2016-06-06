namespace AMTS
{
    partial class GeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
            this.terminy = new System.Windows.Forms.DataGridView();
            this.Runda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuń = new System.Windows.Forms.CheckBox();
            this.generator = new System.Windows.Forms.Button();
            this.discard = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.poprawny = new System.Windows.Forms.Label();
            this.niepoprawny = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.terminy)).BeginInit();
            this.SuspendLayout();
            // 
            // terminy
            // 
            this.terminy.AllowUserToAddRows = false;
            this.terminy.AllowUserToDeleteRows = false;
            this.terminy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.terminy.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.terminy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.terminy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Runda,
            this.Data});
            this.terminy.Location = new System.Drawing.Point(3, 2);
            this.terminy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.terminy.Name = "terminy";
            this.terminy.RowTemplate.Height = 24;
            this.terminy.Size = new System.Drawing.Size(325, 283);
            this.terminy.TabIndex = 0;
            // 
            // Runda
            // 
            this.Runda.HeaderText = "Runda";
            this.Runda.Name = "Runda";
            this.Runda.Width = 79;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.MaxInputLength = 10;
            this.Data.Name = "Data";
            this.Data.Width = 67;
            // 
            // usuń
            // 
            this.usuń.AutoSize = true;
            this.usuń.Location = new System.Drawing.Point(264, 105);
            this.usuń.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usuń.Name = "usuń";
            this.usuń.Size = new System.Drawing.Size(199, 21);
            this.usuń.TabIndex = 1;
            this.usuń.Text = "Usunąć istniejące terminy?";
            this.usuń.UseVisualStyleBackColor = true;
            // 
            // generator
            // 
            this.generator.Location = new System.Drawing.Point(264, 74);
            this.generator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(175, 25);
            this.generator.TabIndex = 2;
            this.generator.Text = "Generuj";
            this.generator.UseVisualStyleBackColor = true;
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // discard
            // 
            this.discard.Location = new System.Drawing.Point(255, 130);
            this.discard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(75, 23);
            this.discard.TabIndex = 3;
            this.discard.Text = "Anuluj";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(379, 130);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // poprawny
            // 
            this.poprawny.AutoSize = true;
            this.poprawny.Location = new System.Drawing.Point(336, 193);
            this.poprawny.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poprawny.Name = "poprawny";
            this.poprawny.Size = new System.Drawing.Size(233, 17);
            this.poprawny.TabIndex = 5;
            this.poprawny.Text = "Poprawny format daty to rrrr-mm-dd";
            // 
            // niepoprawny
            // 
            this.niepoprawny.AutoSize = true;
            this.niepoprawny.ForeColor = System.Drawing.Color.Red;
            this.niepoprawny.Location = new System.Drawing.Point(336, 158);
            this.niepoprawny.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.niepoprawny.Name = "niepoprawny";
            this.niepoprawny.Size = new System.Drawing.Size(165, 17);
            this.niepoprawny.TabIndex = 6;
            this.niepoprawny.Text = "Niepoprawny format daty";
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 289);
            this.Controls.Add(this.niepoprawny);
            this.Controls.Add(this.poprawny);
            this.Controls.Add(this.save);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.generator);
            this.Controls.Add(this.usuń);
            this.Controls.Add(this.terminy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GeneratorForm";
            this.Text = "Generuj terminy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneratorForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.terminy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView terminy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Runda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.CheckBox usuń;
        private System.Windows.Forms.Button generator;
        private System.Windows.Forms.Button discard;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label poprawny;
        private System.Windows.Forms.Label niepoprawny;
    }
}