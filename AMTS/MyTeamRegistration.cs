using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMTS
{
    public partial class MyTeamRegistration : Form
    {
        SqlConnection connection;
        MainForm mainForm;
        public MyTeamRegistration(string team, SqlConnection conn, MainForm MF)
        {
            InitializeComponent();
            connection = conn;
            string teamName;
            string captnEmail;
            string name;
            string lastname;
            string captain;
            string mail;
            string confirmation;
            ListViewItem LVitem;
            teamName = team;
            mainForm = MF;
            teamNameLabel.Text = team;
            string comm = "SELECT U.Mail AS EMAIL FROM UZYTKOWNICY U join DRUZYNY D" +
                " ON U.PESEL = D.Kapitan WHERE D.Nazwa='" + teamName + "'";
            SqlCommand sqlcomm = new SqlCommand(comm, connection);
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
                string conf = r["AGREE"].ToString();
                if (conf.Equals("1"))
                    confirmation = "TAK";
                else if (conf.Equals("0"))
                    confirmation = "BRAK";
                else
                    confirmation = "ODRZUCENIE";
                LVitem = new ListViewItem(new[] { name, lastname, mail, captain, confirmation });
                playersListView.Items.Add(LVitem);
            }
            r.Close();
        }
    }
}
