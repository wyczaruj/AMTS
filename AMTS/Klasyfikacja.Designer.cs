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
            this.klasyfikacjaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.klasyfikacjaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // klasyfikacjaDataGridView
            // 
            this.klasyfikacjaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klasyfikacjaDataGridView.Location = new System.Drawing.Point(1, 2);
            this.klasyfikacjaDataGridView.Name = "klasyfikacjaDataGridView";
            this.klasyfikacjaDataGridView.Size = new System.Drawing.Size(791, 257);
            this.klasyfikacjaDataGridView.TabIndex = 0;
            // 
            // Klasyfikacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 261);
            this.Controls.Add(this.klasyfikacjaDataGridView);
            this.Name = "Klasyfikacja";
            this.Text = "Klasyfikacja";
            ((System.ComponentModel.ISupportInitialize)(this.klasyfikacjaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView klasyfikacjaDataGridView;
    }
}