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
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.SuspendLayout();
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(1294, 709);
            this.pdfViewer.TabIndex = 5;
            this.pdfViewer.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // Regulamin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 709);
            this.Controls.Add(this.pdfViewer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Regulamin";
            this.Text = "Regulamin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regulamin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private PdfiumViewer.PdfViewer pdfViewer;
    }
}