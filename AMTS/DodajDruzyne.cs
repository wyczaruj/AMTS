using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMTS
{
    public partial class DodajDruzyne : Form
    {
        MainForm form;
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataSet dataSet;
        string LoggedIn;
        int numberOfPlayers = 1;
        string[] emails;
        string captainName;
        string captainLastName;
        int[] imiona = {-1, 62, 23, 27, 31, 35, 39, 43, 47, 51 };
        int[] nazwiska = {-1, 22, 26, 30, 34, 38, 42, 46, 50, 54 };

        public DodajDruzyne(SqlConnection conn, MainForm f1, string LoggedIn)
        {
            emails = new string[10];
            emails[0] = LoggedIn;
            this.LoggedIn = LoggedIn;
            form = f1;
            connection = conn;
            InitializeComponent();

            registerTeam.Enabled = false;
            captainName = getName(LoggedIn);
            captainLastName = getLastName(LoggedIn);
            imie1.Text = captainName;
            nazwisko1.Text = captainLastName;

            dataAdapter = new SqlDataAdapter("SELECT Nazwisko, Imie FROM UZYTKOWNICY", conn);
            commandBuilder = new SqlCommandBuilder(dataAdapter);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "UZYTKOWNICY");

            foreach (DataRow dataRow in dataSet.Tables["UZYTKOWNICY"].Rows)
            {
                uzytkownicy.Items.Add(dataRow["Nazwisko"].ToString() + " " + dataRow["Imie"].ToString());
            }
        }

        private void teamName_TextChanged(object sender, EventArgs e)
        {
            if (teamName.Text.Equals(""))
            {
                registerTeam.Enabled = false;
            }
            else
            {
                registerTeam.Enabled = true;
            }
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            if (numberOfPlayers == 10)
            {
                warningUpLabel.Visible = true;
            }
            else
            if (uzytkownicy.SelectedItem != null)
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
                player = uzytkownicy.Text.ToString();
                playerName = player.Split(' ')[1];
                playerLastName = player.Split(' ')[0];
                nazwisko.Text = playerLastName;
                imie.Text = playerName;
                nazwisko.Visible = true;
                imie.Visible = true;
                SqlCommand sqlcomm = new SqlCommand("SELECT Mail AS EMAIL FROM UZYTKOWNICY WHERE Imie=" + "'" + playerName + "' AND Nazwisko='" + playerLastName + "'", connection);
                SqlDataReader r = sqlcomm.ExecuteReader();
                r.Read();
                Object mail = r["EMAIL"];
                r.Close();
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
                string comm = "exec dbo.dodajDruzyne '" + teamName.Text + "', '" + captainName + "', '" + captainLastName + "'";
                SqlCommand sqlcomm = new SqlCommand(comm, connection);
                sqlcomm.ExecuteNonQuery();
                this.Close();
            }
        }

        private void DodajDruzyne_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.changeOpenedWindow();
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
