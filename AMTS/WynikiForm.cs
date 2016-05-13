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

        public WynikiForm()
        {
            InitializeComponent();
        }

        public WynikiForm(SqlConnection connection, MainForm mainForm)
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
        }

        private void WynikiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMTSDataSet.wynik' table. You can move, or remove it, as needed.
            this.wynikTableAdapter.Fill(this.aMTSDataSet.wynik);

        }
    }
}
