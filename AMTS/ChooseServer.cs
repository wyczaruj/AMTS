using System;
using System.Windows.Forms;

namespace AMTS
{
    public partial class ChooseServer : Form
    {
        string server;
        public ChooseServer()
        {
            InitializeComponent();
        }

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            switch (serverComboBox.Text)
            {
                case "KLAUDIA_PC":
                    server = "Server = KLAUDIA_PC\\SQLEXPRESS; Database = AMTS; Trusted_Connection = true";
                    break;
                case "KLAUDIA_LAPTOP":
                    server = "Server = KOMPUTER\\SQLEXPRESSS; Database = AMTS; Trusted_Connection = true";
                    break;
                case "PATRYK":
                    server = "Server=PATRYK\\SQLEXPRESSAWPAT;Database=AMTS;Trusted_Connection=true";
                    break;
                case "PATRYKS":
                    server = "Server=DESKTOP-I5KKVD2\\SQLEXPRESSPAT;Database=AMTS;Trusted_Connection=true";
                    break;
                case "DOROTA":
                    server = "Data Source=ZWIERZYNIEC;Initial Catalog=AMTS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm(server);
            this.Hide();
            MF.Visible = true;
        }
    }
}
