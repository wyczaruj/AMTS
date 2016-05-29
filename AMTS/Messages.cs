using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMTS
{
    public partial class Messages : AbstractForm
    {
        MainForm mainForm;
        User user;
        SqlConnection connection;
        bool admin;
        List<string> sendersMails;
        List<int> subjectIds;
        public Messages()
        {
            InitializeComponent();
        }

        public Messages(SqlConnection conn, MainForm MF, User user, bool admin)
        {
            InitializeComponent();
            sendersMails = new List<string>();
            mainForm = MF;
            connection = conn;
            this.admin = admin;
            this.user = user;
            string command;
            command = "SELECT DISTINCT Nadawca AS SENDER FROM TEMATY WHERE Adresat = '" + user.getEmail() + "'";
            SqlCommand sqlcomm = new SqlCommand(command, connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            while (r.Read())
            {
                string send = r["SENDER"].ToString();
                string player = getName(send) + " " + getLastName(send);
                sendersMails.Add(send);
                sendersListView.Items.Add(player);
            }
            r.Close();
        }

        private void sendNewMessageButton_Click(object sender, EventArgs e)
        {
            if (!openedWindow)
            {
                changeOpenedWindow();
                SendMessage SM = new SendMessage(connection, this, user, admin);
                SM.Visible = true;
            }
        }

        private string getName(string login)
        {
            SqlCommand sqlcomm = new SqlCommand("SELECT Imie AS NAME FROM UZYTKOWNICY WHERE Mail=" + "'" + login + "'", connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            r.Read();
            Object name = r["NAME"];
            r.Close();
            return name.ToString();
        }

        private string getLastName(string login)
        {
            SqlCommand sqlcomm = new SqlCommand("SELECT Nazwisko AS LASTNAME FROM UZYTKOWNICY WHERE Mail=" + "'" + login + "'", connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            r.Read();
            Object lastName = r["LASTNAME"];

            r.Close();
            return lastName.ToString();
        }

        private void Messages_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }

        private void sendersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem LVitem;
            string date;
            string subject;
            if (sendersListView.SelectedIndices.Count <= 0)
            {
                return;
            }
            subjectListView.Items.Clear();
            subjectIds = new List<int>();
            string senderMail = sendersMails[sendersListView.SelectedIndices[0]];


            string command = "SELECT Id AS ID, Temat AS SUBJECT, Data as DATE FROM TEMATY WHERE Nadawca ='" + senderMail
                + "' AND Adresat = '" + user.getEmail() + "'";
            SqlCommand sqlcomm = new SqlCommand(command, connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            while (r.Read())
            {
                subjectIds.Add(Int32.Parse(r["ID"].ToString()));
                date = r["DATE"].ToString();
                subject = r["SUBJECT"].ToString();
                LVitem = new ListViewItem(new[] {date , subject});
                subjectListView.Items.Add(LVitem);
            }
            r.Close();
            subjectListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void subjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectListView.SelectedIndices.Count <= 0)
            {
                return;
            }
            int i = subjectListView.SelectedIndices[0];
            int ID =  subjectIds[i];
            string command = "SELECT Wiadomosc AS MESSAGE FROM WIADOMOSCI WHERE Tem ='" 
                + subjectListView.SelectedItems[0].SubItems[1].Text + "' AND id_tem =" + ID.ToString();
            SqlCommand sqlcomm = new SqlCommand(command, connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            if (r.Read())
                messageTextBox.Text = r["MESSAGE"].ToString();
            r.Close();
        }
    }
}
