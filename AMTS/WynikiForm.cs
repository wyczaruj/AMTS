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
        List<string> druzyny;

        public WynikiForm()
        {
            InitializeComponent();
        }

        public WynikiForm(SqlConnection connection, MainForm mainForm, bool admin)
        {
            InitializeComponent();
            druzyny = new List<string>();
            zmiany.Visible = false;
            this.connection = connection;
            this.mainForm = mainForm;
            dataSet = new DataSet();
            dataAd = new SqlDataAdapter("SELECT * FROM wynik ORDER BY R", connection);
            SqlCommandBuilder command = new SqlCommandBuilder(dataAd);
            dataAd.Fill(dataSet, "WYNIKI");
            wyniki.DataSource = dataSet.Tables["WYNIKI"];
            wyniki.ReadOnly = true;
            if (!admin)
            {
                edit.Visible = false;
            }
            discard.Visible = false;
            save.Visible = false;
            runda.Items.Add(" ");
            SqlCommand com = new SqlCommand("select distinct R from wynik", connection);
            SqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    runda.Items.Add(reader.GetInt32(0));
                }
            }
            reader.Close();
            SqlCommand co = new SqlCommand("SELECT * FROM DRUZYNY", connection);

            SqlDataReader reade = co.ExecuteReader();

            if (reade.HasRows)
            {
                while (reade.Read())
                {
                    druzyny.Add(reade.GetString(0));
                }
            }
            reade.Close();
        }

        private void WynikiForm_Load(object sender, EventArgs e)
        {
            this.wynikTableAdapter.Fill(this.aMTSDataSet.wynik);

        }

        private void WynikiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataSet.Clear();
            if (runda.SelectedItem.ToString().Equals(" "))
            {
                dataAd.Fill(dataSet, "WYNIKI");
                wyniki.DataSource = dataSet.Tables["WYNIKI"];
            }
            else
            {
                data = new SqlDataAdapter("select * from dbo.wynikirundy(" + runda.SelectedItem + ")", connection);
                SqlCommandBuilder com = new SqlCommandBuilder(data);
                data.Fill(dataSet, "WYNIKI");
                wyniki.DataSource = dataSet.Tables["WYNIKI"];
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            discard.Visible = true;
            save.Visible = true;
            zmiany.Visible = false;
            wyniki.ReadOnly = false;
            wyniki.Columns[0].ReadOnly = true;
            wyniki.Columns[1].ReadOnly = true;
            wyniki.Columns[2].ReadOnly = true;
        }

        private void discard_Click(object sender, EventArgs e)
        {
            dataSet.Clear();
            if (runda.SelectedIndex > 0)
            {
                data = new SqlDataAdapter("select * from dbo.wynikirundy(" + runda.SelectedItem + ")", connection);
                SqlCommandBuilder com = new SqlCommandBuilder(data);
                data.Fill(dataSet, "WYNIKI");
                wyniki.DataSource = dataSet.Tables["WYNIKI"];
            }
            else
            {
                dataAd.Fill(dataSet, "WYNIKI");
                wyniki.DataSource = dataSet.Tables["WYNIKI"];
            }
            discard.Visible = false;
            save.Visible = false;
            wyniki.ReadOnly = true;
            zmiany.Visible = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            int first, second, third, fourth;
            bool noError = true;
            foreach (DataGridViewRow row in wyniki.Rows)
            {
                if (!int.TryParse(row.Cells[3].Value.ToString(), out first))
                {
                    zmiany.Visible = true;
                    noError = false;
                }
                if (!int.TryParse(row.Cells[4].Value.ToString(), out second))
                {
                    zmiany.Visible = true;
                    noError = false;
                }
                if (!int.TryParse(row.Cells[5].Value.ToString(), out third))
                {
                    zmiany.Visible = true;
                    noError = false;
                }
                if (!int.TryParse(row.Cells[6].Value.ToString(), out fourth))
                {
                    zmiany.Visible = true;
                    noError = false;
                }
                if (noError)
                {
                    if (first != 0 || second != 0 || third != 0 || fourth != 0)
                    {
                        if (first + second != 3)
                        {
                            noError = false;
                            zmiany.Visible = true;
                        }
                        else
                        {
                            if (first > second)
                            {
                                if (third <= fourth)
                                {
                                    noError = false;
                                    zmiany.Visible = true;
                                }
                            }
                            else
                            {
                                if (third >= fourth)
                                {
                                    noError = false;
                                    zmiany.Visible = true;
                                }
                            }
                        }
                    }
                }
            }
            if (noError)
            {
                int r;
                foreach (DataGridViewRow row in wyniki.Rows)
                {
                    int.TryParse(row.Cells[3].Value.ToString(), out first);
                    int.TryParse(row.Cells[4].Value.ToString(), out second);
                    int.TryParse(row.Cells[5].Value.ToString(), out third);
                    int.TryParse(row.Cells[6].Value.ToString(), out fourth);
                    int.TryParse(row.Cells[0].Value.ToString(), out r);
                    SqlCommand com = new SqlCommand("update wynik set D1=" + first + ", D2=" + second + ", M1 =" + third + ", M2 =" + fourth + " where Druzyna = '" + row.Cells[1].Value.ToString() + "' and Przeciwnik = '" + row.Cells[2].Value.ToString() + "' and R=" + r, connection);
                    com.ExecuteNonQuery(); 
                }
            }
            else
            {
                dataSet.Clear();
                if (runda.SelectedIndex > 0)
                {
                    data = new SqlDataAdapter("select * from dbo.wynikirundy(" + runda.SelectedItem + ")", connection);
                    SqlCommandBuilder com = new SqlCommandBuilder(data);
                    data.Fill(dataSet, "WYNIKI");
                    wyniki.DataSource = dataSet.Tables["WYNIKI"];
                }
                else
                {
                    dataAd.Fill(dataSet, "WYNIKI");
                    wyniki.DataSource = dataSet.Tables["WYNIKI"];
                }
            }
            discard.Visible = false;
            save.Visible = false;
            wyniki.ReadOnly = true;
        }
    }
}
