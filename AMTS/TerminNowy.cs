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
        private System.Data.SqlClient.SqlConnection conn;

        public TerminNowy(System.Data.SqlClient.SqlConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string data = dataBox.Text;
            string runda = rundaBox.Text;
            string druzyna1 = druzyna1Box.Text;
            string druzyna2 = druzyna2Box.Text;
            string duzePunkty1 = duzePunkty1Box.Text;
            string duzePunkty2 = duzePunkty1Box.Text;
            string malePunkty1 = malePunkty1Box.Text;
            string malePunkty2 = malePunkty2Box.Text;

            if(druzyna1.Equals("")) druzyna1 = "null";
            if(druzyna2.Equals("")) druzyna2 = "null";
            if(duzePunkty1.Equals("")) duzePunkty1 = "null";
            if(duzePunkty2.Equals("")) duzePunkty2 = "null";
            if(malePunkty1.Equals("")) malePunkty1 = "null";
            if(malePunkty2.Equals("")) malePunkty2 = "null";

            string command = "exec dbo.dodajSpotkanie '" + data + "' ,'" + Int32.Parse(runda) + "', '" + druzyna1 + "', '" + druzyna2 + "', '" + Int32.Parse(duzePunkty1) + "', '" + Int32.Parse(duzePunkty2) + "', '" + Int32.Parse(malePunkty1) + "', '" + Int32.Parse(malePunkty2) + "'";
            SqlCommand sqlcomm = new SqlCommand(command, conn);
            sqlcomm.ExecuteNonQuery();
            this.Close();
        }

        private void discard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
