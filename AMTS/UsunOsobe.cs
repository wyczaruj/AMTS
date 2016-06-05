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
    public partial class UsunOsobe: AbstractForm 
    {
        SqlConnection conn;
        AbstractForm mainForm;
        DataSet dataSet;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;

        public UsunOsobe(SqlConnection connection, AbstractForm MF)
        {
            mainForm = MF;
            conn = connection;
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("SELECT Nazwisko, Imie FROM UZYTKOWNICY", conn);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "UZYTKOWNICY");
            List<string> osoby = new List<string>();

            foreach(DataRow dataRow in dataSet.Tables["UZYTKOWNICY"].Rows)
            {
                string dane = dataRow["Nazwisko"].ToString() + " " + dataRow["Imie"].ToString();
                spisOsob.Items.Add(dane);
                osoby.Add(dane);
                string[] list = osoby.ToArray<string>();
                var autoComplete = new AutoCompleteStringCollection();
                autoComplete.AddRange(osoby.ToArray());
                spisOsob.AutoCompleteCustomSource = autoComplete;
            }
        }

        private void usuwanie_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Czy na pewno chcesz usunąć tego użytkownika?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(choose == DialogResult.Yes)
            {
                string[] nazwiskoImie = spisOsob.SelectedItem.ToString().Split(' ');
                string mail = "SELECT Mail FROM UZYTKOWNICY WHERE Nazwisko LIKE '" +nazwiskoImie[0] +"' AND Imie LIKE '" +nazwiskoImie[1] +"'";
                User osoba = new User(conn, mail);

                if(osoba.isCaptain())
                {
                    MessageBox.Show("Kapitanów drużyn można tylko blokować.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    SqlCommand sqlcomm;
                    string usunWiadomosci = "usunWiadomosci @mail";
                    sqlcomm = new SqlCommand(usunWiadomosci, conn);
                    sqlcomm.Parameters.Add("@mail", SqlDbType.VarChar, 30).Value = mail;
                    sqlcomm.ExecuteReader();
                    string usunUzytkownika = "exec dbo.usunUzytkownika '" + nazwiskoImie[1] + "', '" + nazwiskoImie[0] + "'";
                    sqlcomm = new SqlCommand(usunUzytkownika, conn);
                    sqlcomm.ExecuteReader();
                    this.Close();
                }
            }
        }

        private void UsunOsobe_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }
    }
}
