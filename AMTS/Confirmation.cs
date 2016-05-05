using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMTS
{
    public partial class Confirmation : Form
    {
        SqlConnection connection;
        MainForm mainForm;

        public Confirmation(SqlConnection conn, MainForm MF, User user)
        {
            connection = conn;
            mainForm = MF;
            InitializeComponent();

            string comm = "SELECT DRUZYNA AS TEAM FROM ZGLOSZENIA WHERE Mail ='"
                + user.getEmail() + "'";
            SqlCommand sqlcomm = new SqlCommand(comm , connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            while (r.Read())
            {
                teamsListView.Items.Add(r["TEAM"].ToString());
            }
            r.Close();
        }

        private void teamsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            playersListView.Items.Clear();
            if (teamsListView.SelectedIndices.Count <= 0)
            {
                return;
            }
            string teamName = teamsListView.SelectedItems[0].Text;
            string captnEmail;
            string name;
            string lastname;
            string captain;
            string mail;
            string confirmation;
            ListViewItem LVitem;
            SqlCommand sqlcomm = new SqlCommand("SELECT U.Mail AS EMAIL FROM UZYTKOWNICY U join DRUZYNY D" +
                " ON U.PESEL = D.Kapitan WHERE D.Nazwa='" + teamName + "'", connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            r.Read();
            captnEmail = r["EMAIL"].ToString();
            r.Close();

            sqlcomm = new SqlCommand("SELECT U.Imie AS NAME, U.Nazwisko AS LASTNAME, U.Mail AS EMAIL, Z.Potwierdzenie AS AGREE FROM " +
                "UZYTKOWNICY U JOIN ZGLOSZENIA Z ON Z.Mail = U.Mail WHERE Z.Druzyna = '" + teamName + "'", connection);
            r = sqlcomm.ExecuteReader();
            while (r.Read())
            {
                name = r["NAME"].ToString();
                lastname = r["LASTNAME"].ToString();
                mail = r["EMAIL"].ToString();
                if (mail.Equals(captnEmail))
                    captain = "     X";
                else
                    captain = "";
                if ((bool)r["AGREE"])
                    confirmation = "TAK";
                else
                    confirmation = "BRAK";
                LVitem = new ListViewItem(new[] { name, lastname, mail, captain, confirmation });
                playersListView.Items.Add(LVitem);
            }
            r.Close();

        }
    }
}
