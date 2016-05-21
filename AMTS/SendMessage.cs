using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMTS
{
    public partial class SendMessage : Form
    {
        Messages messagesForm;
        SqlConnection connection;
        private string messageSender;
        bool admin;
        bool captain;
        string team;
        List<string> recipientsMails;
        List<string> teamEmails;

        public SendMessage()
        {
            InitializeComponent();
        }

        public SendMessage(SqlConnection conn, Messages mess, User user, bool adm)
        {
            admin = adm;
            if (!admin)
            {
                captain = user.isCaptain();
                if (user.getPendingTeamRequest())
                    captain = false;
                team = user.getTeamName();
            }
            recipientsMails = new List<string>();
            connection = conn;
            messagesForm = mess;
            messageSender = user.getEmail();
            InitializeComponent();
            string command = "";
            if (admin)
            {
                usersListView.CheckBoxes = true;
                selectAllButton.Visible = true;
                sendMessageButton.Enabled = true;
                messageTextBox.Enabled = true;
                subjectTextBox.Enabled = true;
                command = "SELECT Imie AS NAME, Nazwisko AS LASTNAME, Mail AS EMAIL FROM UZYTKOWNICY WHERE Mail != '" + user.getEmail() + "'";

            }
            else if (captain)
            {
                teamMessageCheckBox.Visible = true;
                command = "SELECT Imie AS NAME, Nazwisko AS LASTNAME, Mail AS EMAIL FROM UZYTKOWNICY WHERE Mail != '" + user.getEmail() + "'";

            }
            else
            {
                command = "SELECT Imie AS NAME, Nazwisko AS LASTNAME, Mail AS EMAIL FROM UZYTKOWNICY WHERE Mail != '" + user.getEmail() + "'";

            }
            SqlCommand sqlcomm = new SqlCommand(command, connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            while (r.Read())
            {
                string player = r["NAME"].ToString() + " " + r["LASTNAME"].ToString();
                recipientsMails.Add(r["EMAIL"].ToString());
                usersListView.Items.Add(player);
            }
            r.Close();
        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            string error = "";
            string subject = "";
            string message = "";
            string recipient = "";
            subject = subjectTextBox.Text;
            message = messageTextBox.Text;
            if (subject.Equals(""))
                error += "Wpisz temat\n";
            if (message.Equals(""))
                error += "Wpisz wiadomość";
            if (!error.Equals(""))
            {
                MessageBox.Show(error);
            }
            else
            {
                if (admin)
                {
                    foreach (ListViewItem item in usersListView.Items)
                    {
                        if (item.Checked)
                        {
                            recipient = recipientsMails[item.Index];
                            sendOneMessage(recipient, subject, message);
                        }
                    }
                    this.Close();
                }
                else if (captain)
                {
                    if (teamMessageCheckBox.Checked)
                    {
                        getTeam(team);
                        foreach(string mail in teamEmails)
                        {
                            recipient = mail;
                            sendOneMessage(recipient, subject, message);
                        }
                        this.Close();
                    }
                    else
                    {
                        var item = usersListView.FindItemWithText(usersListView.SelectedItems[0].Text);
                        recipient = recipientsMails[usersListView.Items.IndexOf(item)];
                        sendOneMessage(recipient, subject, message);
                        this.Close();
                    }
                }
                else
                {
                    var item = usersListView.FindItemWithText(usersListView.SelectedItems[0].Text);
                    recipient = recipientsMails[usersListView.Items.IndexOf(item)];
                    sendOneMessage(recipient, subject, message);
                    this.Close();
                }
            }
        }

        private void sendOneMessage(string recipient, string subject, string message)
        {
            string command = "exec dbo.wyslijWiadomosc '" + messageSender + "', '" + recipient +
                "', '" + subject + "', '" + message + "'";
            SqlCommand sqlcomm = new SqlCommand(command, connection);
            sqlcomm.ExecuteNonQuery();
        }

        private void SendMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            messagesForm.changeOpenedWindow();
        }

        private void usersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectTextBox.Enabled = true;
            messageTextBox.Enabled = true;
            sendMessageButton.Enabled = true;
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            int countChecked = 0;
            int countall = 0;
            foreach (ListViewItem item in usersListView.Items)
            {
                countall++;
                if (item.Checked)
                    countChecked++;
                else
                    item.Checked = true;
            }
            if (countall == countChecked)
            {
                foreach (ListViewItem item in usersListView.Items)
                {
                    item.Checked = false;
                }
            }
        }

        private void teamMessageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (teamMessageCheckBox.Checked)
            {
                usersListView.Enabled = false;
                subjectTextBox.Enabled = true;
                messageTextBox.Enabled = true;
                sendMessageButton.Enabled = true;
            }
            else
            {
                usersListView.Enabled = true;
                subjectTextBox.Enabled = false;
                messageTextBox.Enabled = false;
                sendMessageButton.Enabled = false;
            }
        }

        private void getTeam(string team)
        {
            teamEmails = new List<string>();
            string command = "SELECT Mail AS EMAIL FROM UZYTKOWNICY WHERE Druzyna ='" + team + "' AND Mail != '" + messageSender + "'";
            SqlCommand sqlcomm = new SqlCommand(command, connection);
            SqlDataReader r = sqlcomm.ExecuteReader();
            while (r.Read())
            {
                teamEmails.Add(r["EMAIL"].ToString());
            }
            r.Close();
        }
    }
}
