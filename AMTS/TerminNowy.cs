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
    public partial class TerminNowy:AbstractForm
    {
        AbstractForm terminarz;
        private System.Data.SqlClient.SqlConnection conn;
       
        public TerminNowy(System.Data.SqlClient.SqlConnection conn, AbstractForm terminarz)
        {
            InitializeComponent();
            this.conn = conn;
            this.terminarz = terminarz;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Nazwa FROM DRUZYNY", conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            foreach (DataRow r in dataTable.Rows)
            {
                comboBoxDruzyna.Items.Add(r["Nazwa"].ToString());
                comboBoxPrzeciwnik.Items.Add(r["Nazwa"].ToString());
            }
            NoDruzyna.Visible = false;
            DwieTakieSameDruzyny.Visible = false;
            SumaDuzych.Visible = false;
            SumaMalych.Visible = false;

        }

        private void save_Click(object sender, EventArgs e)
        {
            NoDruzyna.Visible = false;
            DwieTakieSameDruzyny.Visible = false;
            SumaDuzych.Visible = false;
            SumaMalych.Visible = false;

  
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

            bool noError = true;
            if (comboBoxDruzyna.SelectedItem == null || comboBoxPrzeciwnik.SelectedItem == null)
            {
                noError = false;
                NoDruzyna.Visible = true;
            }
            if (druzyna1.Equals(druzyna2))
            {
                noError = false;
                DwieTakieSameDruzyny.Visible = true;
            }
            if (numericDuzeDruzyny.Value + numericDuzePrzeciwnika.Value != 3 && (numericDuzeDruzyny.Value != 0 || numericDuzePrzeciwnika.Value != 0) )
            {
                noError = false;
                SumaDuzych.Visible = true;
            }
            if(numericDuzeDruzyny.Value > numericDuzePrzeciwnika.Value)
            {
                if (numericMaleDruzyny.Value <= numericMalePrzeciwnika.Value)
                {
                    noError = false;
                    SumaMalych.Visible = true;
                }
            }else
            {
                if (numericMaleDruzyny.Value >= numericMalePrzeciwnika.Value)
                {
                    noError = false;
                    SumaMalych.Visible = true;
                }

            }
            if (noError)
            {
                SqlCommand sqlcomm = new SqlCommand();
                sqlcomm.CommandText = "exec dbo.dodajSpotkanie @data, @druzyna1, @druzyna2, @pkt1, @pkt2, @pkt3, @pkt4, @runda";
                sqlcomm.Parameters.Add("@data", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                sqlcomm.Parameters.Add("@runda", SqlDbType.Int).Value = runda;
                sqlcomm.Parameters.Add("@druzyna1", SqlDbType.VarChar).Value = druzyna1;
                sqlcomm.Parameters.Add("@druzyna2", SqlDbType.VarChar).Value = druzyna2;
                sqlcomm.Parameters.Add("@pkt1", SqlDbType.Int).Value = duzePunkty1;
                sqlcomm.Parameters.Add("@pkt2", SqlDbType.Int).Value = duzePunkty2;
                sqlcomm.Parameters.Add("@pkt3", SqlDbType.Int).Value = malePunkty1;
                sqlcomm.Parameters.Add("@pkt4", SqlDbType.Int).Value = malePunkty2;
                sqlcomm.Connection = conn;
                sqlcomm.ExecuteNonQuery();
                this.Close();
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
