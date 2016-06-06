namespace AMTS.Data {
    partial class Klasyfikacja {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klasyfikacja));
            this.klasyfikacjaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.klasyfikacjaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // klasyfikacjaDataGridView
            // 
            this.klasyfikacjaDataGridView.AllowUserToAddRows = false;
            this.klasyfikacjaDataGridView.AllowUserToDeleteRows = false;
            this.klasyfikacjaDataGridView.AllowUserToResizeRows = false;
            this.klasyfikacjaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.klasyfikacjaDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.klasyfikacjaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klasyfikacjaDataGridView.Location = new System.Drawing.Point(0, 0);
            this.klasyfikacjaDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.klasyfikacjaDataGridView.Name = "klasyfikacjaDataGridView";
            this.klasyfikacjaDataGridView.ReadOnly = true;
            this.klasyfikacjaDataGridView.Size = new System.Drawing.Size(774, 376);
            this.klasyfikacjaDataGridView.TabIndex = 0;
            // 
            // Klasyfikacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 376);
            this.Controls.Add(this.klasyfikacjaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Klasyfikacja";
            this.Text = "Klasyfikacja";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Klasyfikacja_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.klasyfikacjaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView klasyfikacjaDataGridView;
    }
}