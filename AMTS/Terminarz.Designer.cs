namespace AMTS
{
    partial class Terminarz
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
            this.terminarzDataGridView = new System.Windows.Forms.DataGridView();
            this.termEdit = new System.Windows.Forms.Button();
            this.termAdd = new System.Windows.Forms.Button();
            this.termOpt = new System.Windows.Forms.Label();
            this.discardEdit = new System.Windows.Forms.Button();
            this.saveEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.terminarzDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // terminarzDataGridView
            // 
            this.terminarzDataGridView.AllowUserToAddRows = false;
            this.terminarzDataGridView.AllowUserToDeleteRows = false;
            this.terminarzDataGridView.AllowUserToResizeColumns = false;
            this.terminarzDataGridView.AllowUserToResizeRows = false;
            this.terminarzDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.terminarzDataGridView.Location = new System.Drawing.Point(8, 11);
            this.terminarzDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.terminarzDataGridView.Name = "terminarzDataGridView";
            this.terminarzDataGridView.Size = new System.Drawing.Size(1271, 458);
            this.terminarzDataGridView.TabIndex = 1;
            // 
            // termEdit
            // 
            this.termEdit.Location = new System.Drawing.Point(1287, 214);
            this.termEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termEdit.Name = "termEdit";
            this.termEdit.Size = new System.Drawing.Size(259, 28);
            this.termEdit.TabIndex = 2;
            this.termEdit.Text = "Edytuj";
            this.termEdit.UseVisualStyleBackColor = true;
            this.termEdit.Visible = false;
            this.termEdit.Click += new System.EventHandler(this.termEdit_Click);
            // 
            // termAdd
            // 
            this.termAdd.Location = new System.Drawing.Point(1287, 178);
            this.termAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termAdd.Name = "termAdd";
            this.termAdd.Size = new System.Drawing.Size(259, 28);
            this.termAdd.TabIndex = 3;
            this.termAdd.Text = "Dodaj";
            this.termAdd.UseVisualStyleBackColor = true;
            this.termAdd.Visible = false;
            this.termAdd.Click += new System.EventHandler(this.termAdd_Click);
            // 
            // termOpt
            // 
            this.termOpt.AutoSize = true;
            this.termOpt.Location = new System.Drawing.Point(1388, 159);
            this.termOpt.Name = "termOpt";
            this.termOpt.Size = new System.Drawing.Size(53, 17);
            this.termOpt.TabIndex = 6;
            this.termOpt.Text = "OPCJE";
            this.termOpt.Visible = false;
            // 
            // discardEdit
            // 
            this.discardEdit.Location = new System.Drawing.Point(1287, 250);
            this.discardEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discardEdit.Name = "discardEdit";
            this.discardEdit.Size = new System.Drawing.Size(100, 28);
            this.discardEdit.TabIndex = 7;
            this.discardEdit.Text = "Anuluj";
            this.discardEdit.UseVisualStyleBackColor = true;
            this.discardEdit.Visible = false;
            this.discardEdit.Click += new System.EventHandler(this.discardEdit_Click);
            // 
            // saveEdit
            // 
            this.saveEdit.Location = new System.Drawing.Point(1445, 250);
            this.saveEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveEdit.Name = "saveEdit";
            this.saveEdit.Size = new System.Drawing.Size(100, 28);
            this.saveEdit.TabIndex = 8;
            this.saveEdit.Text = "Zapisz";
            this.saveEdit.UseVisualStyleBackColor = true;
            this.saveEdit.Visible = false;
            this.saveEdit.Click += new System.EventHandler(this.saveEdit_Click);
            // 
            // Terminarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 502);
            this.Controls.Add(this.saveEdit);
            this.Controls.Add(this.discardEdit);
            this.Controls.Add(this.termOpt);
            this.Controls.Add(this.termAdd);
            this.Controls.Add(this.termEdit);
            this.Controls.Add(this.terminarzDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Terminarz";
            this.Text = "Terminarz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Terminarz_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.terminarzDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView terminarzDataGridView;
        private System.Windows.Forms.Button termEdit;
        private System.Windows.Forms.Button termAdd;
        private System.Windows.Forms.Label termOpt;
        private System.Windows.Forms.Button discardEdit;
        private System.Windows.Forms.Button saveEdit;

    }
}