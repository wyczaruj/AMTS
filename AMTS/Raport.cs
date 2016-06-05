using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace AMTS
{
    public partial class Raport : AbstractForm
    {
        MainForm mainForm;

        public Raport(MainForm MF)
        {
            mainForm = MF;
            InitializeComponent();
            createReport();
        }

        void createReport()
        {
            Paragraph par;
            Phrase phr;
            int numberOfPlayers, numberOfUsers, numberOfTeams;
            string firstPlace, secondPlace, thirdPlace;
            Document raport = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 40, 35);
            string path = Path.Combine(Environment.CurrentDirectory, @"", "");
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\"));
            PdfWriter writer = PdfWriter.GetInstance(raport, new FileStream(newPath + "Raport.pdf", FileMode.Create));
            raport.Open();

            iTextSharp.text.Font f = FontFactory.GetFont("Calibri", 40);
            f.SetStyle("bold");
            par = new Paragraph("RAPORT", f);
            par.Alignment = Element.ALIGN_CENTER;
            raport.Add(par);

            par = new Paragraph(" ");
            raport.Add(par);

            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Ilość zarejestrowanych użytkowników:   ", f);
            raport.Add(phr);

            numberOfUsers = 0;

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(numberOfUsers.ToString(), f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);

            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Ilość zawodników:   ", f);
            raport.Add(phr);

            numberOfPlayers = 0; 

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(numberOfPlayers.ToString(), f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);

            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Ilość drużyn:   ", f);
            raport.Add(phr);

            numberOfTeams = 0;

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(numberOfTeams.ToString(), f); //U + 015BU + 0107
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);

            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Pierwsze miejsce:   ", f);
            raport.Add(phr);

            string team = "";

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(team, f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);


            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Drugie miejsce:   ", f);
            raport.Add(phr);

            team = "";

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(team, f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);


            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Trzecie miejsce:   ", f);
            raport.Add(phr);

            team = "";

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(team, f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);



            raport.Close();
            pdfViewer.Document = PdfiumViewer.PdfDocument.Load(newPath + "Raport.pdf");
        }

        private void Raport_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pdfViewer.Document != null)
                pdfViewer.Document.Dispose();
            mainForm.changeOpenedWindow();
        }
    }
}
