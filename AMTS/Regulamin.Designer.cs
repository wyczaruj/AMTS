namespace AMTS
{
    partial class Regulamin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Regulamin));
            this.Zamknij = new System.Windows.Forms.Button();
            this.wczytaj = new System.Windows.Forms.Button();
            this.RegulaminAxAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.RegulaminAxAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // Zamknij
            // 
            this.Zamknij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Zamknij.Location = new System.Drawing.Point(1167, 664);
            this.Zamknij.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(103, 32);
            this.Zamknij.TabIndex = 2;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // wczytaj
            // 
            this.wczytaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wczytaj.Location = new System.Drawing.Point(13, 668);
            this.wczytaj.Margin = new System.Windows.Forms.Padding(4);
            this.wczytaj.Name = "wczytaj";
            this.wczytaj.Size = new System.Drawing.Size(100, 28);
            this.wczytaj.TabIndex = 4;
            this.wczytaj.Text = "Wczytaj plik";
            this.wczytaj.UseVisualStyleBackColor = true;
            // 
            // RegulaminAxAcroPDF
            // 
            this.RegulaminAxAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegulaminAxAcroPDF.Enabled = true;
            this.RegulaminAxAcroPDF.Location = new System.Drawing.Point(0, 0);
            this.RegulaminAxAcroPDF.Name = "RegulaminAxAcroPDF";
            this.RegulaminAxAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("RegulaminAxAcroPDF.OcxState")));
            this.RegulaminAxAcroPDF.Size = new System.Drawing.Size(1294, 709);
            this.RegulaminAxAcroPDF.TabIndex = 5;
            // 
            // Regulamin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 709);
            this.Controls.Add(this.wczytaj);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.RegulaminAxAcroPDF);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Regulamin";
            this.Text = "Regulamin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regulamin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.RegulaminAxAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Button wczytaj;
        private AxAcroPDFLib.AxAcroPDF RegulaminAxAcroPDF;
    }
}