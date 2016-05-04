﻿using System;
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
    public partial class Terminarz:Form
    {
        bool openedWindow = false;
        SqlConnection conn;

        public Terminarz(SqlConnection connection, bool admin)
        {
            InitializeComponent();
            conn = connection;
            if(admin)
            {
                termOpt.Visible = true;
                termAdd.Visible = true;
                termEdit.Visible = true;
            }
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAd = new SqlDataAdapter("SELECT * FROM TERMINARZ ORDER BY Data", connection);
            SqlCommandBuilder command = new SqlCommandBuilder(dataAd);
            dataAd.Fill(dataSet, "TERMINARZ");
            terminarzDataGridView.DataSource = dataSet.Tables["TERMINARZ"];
            terminarzDataGridView.ReadOnly = true;
        }

        private void termAdd_Click(object sender, EventArgs e)
        {
            if(openedWindow == false)
            {
                TerminNowy nowy = new TerminNowy(conn);
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

        private void saveEdit_Click(object sender, EventArgs e)
        {
            
            terminarzDataGridView.ReadOnly = true;
        }

        private void discardEdit_Click(object sender, EventArgs e)
        {
            saveEdit.Visible = false;
            discardEdit.Visible = false;
            terminarzDataGridView.ReadOnly = true;
        }

        
    }
}