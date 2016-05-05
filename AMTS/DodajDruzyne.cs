using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AMTS
{
    public partial class DodajDruzyne : AbstractForm
    {
        MainForm mainForm;
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataSet dataSet;
        User captain;
        int numberOfPlayers = 1;
        string[] emails;
        string captainName;
        string captainLastName;
        int[] imiona = {-1, 62, 23, 27, 31, 35, 39, 43, 47, 51 };
        int[] nazwiska = {-1, 22, 26, 30, 34, 38, 42, 46, 50, 54 };

        public DodajDruzyne(SqlConnection conn, MainForm f1, User captain)
        {
            emails = new string[10];
            emails[0] = captain.getEmail();
            this.captain = captain;
            mainForm = f1;
            connection = conn;
            InitializeComponent();
            registerTeam.Enabled = false;
            captainName = getName(captain.getEmail());
            captainLastName = getLastName(captain.getEmail());
            imie1.Text = captainName;
            nazwisko1.Text = captainLastName;

            dataAdapter = new SqlDataAdapter("SELECT Nazwisko, Imie, Druzyna FROM UZYTKOWNICY", conn);
            commandBuilder = new SqlCommandBuilder(dataAdapter);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "UZYTKOWNICY");
            List<string> playerList = new List<string>();
            foreach (DataRow dataRow in dataSet.Tables["UZYTKOWNICY"].Rows)
            {
                if (DBNull.Value.Equals(dataRow["Druzyna"]))
                {
                    string player = dataRow["Nazwisko"].ToString() + " " + dataRow["Imie"].ToString();
                    uzytkownicyComboBox.Items.Add(player);
                    playerList.Add(player);
                }
                string[] list = playerList.ToArray<string>();
                var autoComplete = new AutoCompleteStringCollection();
                autoComplete.AddRange(playerList.ToArray());
                uzytkownicyComboBox.AutoCompleteCustomSource = autoComplete;
            }
        }

        private void teamName_TextChanged(object sender, EventArgs e)
        {
            if (teamNameTextBox.Text.Equals(""))
            {
                registerTeam.Enabled = false;
            }
            else
            {
                SqlCommand sqlcomm = new SqlCommand("SELECT Nazwa AS TEAMNAME FROM DRUZYNY WHERE Nazwa=" + "'" + teamNameTextBox.Text + "'", connection);
                SqlDataReader r = sqlcomm.ExecuteReader();
                if (r.Read())
                {
                    TeamNameTakenLabel.Visible = true;
                    registerTeam.Enabled = false;
                }
                else
                {
                    TeamNameTakenLabel.Visible = false;
                    registerTeam.Enabled = true;
                }
                r.Close();

            }
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            alreadyAddedLabel.Visible = false;
            if (numberOfPlayers == 10)
            {
                warningUpLabel.Visible = true;
            }
            else
            if (uzytkownicyComboBox.SelectedItem != null)
            {
                string player;
                string playerName;
                string playerLastName;
                TextBox nazwisko = null;
                TextBox imie = null;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == imiona[numberOfPlayers])
                        imie = (TextBox)c;
                    if (c.TabIndex == nazwiska[numberOfPlayers])
                        nazwisko = (TextBox)c;
                }
                player = uzytkownicyComboBox.Text.ToString();
                playerName = player.Split(' ')[1];
                playerLastName = player.Split(' ')[0];
                SqlCommand sqlcomm = new SqlCommand("SELECT Mail AS EMAIL FROM UZYTKOWNICY WHERE Imie=" + "'" + playerName + "' AND Nazwisko='" + playerLastName + "'", connection);
                SqlDataReader r = sqlcomm.ExecuteReader();
                r.Read();
                Object mail = r["EMAIL"];
                r.Close();
                for(int i = 0; i < numberOfPlayers; i++)
                {
                    if (emails[i].Equals(mail.ToString()))
                    {
                        alreadyAddedLabel.Visible = true;
                        return;
                    }
                }
                nazwisko.Text = playerLastName;
                imie.Text = playerName;
                nazwisko.Visible = true;
                imie.Visible = true;
                emails[numberOfPlayers] = mail.ToString();
                numberOfPlayers++;
            }
        }

        private void cancelTeam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerTeam_Click(object sender, EventArgs e)
        {
            if (numberOfPlayers < 3)
            {
                warningDownLabel.Visible = true;
            }
            else
            {
                string comm;
                SqlCommand sqlcomm;
                comm = "exec dbo.dodajDruzyne '" + teamNameTextBox.Text + "', '" + captainName + "', '" + captainLastName + "'";
                sqlcomm = new SqlCommand(comm, connection);
                sqlcomm.ExecuteNonQuery();
                for (int i = 0; i < numberOfPlayers; i++)
                {
                    comm = "exec dbo.dodajZgloszenie '" + emails[i] + "', '" + teamNameTextBox.Text + "'";
                    sqlcomm = new SqlCommand(comm, connection);
                    sqlcomm.ExecuteNonQuery();
                }
                mainForm.successfulTeamRegistration(teamNameTextBox.Text);
                this.Close();
            }
        }

        private void DodajDruzyne_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
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
    }
}
