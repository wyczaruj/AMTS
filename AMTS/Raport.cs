using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace AMTS
{
    public partial class Raport : AbstractForm
    {
        MainForm mainForm;
        SqlConnection connection;
        string rPath;

        public Raport(MainForm MF, SqlConnection conn)
        {
            mainForm = MF;
            connection = conn;
            InitializeComponent();
            createReport();
        }

        void createReport()
        {
            Paragraph par;
            Phrase phr;
            Font f;
            int numberOfPlayers, numberOfUsers, numberOfTeams;
            string firstPlace = "", secondPlace = "", thirdPlace = "";
            Document raport = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 40, 35);
            string newPath = Path.GetTempPath();
            PdfWriter writer = PdfWriter.GetInstance(raport, new FileStream(newPath + "Raport.pdf", FileMode.Create));
            raport.Open();

            string date = DateTime.Now.ToLongDateString();

            f = FontFactory.GetFont("Calibri", 13);
            f.SetStyle("bold");
            par = new Paragraph(date, f);
            par.Alignment = Element.ALIGN_RIGHT;
            raport.Add(par);

            f = FontFactory.GetFont("Calibri", 40);
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

            numberOfUsers = getNumberOfUsers();

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(numberOfUsers.ToString(), f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);

            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Ilość zawodników:   ", f);
            raport.Add(phr);

            numberOfPlayers = getNumberOfPlayers();

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(numberOfPlayers.ToString(), f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);

            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Ilość drużyn:   ", f);
            raport.Add(phr);

            numberOfTeams = getNumberOfTeams();

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(numberOfTeams.ToString(), f); //U + 015BU + 0107
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);

            getPlaces(ref firstPlace, ref secondPlace, ref thirdPlace);

            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Pierwsze miejsce:   ", f);
            raport.Add(phr);


            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(firstPlace, f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);


            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Drugie miejsce:   ", f);
            raport.Add(phr);

            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(secondPlace, f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);


            f = FontFactory.GetFont(BaseFont.HELVETICA, BaseFont.CP1257, 15);
            f.SetStyle("bold");
            phr = new Phrase("Trzecie miejsce:   ", f);
            raport.Add(phr);


            f = FontFactory.GetFont("Calibri", 15);
            phr = new Phrase(thirdPlace, f);
            raport.Add(phr);

            raport.Add(Chunk.NEWLINE);



            raport.Close();
            pdfViewer.Document = PdfiumViewer.PdfDocument.Load(newPath + "Raport.pdf");
            rPath = newPath + "Raport.pdf";
        }

        private void Raport_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pdfViewer.Document != null)
                pdfViewer.Document.Dispose();
            File.Delete(rPath);
            mainForm.changeOpenedWindow();
        }

        int getNumberOfUsers()
        {
            SqlCommand sqlcomm = new SqlCommand("Select count(*) AS USERS FROM UZYTKOWNICY", connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            r.Read();
            int users = Int32.Parse(r["USERS"].ToString());
            r.Close();
            return users;
        }

        int getNumberOfPlayers()
        {
            SqlCommand sqlcomm = new SqlCommand("Select count(*) AS PLAYERS FROM UZYTKOWNICY WHERE Druzyna IS NOT NULL", connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            r.Read();
            int players = Int32.Parse(r["PLAYERS"].ToString());
            r.Close();
            return players;
        }

        int getNumberOfTeams()
        {
            SqlCommand sqlcomm = new SqlCommand("Select count(*) AS TEAMS FROM DRUZYNY WHERE Zatwierdzenie = 1 AND Gotowosc = 1", connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            r.Read();
            int teams = Int32.Parse(r["TEAMS"].ToString());
            r.Close();
            return teams;
        }

        void getPlaces(ref string first, ref string second, ref string third)
        {
            first = ""; second = ""; third = "";
            List<string> teams = new List<string>();
            List<int> BP = new List<int>();
            List<int> SP = new List<int>();
            List<int> SLP = new List<int>();
            SqlCommand sqlcomm = new SqlCommand("SELECT  Druzyna as TEAM, duze_punkty AS BP,"
                + " Male_punkty AS SP, Male_przegrane_punkty AS SLP" +
                " FROM Klasyfikacja ORDER BY BP DESC, SP DESC, SLP ASC", connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            while (r.Read())
            {
                teams.Add(r["TEAM"].ToString());
                BP.Add(Int32.Parse(r["BP"].ToString()));
                SP.Add(Int32.Parse(r["SP"].ToString()));
                SLP.Add(Int32.Parse(r["SLP"].ToString()));
            }
            r.Close();
            if (teams.Count != 0)
            {
                first = getNextPlace(teams, BP, SP, SLP);
            }
            if (teams.Count != 0)
            {
                second = getNextPlace(teams, BP, SP, SLP);
            }
            if (teams.Count != 0)
            {
                third = getNextPlace(teams, BP, SP, SLP);
            }

        }

        string getNextPlace(List<string> teams, List<int> BP, List<int> SP, List<int> SLP)
        {
            string place = "";
            int count = 0;
            int max = BP[0];
            for (int i = 1; i != BP.Count && BP[i] == max; i++)
            {
                count = i;
            }
            if (count == 0)
            {
                place = teams[0];
                teams.RemoveAt(0);
                BP.RemoveAt(0);
                SP.RemoveAt(0);
                SLP.RemoveAt(0);
            }
            else
            {
                int c = 1;
                for (int i = 1; i <= count; i++)
                {
                    if (SP[i] == SP[0] && SLP[i] == SLP[0])
                    {
                        c++;
                    }
                }
                for (int i = 0; i < c - 1; i++)
                {
                    place += teams[0] + ", ";
                    teams.RemoveAt(0);
                    BP.RemoveAt(0);
                    SP.RemoveAt(0);
                    SLP.RemoveAt(0);
                }
                place += teams[0];
                teams.RemoveAt(0);
                BP.RemoveAt(0);
                SP.RemoveAt(0);
                SLP.RemoveAt(0);
            }
            return place;
        }
    }
}
