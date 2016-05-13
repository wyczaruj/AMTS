using PdfiumViewer;
using System;
using System.Windows.Forms;

namespace AMTS
{
    public partial class Regulamin:AbstractForm
    {

        AbstractForm form;
        public Regulamin(bool AdminLogged, AbstractForm form)
        {
            InitializeComponent();
            this.form = form;
            if(AdminLogged)
            {
           //     wczytaj.Visible = true;
            }
            string fileName = "Regulamin.pdf";
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"", fileName);
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\Data\" + fileName));
            if (pdfViewer.Document != null)
            {
                pdfViewer.Document.Dispose();
            }
            pdfViewer.Document = PdfDocument.Load(newPath);
        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Regulamin_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.changeOpenedWindow();
        }

        private void wczytaj_Click(object sender, EventArgs e)
        {

        }
    }
}
