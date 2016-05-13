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
        }

        private void generator_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            save.Visible = true;
            discard.Visible = true;
            label1.Visible = true;

            for(int i=1; i<=druzyny.Count; i++)
            {
                dataGridView1.Rows.Add(i, "RRRR-MM-DD");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            save.Visible = false;
            discard.Visible = false;
            label1.Visible = false;
        }

        private void discard_Click(object sender, EventArgs e)
        {
            save.Visible = false;
            discard.Visible = false;
            label1.Visible = false;
            dataGridView1.Rows.Clear();
        }
    }
}
