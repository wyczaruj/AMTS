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
        public Terminarz(SqlConnection connection, bool admin, AbstractForm MF)
        {
            mainForm = MF;
            InitializeComponent();
            conn = connection;
            label1.Visible=false;
            label2.Visible = false;
            label3.Visible = false;
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
                

            }
            if (noChanges)
            {
                label2.Visible = true;
                dataSet.Clear();
                dataAd.Fill(dataSet, "TERMINARZ");
                terminarzDataGridView.DataSource = dataSet.Tables["TERMINARZ"];

            }else
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
    }
}