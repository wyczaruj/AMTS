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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveEdit = new System.Windows.Forms.Button();
            this.discardEdit = new System.Windows.Forms.Button();
            this.termOpt = new System.Windows.Forms.Label();
            this.termAdd = new System.Windows.Forms.Button();
            this.termEdit = new System.Windows.Forms.Button();
            this.terminarzDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.terminarzDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(448, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nieprawidłowa wartość rundy";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(448, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Zmiany nie zostały wprowadzone";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(448, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nieprawidłowa data";
            // 
            // saveEdit
            // 
            this.saveEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEdit.Location = new System.Drawing.Point(603, 249);
            this.saveEdit.Name = "saveEdit";
            this.saveEdit.Size = new System.Drawing.Size(104, 28);
            this.saveEdit.TabIndex = 8;
            this.saveEdit.Text = "Zapisz";
            this.saveEdit.UseVisualStyleBackColor = true;
            this.saveEdit.Visible = false;
            this.saveEdit.Click += new System.EventHandler(this.saveEdit_Click_1);
            // 
            // discardEdit
            // 
            this.discardEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discardEdit.Location = new System.Drawing.Point(448, 249);
            this.discardEdit.Name = "discardEdit";
            this.discardEdit.Size = new System.Drawing.Size(104, 28);
            this.discardEdit.TabIndex = 7;
            this.discardEdit.Text = "Anuluj";
            this.discardEdit.UseVisualStyleBackColor = true;
            this.discardEdit.Visible = false;
            this.discardEdit.Click += new System.EventHandler(this.discardEdit_Click_1);
            // 
            // termOpt
            // 
            this.termOpt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.termOpt.AutoSize = true;
            this.termOpt.Location = new System.Drawing.Point(548, 157);
            this.termOpt.Name = "termOpt";
            this.termOpt.Size = new System.Drawing.Size(53, 17);
            this.termOpt.TabIndex = 6;
            this.termOpt.Text = "OPCJE";
            this.termOpt.Visible = false;
            // 
            // termAdd
            // 
            this.termAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.termAdd.Location = new System.Drawing.Point(448, 178);
            this.termAdd.Margin = new System.Windows.Forms.Padding(4);
            this.termAdd.Name = "termAdd";
            this.termAdd.Size = new System.Drawing.Size(259, 28);
            this.termAdd.TabIndex = 3;
            this.termAdd.Text = "Dodaj";
            this.termAdd.UseVisualStyleBackColor = true;
            this.termAdd.Visible = false;
            this.termAdd.Click += new System.EventHandler(this.termAdd_Click);
            // 
            // termEdit
            // 
            this.termEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.termEdit.Location = new System.Drawing.Point(448, 214);
            this.termEdit.Margin = new System.Windows.Forms.Padding(4);
            this.termEdit.Name = "termEdit";
            this.termEdit.Size = new System.Drawing.Size(259, 28);
            this.termEdit.TabIndex = 2;
            this.termEdit.Text = "Edytuj";
            this.termEdit.UseVisualStyleBackColor = true;
            this.termEdit.Visible = false;
            this.termEdit.Click += new System.EventHandler(this.termEdit_Click);
            // 
            // terminarzDataGridView
            // 
            this.terminarzDataGridView.AllowUserToAddRows = false;
            this.terminarzDataGridView.AllowUserToDeleteRows = false;
            this.terminarzDataGridView.AllowUserToResizeColumns = false;
            this.terminarzDataGridView.AllowUserToResizeRows = false;
            this.terminarzDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.terminarzDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.terminarzDataGridView.Location = new System.Drawing.Point(0, 0);
            this.terminarzDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.terminarzDataGridView.MultiSelect = false;
            this.terminarzDataGridView.Name = "terminarzDataGridView";
            this.terminarzDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.terminarzDataGridView.Size = new System.Drawing.Size(439, 412);
            this.terminarzDataGridView.TabIndex = 1;
            this.terminarzDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.terminarzDataGridView_DataError_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(448, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nieprawidłowa drużyna";
            // 
            // Terminarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 412);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveEdit);
            this.Controls.Add(this.discardEdit);
            this.Controls.Add(this.termOpt);
            this.Controls.Add(this.termAdd);
            this.Controls.Add(this.termEdit);
            this.Controls.Add(this.terminarzDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}