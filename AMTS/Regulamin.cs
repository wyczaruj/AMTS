using PdfiumViewer;
using System;
using System.IO;
using System.Windows.Forms;

namespace AMTS
{
    public partial class Regulamin : AbstractForm
    {
        AbstractForm form;
        string path;

        public Regulamin(bool AdminLogged, AbstractForm form)
        {
            InitializeComponent();
            this.form = form;
            if (AdminLogged)
            {
                wczytaj.Visible = true;
            }
            string fileName = "Regulamin.pdf";
            string path = Path.Combine(Environment.CurrentDirectory, @"", fileName);
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\Data\" + fileName));
            this.path = newPath;
            pdfViewer.Document = PdfDocument.Load(newPath);
        }

        private void changeLocation()
        {
            string sourceFile = lokalizacja.Text;
            string destFile = path;
            lokalizacja.Clear();
            if (pdfViewer.Document != null)
                pdfViewer.Document.Dispose();
            System.IO.File.Copy(sourceFile, destFile, true);
            pdfViewer.Document = PdfDocument.Load(path);
        }

        private void Regulamin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pdfViewer.Document != null)
                pdfViewer.Document.Dispose();
            form.changeOpenedWindow();
        }

        private void wczytaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog dial = new OpenFileDialog();
            dial.Filter = "Files (pdf)|*.pdf";
            if (dial.ShowDialog() == DialogResult.OK)
            {
                lokalizacja.Text = dial.FileName;
                lokalizacja.Visible = true;
                anuluj.Visible = true;
                ok.Visible = true;
            }
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            lokalizacja.Clear();
            anuluj.Visible = false;
            ok.Visible = false;
            lokalizacja.Visible = false;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            changeLocation();
            anuluj.Visible = false;
            ok.Visible = false;
            lokalizacja.Visible = false;
        }
    }
}
