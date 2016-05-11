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
    public partial class Terminarz:AbstractForm
    {
        SqlConnection conn;
        AbstractForm mainForm;
        DataSet dataSet;
        SqlDataAdapter dataAd;
        List<string> druzyny;
        public Terminarz(SqlConnection connection, bool admin, AbstractForm MF)
        {
            druzyny = new List<string>();
            mainForm = MF;
            InitializeComponent();
            conn = connection;
            label1.Visible=false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            if(admin)
            {
                termOpt.Visible = true;
                termAdd.Visible = true;
                termEdit.Visible = true;
                saveEdit.Visible = false;
                discardEdit.Visible = false;
            }
            dataSet = new DataSet();
            dataAd = new SqlDataAdapter("SELECT * FROM TERMINARZ ORDER BY Data", connection);
            SqlCommandBuilder command = new SqlCommandBuilder(dataAd);
            dataAd.Fill(dataSet, "TERMINARZ");
            terminarzDataGridView.DataSource = dataSet.Tables["TERMINARZ"];
            terminarzDataGridView.ReadOnly = true;
            SqlCommand com = new SqlCommand("SELECT * FROM TERMINARZ ORDER BY Data", connection);

            SqlDataReader reader = com.ExecuteReader();
                    
            if (reader.HasRows)
            {
                           while (reader.Read())
                            {
                                druzyny.Add(reader.GetString(0));
                            }
                        }
            reader.Close();
               

        }

        private void termAdd_Click(object sender, EventArgs e)
        {
            if(openedWindow == false)
            {
                TerminNowy nowy = new TerminNowy(conn, this);
                openedWindow = true;
                nowy.Visible = true;
            }     
        }

        private void termEdit_Click(object sender, EventArgs e)
        {
            saveEdit.Visible = true;
            discardEdit.Visible = true;
            terminarzDataGridView.ReadOnly = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

        }

        private void Terminarz_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }

        private void saveEdit_Click_1(object sender, EventArgs e)
        {
            DateTime something;
            int first;
            int second;
            int third;
            int fourth;
            bool noChanges = false;
            foreach (DataGridViewRow row in terminarzDataGridView.Rows)
            {
                if (!DateTime.TryParse(row.Cells[0].Value.ToString(), out something))
                {
                    noChanges = true;
                    label1.Visible = true;
                }
                if(!int.TryParse(row.Cells[1].Value.ToString(), out first))
                {
                    noChanges = true;
                    label3.Visible = true;

                }
                else
                {
                    if (first < 1)
                    {
                        noChanges = true;
                        label3.Visible = true;
                    }
                }
                int.TryParse(row.Cells[4].Value.ToString(), out first);
                int.TryParse(row.Cells[5].Value.ToString(), out second);
                int.TryParse(row.Cells[6].Value.ToString(), out third);
                int.TryParse(row.Cells[7].Value.ToString(), out fourth);
                
                if((first+second)!=3 && (first!=0 || second != 0))
                {
                    label4.Visible = true;
                    noChanges = true;
                }
                if (first > second)
                {
                    if(third <= fourth)
                    {
                        label4.Visible = true;
                        noChanges = true;
                    }
                }
                if (first < second)
                {
                    if (third >= fourth)
                    {
                        label4.Visible = true;
                        noChanges = true;
                    }
                }
                if(row.Cells[2].Value.Equals(row.Cells[3].Value) || !druzyny.Contains(row.Cells[2].Value) || !druzyny.Contains(row.Cells[3].Value))
                {
                    label5.Visible = true;
                    noChanges = true;
                }

            }
            if (noChanges)
            {
                label2.Visible = true;
                dataSet.Clear();
                dataAd.Fill(dataSet, "TERMINARZ");
                terminarzDataGridView.DataSource = dataSet.Tables["TERMINARZ"];


            }
            else
            {
                SqlCommandBuilder local_SqlCommandBuilder = new SqlCommandBuilder(dataAd);
                local_SqlCommandBuilder.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
                dataAd.UpdateCommand = local_SqlCommandBuilder.GetUpdateCommand();
                dataAd.Update(((System.Data.DataTable)this.terminarzDataGridView.DataSource));
            }
            terminarzDataGridView.ReadOnly = true;
            saveEdit.Visible = false;
            discardEdit.Visible = false;
        }

        private void discardEdit_Click_1(object sender, EventArgs e)
        {
            saveEdit.Visible = false;
            discardEdit.Visible = false;
            terminarzDataGridView.ReadOnly = true;
            dataSet.Clear();
            dataAd.Fill(dataSet, "TERMINARZ");
            terminarzDataGridView.DataSource = dataSet.Tables["TERMINARZ"];


        }
        public void actualize()
        {
            dataSet.Clear();
            dataAd.Fill(dataSet, "TERMINARZ");
            terminarzDataGridView.DataSource = dataSet.Tables["TERMINARZ"];
        }

        private void terminarzDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Nieprawidłowe dane");
            
        }
    }
}