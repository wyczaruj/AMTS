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
                string osoba = dataRow["Nazwisko"].ToString() + " " + dataRow["Imie"].ToString();
                spisOsob.Items.Add(osoba);
                osoby.Add(osoba);
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
                string command = "exec dbo.usunUzytkownika '" +nazwiskoImie[1] +"', '" +nazwiskoImie[0] +"'";
                SqlCommand sqlcomm = new SqlCommand(command, conn);
                sqlcomm.ExecuteNonQuery();
                this.Close();
            }
        }
    }
}
