using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

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
                wczytaj.Visible = true;
            }
            string fileName = "Regulamin.pdf";
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, @"", fileName);
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, @"..\..\..\Data\" + fileName));
            //    PdfReader file = new PdfReader(newPath);
            //     for(int i = 1; i <= file.NumberOfPages; i++)
            //        tresc.Text += PdfTextExtractor.GetTextFromPage(file, i, new SimpleTextExtractionStrategy());
            //RegulaminAxAcroPDF.LoadFile(newPath);
            var acro = (AcroPDFLib.IAcroAXDocShim)RegulaminAxAcroPDF.GetOcx();
            acro.src = newPath;
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
