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
    public partial class TerminNowy:Form
    {
        Terminarz terminarz;
        private System.Data.SqlClient.SqlConnection conn;
        void HandleSqlException(SqlException e)
        {

            int num1 = (int)MessageBox.Show("Formularz został błędnie wypełniony.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }
        public TerminNowy(System.Data.SqlClient.SqlConnection conn, Terminarz terminarz)
        {
            InitializeComponent();
            this.conn = conn;
            this.terminarz = terminarz;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Nazwa FROM DRUZYNY", conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow r in dataTable.Rows)
            {
                comboBoxDruzyna.Items.Add(r["Nazwa"].ToString());
                comboBoxPrzeciwnik.Items.Add(r["Nazwa"].ToString());
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string data = dateTimePicker1.Text;
                string runda = numericRunda.Text;
                string druzyna1 = comboBoxDruzyna.Text;
                string druzyna2 = comboBoxPrzeciwnik.Text;
                string duzePunkty1 = numericDuzeDruzyny.Text;
                string duzePunkty2 = numericDuzePrzeciwnika.Text;
                string malePunkty1 = numericMaleDruzyny.Text;
                string malePunkty2 = numericMalePrzeciwnika.Text;

                if (druzyna1.Equals("")) druzyna1 = "null";
                if (druzyna2.Equals("")) druzyna2 = "null";
                if (duzePunkty1.Equals("")) duzePunkty1 = "null";
                if (duzePunkty2.Equals("")) duzePunkty2 = "null";
                if (malePunkty1.Equals("")) malePunkty1 = "null";
                if (malePunkty2.Equals("")) malePunkty2 = "null";

                string command = "exec dbo.dodajSpotkanie '" + data + "' ,'" + Int32.Parse(runda) + "', '" + druzyna1 + "', '" + druzyna2 + "', '" + Int32.Parse(duzePunkty1) + "', '" + Int32.Parse(duzePunkty2) + "', '" + Int32.Parse(malePunkty1) + "', '" + Int32.Parse(malePunkty2) + "'";
                SqlCommand sqlcomm = new SqlCommand(command, conn);
                sqlcomm.ExecuteNonQuery();
                this.Close();
            }
            catch (SqlException ex)
            {
                HandleSqlException(ex);
            }
        }

        private void discard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TerminNowy_FormClosed(object sender, FormClosedEventArgs e)
        {
            terminarz.changeOpenedWindow();
        }
    }
}
