using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMTS
{
    public partial class TeamRegistrations : Form
    {
        SqlConnection connection;
        MainForm mainForm;
        public TeamRegistrations(SqlConnection conn, MainForm MF)
        {
            connection = conn;
            mainForm = MF;
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            SqlCommand sqlcomm = new SqlCommand("SELECT Distinct Z.Druzyna AS TEAM FROM ZGLOSZENIA Z JOIN DRUZYNY D "
                + "ON Z.Druzyna = D.NAZWA WHERE D.Gotowosc = 1", connection);
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
            string mail;
            string captain;
            ListViewItem LVitem;
            SqlCommand sqlcomm = new SqlCommand("SELECT U.Mail AS EMAIL FROM UZYTKOWNICY U join DRUZYNY D" +
                " ON U.PESEL = D.Kapitan WHERE D.Nazwa='" + teamName + "'", connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            r.Read();
            captnEmail = r["EMAIL"].ToString();
            r.Close();

            sqlcomm = new SqlCommand("SELECT U.Imie AS NAME, U.Nazwisko AS LASTNAME, U.Mail AS EMAIL FROM "+
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
                LVitem = new ListViewItem(new[] {name, lastname, mail, captain });
                playersListView.Items.Add(LVitem);
            }
            r.Close();


        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            int countChecked = 0;
            int countall = 0;
            foreach (ListViewItem item in teamsListView.Items)
            {
                countall++;
                if (item.Checked)
                    countChecked++;
                else
                    item.Checked = true; 
            }
            if(countall == countChecked)
            {
                foreach (ListViewItem item in teamsListView.Items)
                {
                    item.Checked = false;
                }
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string teamName;
            foreach (ListViewItem item in teamsListView.Items)
            {
                if (item.Checked)
                {
                    teamName = item.Text;
                    string command = "exec dbo.zatwierdzZgloszenie '" + teamName + "'";
                    SqlCommand sqlcomm = new SqlCommand(command, connection);
                    sqlcomm.ExecuteNonQuery();
                }
            }
            playersListView.Items.Clear();
            teamsListView.Clear();
            LoadForm();
        }

        private void TeamRegistrations_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            string teamName;
            foreach (ListViewItem item in teamsListView.Items)
            {
                if (item.Checked)
                {
                    teamName = item.Text;
                    string command = "exec dbo.odrzucZgloszenie '" + teamName + "'";
                    SqlCommand sqlcomm = new SqlCommand(command, connection);
                    sqlcomm.ExecuteNonQuery();
                }
            }
            playersListView.Items.Clear();
            teamsListView.Clear();
            LoadForm();
        }
    }
}
