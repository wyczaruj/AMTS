namespace AMTS
{
    partial class WynikiForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WynikiForm));
            this.aMTSDataSet = new AMTS.AMTSDataSet();
            this.wynikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wynikTableAdapter = new AMTS.AMTSDataSetTableAdapters.wynikTableAdapter();
            this.wyniki = new System.Windows.Forms.DataGridView();
            this.runda = new System.Windows.Forms.ComboBox();
            this.wybór = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.discard = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.zmiany = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aMTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyniki)).BeginInit();
            this.SuspendLayout();
            // 
            // aMTSDataSet
            // 
            this.aMTSDataSet.DataSetName = "AMTSDataSet";
            this.aMTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wynikBindingSource
            // 
            this.wynikBindingSource.DataMember = "wynik";
            this.wynikBindingSource.DataSource = this.aMTSDataSet;
            // 
            // wynikTableAdapter
            // 
            this.wynikTableAdapter.ClearBeforeFill = true;
            // 
            // wyniki
            // 
            this.wyniki.AllowUserToAddRows = false;
            this.wyniki.AllowUserToDeleteRows = false;
            this.wyniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.wyniki.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.wyniki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wyniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wyniki.Location = new System.Drawing.Point(0, 0);
            this.wyniki.Name = "wyniki";
            this.wyniki.RowTemplate.Height = 24;
            this.wyniki.Size = new System.Drawing.Size(488, 402);
            this.wyniki.TabIndex = 0;
            // 
            // runda
            // 
            this.runda.Font = new System.Drawing.Font("Calibri", 9F);
            this.runda.FormattingEnabled = true;
            this.runda.Location = new System.Drawing.Point(627, 139);
            this.runda.Name = "runda";
            this.runda.Size = new System.Drawing.Size(75, 26);
            this.runda.TabIndex = 1;
            this.runda.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // wybór
            // 
            this.wybór.AutoSize = true;
            this.wybór.Location = new System.Drawing.Point(494, 142);
            this.wybór.Name = "wybór";
            this.wybór.Size = new System.Drawing.Size(100, 17);
            this.wybór.TabIndex = 2;
            this.wybór.Text = "Wybierz rundę";
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.edit.Location = new System.Drawing.Point(522, 169);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(159, 33);
            this.edit.TabIndex = 3;
            this.edit.Text = "Edytuj";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // discard
            // 
            this.discard.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.discard.Location = new System.Drawing.Point(494, 208);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(86, 33);
            this.discard.TabIndex = 4;
            this.discard.Text = "Anuluj";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.save.Location = new System.Drawing.Point(619, 208);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(83, 33);
            this.save.TabIndex = 5;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // zmiany
            // 
            this.zmiany.AutoSize = true;
            this.zmiany.ForeColor = System.Drawing.Color.Red;
            this.zmiany.Location = new System.Drawing.Point(494, 205);
            this.zmiany.Name = "zmiany";
            this.zmiany.Size = new System.Drawing.Size(215, 17);
            this.zmiany.TabIndex = 6;
            this.zmiany.Text = "Zmiany nie zostały wprowadzone";
            // 
            // WynikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 400);
            this.Controls.Add(this.zmiany);
            this.Controls.Add(this.save);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.wybór);
            this.Controls.Add(this.runda);
            this.Controls.Add(this.wyniki);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WynikiForm";
            this.Text = "Wyniki";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WynikiForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.aMTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyniki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AMTSDataSet aMTSDataSet;
        private System.Windows.Forms.BindingSource wynikBindingSource;
        private AMTSDataSetTableAdapters.wynikTableAdapter wynikTableAdapter;
        private System.Windows.Forms.DataGridView wyniki;
        private System.Windows.Forms.ComboBox runda;
        private System.Windows.Forms.Label wybór;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button discard;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label zmiany;
    }
}