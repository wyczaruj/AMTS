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
            this.aMTSDataSet = new AMTS.AMTSDataSet();
            this.wynikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wynikTableAdapter = new AMTS.AMTSDataSetTableAdapters.wynikTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.discard = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aMTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(488, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(627, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wybierz rundę";
            // 
            // edit
            // 
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
            this.save.Location = new System.Drawing.Point(619, 208);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(83, 33);
            this.save.TabIndex = 5;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(494, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Zmiany nie zostały wprowadzone";
            // 
            // WynikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WynikiForm";
            this.Text = "WynikiForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WynikiForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.aMTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AMTSDataSet aMTSDataSet;
        private System.Windows.Forms.BindingSource wynikBindingSource;
        private AMTSDataSetTableAdapters.wynikTableAdapter wynikTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button discard;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
    }
}