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
            server = "Server=tcp:alts.database.windows.net,1433;Data Source=alts.database.windows.net;Initial Catalog=ALTS;Persist Security Info=False;User ID=patrykvan;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Password=";
        }

        private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = false;
            startPWButton.Visible = false;
            startButton.Visible = true;
            switch (serverComboBox.Text)
            {
                case "KLAUDIA_PC":
                    server = "Server = KLAUDIA_PC\\SQLEXPRESS; Database = AMTS; Trusted_Connection = true;MultipleActiveResultSets=True";
                    break;
                case "KLAUDIA_LAPTOP":
                    server = "Server = KOMPUTER\\SQLEXPRESSS; Database = AMTS; Trusted_Connection = true;MultipleActiveResultSets=True";
                    break;
                case "PATRYK":
                    server = "Server=PATRYK\\SQLEXPRESSAWPAT;Database=AMTS;Trusted_Connection=true;MultipleActiveResultSets=True";
                    break;
                case "PATRYKS":
                    server = "Server=DESKTOP-I5KKVD2\\SQLEXPRESSPAT;Database=AMTS;Trusted_Connection=true;MultipleActiveResultSets=True";
                    break;
                case "DOROTA":
                    server = "Data Source=ZWIERZYNIEC;Initial Catalog=AMTS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True";
                    break;
                case "ALTS":
                    startPWButton.Visible = true;
                    startButton.Visible = false;
                    passwordTextBox.Enabled = true;
                    server = "Server=tcp:alts.database.windows.net,1433;Data Source=alts.database.windows.net;Initial Catalog=ALTS;Persist Security Info=False;User ID=patrykvan;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Password=";
                    server += passwordTextBox.Text;
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm(server);
            this.Hide();
            MF.Visible = true;
        }

        private void startPWButton_Click(object sender, EventArgs e)
        {
            server += passwordTextBox.Text;
            MainForm MF = new MainForm(server);
            this.Hide();
            MF.Visible = true;
        }
    }
}
