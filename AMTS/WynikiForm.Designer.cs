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
            this.dataGridView1.Size = new System.Drawing.Size(488, 488);
            this.dataGridView1.TabIndex = 0;
            // 
            // WynikiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(665, 488);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WynikiForm";
            this.Text = "WynikiForm";
            this.Load += new System.EventHandler(this.WynikiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aMTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AMTSDataSet aMTSDataSet;
        private System.Windows.Forms.BindingSource wynikBindingSource;
        private AMTSDataSetTableAdapters.wynikTableAdapter wynikTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}