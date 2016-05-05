using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMTS
{
    public partial class Regulamin : Form
    {
        RegisterForm form;
        public Regulamin(bool AdminLogged, RegisterForm form)
        {
            InitializeComponent();
            this.form = form;
            if (AdminLogged)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }


        private void Zamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Regulamin_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.changeOpenedWindow();
        }
    }
}
