using PdfiumViewer;
using System;
using System.Windows.Forms;
using System.IO;

namespace AMTS
{
    public partial class Regulamin:AbstractForm
    {
        AbstractForm form;
        bool defaultLocation = true;

        public Regulamin(bool AdminLogged, AbstractForm form)
        {
            InitializeComponent();
            this.form = form;
            if(AdminLogged)
            {
                wczytaj.Visible = true;
                lokalizacja.Visible = true;
            }
            changeLocation(defaultLocation);
        }
            
        private void changeLocation(bool defLoc)
        {
            if(defLoc)
            {
                string fileName = "Regulamin.pdf";
                string path = Path.Combine(Environment.CurrentDirectory, @"", fileName);
                string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\Data\" + fileName));
                pdfViewer.Document = PdfDocument.Load(newPath);
            }
            else
            {
                string path = lokalizacja.Text;
                string fileName = Path.GetFileName(path);
                if(pdfViewer.Document != null)
                    pdfViewer.Document.Dispose();
                pdfViewer.Document = PdfDocument.Load(path);
                lokalizacja.Clear();
                defaultLocation = false;
            }
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
            OpenFileDialog dial = new OpenFileDialog();
            dial.Filter = "Files (pdf)|*.pdf";
            if(dial.ShowDialog() == DialogResult.OK)
            {
                lokalizacja.Text = dial.FileName;
                anuluj.Visible = true;
                ok.Visible = true;
            }
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            lokalizacja.Clear();
            anuluj.Visible = false;
            ok.Visible = false;
            string path = Path.Combine(Environment.CurrentDirectory, @"", "Regulamin.pdf");
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\Data\" + "Regulamin.pdf"));
            pdfViewer.Document = PdfDocument.Load(newPath);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            defaultLocation = false;
            changeLocation(false);
            anuluj.Visible = false;
            ok.Visible = false;
        }
    }
}
