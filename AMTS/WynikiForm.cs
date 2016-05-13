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
    public partial class WynikiForm : AbstractForm
    {
        private SqlConnection connection;
        private MainForm mainForm;
        DataSet dataSet;
        SqlDataAdapter dataAd;
        SqlDataAdapter data;

        public WynikiForm()
        {
            InitializeComponent();
        }

        public WynikiForm(SqlConnection connection, MainForm mainForm, bool admin)
        {
            InitializeComponent();
            this.connection = connection;
            this.mainForm = mainForm;
            dataSet = new DataSet();
            dataAd = new SqlDataAdapter("SELECT * FROM wynik ORDER BY R", connection);
            SqlCommandBuilder command = new SqlCommandBuilder(dataAd);
            dataAd.Fill(dataSet, "WYNIKI");
            dataGridView1.DataSource = dataSet.Tables["WYNIKI"];
            dataGridView1.ReadOnly = true;
            if (!admin)
            {
                edit.Visible = false;
                discard.Visible = false;
                save.Visible = false;
            }
            comboBox1.Items.Add(" ");
            SqlCommand com = new SqlCommand("select distinct R from wynik", connection);
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetInt32(0));
                }
            }
            reader.Close();
        }

        private void WynikiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMTSDataSet.wynik' table. You can move, or remove it, as needed.
            this.wynikTableAdapter.Fill(this.aMTSDataSet.wynik);

        }

        private void WynikiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataSet.Clear();
            if(comboBox1.SelectedItem.ToString().Equals(" "))
            {
                dataAd.Fill(dataSet, "WYNIKI");
                dataGridView1.DataSource = dataSet.Tables["WYNIKI"];
            }
            else
            {
                data = new SqlDataAdapter("select * from dbo.wynikirundy(" + comboBox1.SelectedItem + ")", connection);
                SqlCommandBuilder com = new SqlCommandBuilder(data);
                data.Fill(dataSet, "WYNIKI");
                dataGridView1.DataSource = dataSet.Tables["WYNIKI"];
            }
        }
    }
}
