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
    public partial class DodajDruzyne:Form
    {
        MainForm form;
        SqlConnection connection;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;
        DataSet dataSet;
        SqlCommand sqlComm;

        public DodajDruzyne(SqlConnection conn, MainForm f1)
        {
            form = f1;
            connection = conn;
            InitializeComponent();

            i.Visible = false;
            imiona.Visible = false;
            dataAdapter = new SqlDataAdapter("SELECT Nazwisko, Imie FROM UZYTKOWNICY", conn);
            commandBuilder = new SqlCommandBuilder(dataAdapter);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "UZYTKOWNICY");

            foreach(DataRow dataRow in dataSet.Tables["UZYTKOWNICY"].Rows)
            {
                uzytkownicy.Items.Add(dataRow["Nazwisko"].ToString());
            }

            foreach(DataRow dataRow in dataSet.Tables["UZYTKOWNICY"].Rows)
            {
                imiona.Items.Add(dataRow["Imie"].ToString()); // ?tylko imiona o podanych nazwiskach?
            }

            // nazwisko1.Text = Form1.LoggedIn.Text; // ?wstawic zalogowanego uzytkownika?
        }

        private void teamName_TextChanged(object sender, EventArgs e)
        {
            if(teamName.Text.Equals(""))
            {
                registerTeam.Enabled = false;
            }
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            if(uzytkownicy.SelectedItem != null)
            {
                imiona.Visible = true; // ?tylko jesli powtarza sie nazwisko?
                i.Visible = true;
                if(nazwisko2.Text == "")
                {
                    nazwisko2.Text = uzytkownicy.SelectedItem.ToString();
                    sqlComm = new SqlCommand("SELECT Imie AS Imie FROM UZYTKOWNICY WHERE Nazwisko = " + "'" + uzytkownicy.SelectedItem.ToString() + "'", connection);
                    imie2.Text = sqlComm.ToString();
                    nazwisko2.Visible = true;
                    imie2.Visible = true;
                }
                else if(nazwisko3.Text == "")
                {
                    nazwisko3.Text = uzytkownicy.SelectedItem.ToString();
                    sqlComm = new SqlCommand("SELECT Imie AS Imie FROM UZYTKOWNICY WHERE Nazwisko = " + "'" + uzytkownicy.SelectedItem.ToString() + "'", connection);
                    imie3.Text = sqlComm.ToString();
                    nazwisko3.Visible = true;
                    imie3.Visible = true;
                }
                else if(nazwisko4.Text == "")
                {
                    nazwisko4.Text = uzytkownicy.SelectedItem.ToString();
                    sqlComm = new SqlCommand("SELECT Imie AS Imie FROM UZYTKOWNICY WHERE Nazwisko = " + "'" + uzytkownicy.SelectedItem.ToString() + "'", connection);
                    imie4.Text = sqlComm.ToString();
                    nazwisko4.Visible = true;
                    imie4.Visible = true;
                }
                else if(nazwisko5.Text == "")
                {
                    nazwisko5.Text = uzytkownicy.SelectedItem.ToString();
                    sqlComm = new SqlCommand("SELECT Imie AS Imie FROM UZYTKOWNICY WHERE Nazwisko = " + "'" + uzytkownicy.SelectedItem.ToString() + "'", connection);
                    imie5.Text = sqlComm.ToString();
                    imie5.Text = dataAdapter.ToString();
                    nazwisko5.Visible = true;
                    imie5.Visible = true;
                }
                else if(nazwisko6.Text == "")
                {
                    nazwisko6.Text = uzytkownicy.SelectedItem.ToString();
                    sqlComm = new SqlCommand("SELECT Imie AS Imie FROM UZYTKOWNICY WHERE Nazwisko = " + "'" + uzytkownicy.SelectedItem.ToString() + "'", connection);
                    imie6.Text = sqlComm.ToString();
                    imie6.Text = dataAdapter.ToString();
                    nazwisko6.Visible = true;
                    imie6.Visible = true;
                }
                else if(nazwisko7.Text == "")
                {
                    nazwisko7.Text = uzytkownicy.SelectedItem.ToString();
                    sqlComm = new SqlCommand("SELECT Imie AS Imie FROM UZYTKOWNICY WHERE Nazwisko = " + "'" + uzytkownicy.SelectedItem.ToString() + "'", connection);
                    imie7.Text = sqlComm.ToString();
                    imie7.Text = dataAdapter.ToString();
                    nazwisko7.Visible = true;
                    imie7.Visible = true;
                }
                else if(nazwisko8.Text == "")
                {
                    nazwisko8.Text = uzytkownicy.SelectedItem.ToString();
                    sqlComm = new SqlCommand("SELECT Imie AS Imie FROM UZYTKOWNICY WHERE Nazwisko = " + "'" + uzytkownicy.SelectedItem.ToString() + "'", connection);
                    imie8.Text = sqlComm.ToString();
                    imie8.Text = dataAdapter.ToString();
                    nazwisko8.Visible = true;
                    imie8.Visible = true;
                }
                else if(nazwisko9.Text == "")
                {
                    nazwisko9.Text = uzytkownicy.SelectedItem.ToString();
                    sqlComm = new SqlCommand("SELECT Imie AS Imie FROM UZYTKOWNICY WHERE Nazwisko = " + "'" + uzytkownicy.SelectedItem.ToString() + "'", connection);
                    imie9.Text = sqlComm.ToString();
                    imie9.Text = dataAdapter.ToString();
                    nazwisko9.Visible = true;
                    imie9.Visible = true;
                }
                else if(nazwisko10.Text == "")
                {
                    nazwisko10.Text = uzytkownicy.SelectedItem.ToString();
                    sqlComm = new SqlCommand("SELECT Imie AS Imie FROM UZYTKOWNICY WHERE Nazwisko = " + "'" + uzytkownicy.SelectedItem.ToString() + "'", connection);
                    imie10.Text = sqlComm.ToString();
                    imie10.Text = dataAdapter.ToString();
                    nazwisko10.Visible = true;
                    imie10.Visible = true;
                }
            }
        }
        
        private void cancelTeam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerTeam_Click(object sender, EventArgs e)
        {
            string comm = "exec dbo.dodajDruzyne '" + teamName + "', '" + imie1 + "', '" + nazwisko1; // problem z nazwisko1 i wszystkimi imionami
            SqlCommand sqlcomm = new SqlCommand(comm, connection);
            sqlcomm.ExecuteNonQuery();
            this.Close();
        }

        private void DodajDruzyne_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.changeOpenedWindow();
        }
    }
}
