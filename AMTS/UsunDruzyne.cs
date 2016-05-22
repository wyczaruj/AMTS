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
    public partial class UsunDruzyne: AbstractForm
    {
        SqlConnection conn;
        AbstractForm mainForm;
        DataSet dataSet;
        SqlDataAdapter dataAdapter;
        SqlCommandBuilder commandBuilder;

        public UsunDruzyne(SqlConnection connection, AbstractForm MF)
        {
            mainForm = MF;
            conn = connection;
            InitializeComponent();
            dataAdapter = new SqlDataAdapter("SELECT Nazwa FROM DRUZYNY", conn);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "DRUZYNY");
            List<string> druzyny = new List<string>();

            foreach(DataRow dataRow in dataSet.Tables["DRUZYNY"].Rows)
            {
                string druzyna = dataRow["Nazwa"].ToString();
                spisDruzyn.Items.Add(druzyna);
                druzyny.Add(druzyna);
                string[] list = druzyny.ToArray<string>();
                var autoComplete = new AutoCompleteStringCollection();
                autoComplete.AddRange(druzyny.ToArray());
                spisDruzyn.AutoCompleteCustomSource = autoComplete;
            }
        }

        private void usuwanie_Click(object sender, EventArgs e)
        {
            DialogResult choose = MessageBox.Show("Czy na pewno chcesz usunąć tę drużynę?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(choose == DialogResult.Yes)
            {
                string command = "exec dbo.usunDruzyne '" + spisDruzyn.SelectedItem.ToString() + "'";
                SqlCommand sqlcomm = new SqlCommand(command, conn);
                sqlcomm.ExecuteNonQuery();
                this.Close();
            }
        }
    }
}
