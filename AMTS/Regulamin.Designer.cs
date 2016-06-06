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
            this.anuluj = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.lokalizacja = new System.Windows.Forms.TextBox();
            this.wczytaj = new System.Windows.Forms.Button();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.SuspendLayout();
            // 
            // anuluj
            // 
            this.anuluj.Location = new System.Drawing.Point(888, 0);
            this.anuluj.Margin = new System.Windows.Forms.Padding(4);
            this.anuluj.Name = "anuluj";
            this.anuluj.Size = new System.Drawing.Size(100, 27);
            this.anuluj.TabIndex = 10;
            this.anuluj.Text = "Anuluj";
            this.anuluj.UseVisualStyleBackColor = true;
            this.anuluj.Visible = false;
            this.anuluj.Click += new System.EventHandler(this.anuluj_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(780, -1);
            this.ok.Margin = new System.Windows.Forms.Padding(4);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 28);
            this.ok.TabIndex = 8;
            this.ok.Text = "Zatwierdź";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Visible = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // lokalizacja
            // 
            this.lokalizacja.Enabled = false;
            this.lokalizacja.Location = new System.Drawing.Point(249, 4);
            this.lokalizacja.Margin = new System.Windows.Forms.Padding(4);
            this.lokalizacja.Name = "lokalizacja";
            this.lokalizacja.Size = new System.Drawing.Size(521, 22);
            this.lokalizacja.TabIndex = 7;
            this.lokalizacja.Visible = false;
            // 
            // wczytaj
            // 
            this.wczytaj.Location = new System.Drawing.Point(141, 0);
            this.wczytaj.Margin = new System.Windows.Forms.Padding(4);
            this.wczytaj.Name = "wczytaj";
            this.wczytaj.Size = new System.Drawing.Size(100, 28);
            this.wczytaj.TabIndex = 6;
            this.wczytaj.Text = "Załaduj";
            this.wczytaj.UseVisualStyleBackColor = true;
            this.wczytaj.Visible = false;
            this.wczytaj.Click += new System.EventHandler(this.wczytaj_Click);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Margin = new System.Windows.Forms.Padding(5);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(1293, 709);
            this.pdfViewer.TabIndex = 5;
            this.pdfViewer.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // Regulamin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1293, 709);
            this.Controls.Add(this.anuluj);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.lokalizacja);
            this.Controls.Add(this.wczytaj);
            this.Controls.Add(this.pdfViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Regulamin";
            this.Text = "Regulamin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regulamin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PdfiumViewer.PdfViewer pdfViewer;
        private System.Windows.Forms.Button wczytaj;
        private System.Windows.Forms.TextBox lokalizacja;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button anuluj;
    }
}