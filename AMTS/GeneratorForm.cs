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
    public partial class GeneratorForm : Form
    {
        private SqlConnection conn;
        private List<string> druzyny;
        private Terminarz terminarz;
        bool parz;
        int ile;

        public GeneratorForm()
        {
            InitializeComponent();
        }

        public GeneratorForm(Terminarz terminarz, List<string> druzyny, SqlConnection conn)
        {
            InitializeComponent();
            this.terminarz = terminarz;
            this.druzyny = druzyny;
            this.conn = conn;
            save.Visible = false;
            discard.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void GeneratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            terminarz.changeOpenedWindow();
            terminarz.actualize();
        }

        private void generator_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            save.Visible = true;
            discard.Visible = true;
            label1.Visible = true;
            label2.Visible = false;
            ile = druzyny.Count;
            if (druzyny.Count % 2 == 0)
            {
                parz = true;
            }else
            {
                parz = false;
                ile = druzyny.Count + 1;
            }
            for (int i = 1; i < ile; i++)
            {
                dataGridView1.Rows.Add(i, "RRRR-MM-DD");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            save.Visible = false;
            discard.Visible = false;
            label1.Visible = false;
            bool noErrors = true;
            DateTime some;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (!DateTime.TryParse(row.Cells[1].Value.ToString(), out some))
                {
                    noErrors = false;
                    label2.Visible = true;
                }
            }
            if (noErrors)
            {
                if (checkBox1.Checked)
                {
                    SqlCommand com = new SqlCommand("delete from TERMINARZ update Klasyfikacja set Duze_punkty = 0, Male_punkty = 0, Male_przegrane_punkty = 0", conn);
                    com.ExecuteNonQuery();
                }
                string[] druz= druzyny.ToArray();
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.CommandText = "exec dbo.dodajSpotkanie @data,@druz,@przeci,0,0,0,0,@r ";

                sqlcom.Connection = conn;

                //tu ustawki

                int[,,] pary = new int[ile - 1,ile/2,2];
                int w;
                for (int i = 1; i < ile; i++)
                {
                    if (i <= ile / 2)
                    {
                        pary[2 * i - 2,0,0] = i;
                        pary[2 * i - 2,0,1] = ile;
                        w = 2 * i - 2;
                    }
                    else
                    {
                        pary[2 * i - 1 - ile,0,1] = i;
                        pary[2 * i - 1 - ile,0,0] = ile;
                        w = 2 * i - 1 - ile;
                    }
                    int j = i + 1;
                    for (int k = 1; k <= ile - 2; k++)
                    {
                        if (j >= ile)
                        {
                            j = 1;
                        }
                        if (k <= (ile - 2) / 2)
                        {
                            pary[w,k,0] = j;
                        }
                        else
                        {
                            pary[w,ile - 1 - k,1] = j;
                        }
                        j++;
                    }
                }
                //end of it
                int iii = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    iii++;
                    for (int j = 1; j < (ile / 2); j++)
                    {
                        sqlcom.Parameters.Clear();
                        sqlcom.Parameters.Add("@r", SqlDbType.Int).Value = row.Cells[0].Value;
                        sqlcom.Parameters.Add("@data", SqlDbType.Date).Value = row.Cells[1].Value.ToString(); ;
                        sqlcom.Parameters.Add("@druz", SqlDbType.VarChar).Value = druz[pary[iii - 1,j,0]-1];
                        sqlcom.Parameters.Add("@przeci", SqlDbType.VarChar).Value = druz[pary[iii - 1,j,1]-1];
                        sqlcom.ExecuteNonQuery();
                    }
                    if (parz)
                    {
                        sqlcom.Parameters.Clear();
                        sqlcom.Parameters.Add("@r", SqlDbType.Int).Value = row.Cells[0].Value;
                        sqlcom.Parameters.Add("@data", SqlDbType.Date).Value = row.Cells[1].Value.ToString(); ;
                        sqlcom.Parameters.Add("@druz", SqlDbType.VarChar).Value = druz[pary[iii - 1,0,0]-1];
                        sqlcom.Parameters.Add("@przeci", SqlDbType.VarChar).Value = druz[pary[iii - 1,0,1]-1];
                        sqlcom.ExecuteNonQuery();
                    }
                }
            }
            dataGridView1.Rows.Clear();
        }

        private void discard_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            save.Visible = false;
            discard.Visible = false;
            label1.Visible = false;
            dataGridView1.Rows.Clear();
        }
    }
}
