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
            this.złaDrużyna = new System.Windows.Forms.Label();
            this.runda = new System.Windows.Forms.Label();
            this.zmiany = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.saveEdit = new System.Windows.Forms.Button();
            this.discardEdit = new System.Windows.Forms.Button();
            this.termOpt = new System.Windows.Forms.Label();
            this.termAdd = new System.Windows.Forms.Button();
            this.termEdit = new System.Windows.Forms.Button();
            this.terminarzDataGridView = new System.Windows.Forms.DataGridView();
            this.generuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.terminarzDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // złaDrużyna
            // 
            this.złaDrużyna.AutoSize = true;
            this.złaDrużyna.ForeColor = System.Drawing.Color.Red;
            this.złaDrużyna.Location = new System.Drawing.Point(448, 280);
            this.złaDrużyna.Name = "złaDrużyna";
            this.złaDrużyna.Size = new System.Drawing.Size(153, 17);
            this.złaDrużyna.TabIndex = 13;
            this.złaDrużyna.Text = "Nieprawidłowa drużyna";
            // 
            // runda
            // 
            this.runda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runda.AutoSize = true;
            this.runda.ForeColor = System.Drawing.Color.Red;
            this.runda.Location = new System.Drawing.Point(448, 263);
            this.runda.Name = "runda";
            this.runda.Size = new System.Drawing.Size(190, 17);
            this.runda.TabIndex = 11;
            this.runda.Text = "Nieprawidłowa wartość rundy";
            // 
            // zmiany
            // 
            this.zmiany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zmiany.AutoSize = true;
            this.zmiany.ForeColor = System.Drawing.Color.Red;
            this.zmiany.Location = new System.Drawing.Point(448, 246);
            this.zmiany.Name = "zmiany";
            this.zmiany.Size = new System.Drawing.Size(215, 17);
            this.zmiany.TabIndex = 10;
            this.zmiany.Text = "Zmiany nie zostały wprowadzone";
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSize = true;
            this.data.ForeColor = System.Drawing.Color.Red;
            this.data.Location = new System.Drawing.Point(448, 297);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(130, 17);
            this.data.TabIndex = 9;
            this.data.Text = "Nieprawidłowa data";
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
            this.terminarzDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.terminarzDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.terminarzDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.terminarzDataGridView.Location = new System.Drawing.Point(0, 0);
            this.terminarzDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.terminarzDataGridView.MultiSelect = false;
            this.terminarzDataGridView.Name = "terminarzDataGridView";
            this.terminarzDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.terminarzDataGridView.Size = new System.Drawing.Size(440, 412);
            this.terminarzDataGridView.TabIndex = 1;
            this.terminarzDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.terminarzDataGridView_DataError_1);
            // 
            // generuj
            // 
            this.generuj.Location = new System.Drawing.Point(448, 248);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(258, 29);
            this.generuj.TabIndex = 14;
            this.generuj.Text = "Generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Visible = false;
            this.generuj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Terminarz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(718, 412);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.złaDrużyna);
            this.Controls.Add(this.runda);
            this.Controls.Add(this.zmiany);
            this.Controls.Add(this.data);
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
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label zmiany;
        private System.Windows.Forms.Label runda;
        private System.Windows.Forms.Label złaDrużyna;
        private System.Windows.Forms.Button generuj;
    }
}