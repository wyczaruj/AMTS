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
    public partial class Zbanuj: AbstractForm
    {
        SqlConnection conn;
        AbstractForm mainForm;
        DataSet dataSet;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;

        public Zbanuj(SqlConnection connection, AbstractForm MF)
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
    }
}
