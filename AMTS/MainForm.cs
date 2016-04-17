using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMTS
{
    public partial class MainForm : Form
    {
        SqlConnection connection;
        string LoggedIn = "Gość";
        string connectionString;
        bool openedWindow = false; //obejscie zapobiegające wyświetleniu kilku okienek

        public MainForm()
        {
       //     connectionString = "Server=PATRYK\\SQLEXPRESSAWPAT;Database=AMTS;Trusted_Connection=true";
            //connectionString = "Server = KLAUDIA_PC\\SQLEXPRESS; Database=AMTS; Trusted_Connection = true";
           // connection = new SqlConnection(connectionString);
         //   connection.Open();
            InitializeComponent();
        }

        public MainForm(string server)
        {
            connectionString = server;
            connection = new SqlConnection(connectionString);
            connection.Open();
            InitializeComponent();
            druzynaLabel.Visible = false;
            teamLabel.Visible = false;
            logOutButton.Visible = false;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (openedWindow == false)
            {
                LogInForm logIn = new LogInForm(connection, this);
                changeOpenedWindow();
                logIn.Visible = true;
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoggedIn = "Gość";
            LoggedInAsLabel.Text = LoggedIn;
            logInButton.Visible = true;
            logOutButton.Visible = false;
            registerButton.Visible = true;
            druzynaLabel.Visible = false;
            teamLabel.Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (openedWindow == false)
            {
                RegisterForm register = new RegisterForm(connection, this);
                changeOpenedWindow();
                register.Visible = true;
            }
        }

        public void changeOpenedWindow()
        {
            openedWindow = !openedWindow;
        }

        public void successfulLogIn(string str)
        {
            LoggedIn = str;
            LoggedInAsLabel.Text = LoggedIn;
            logInButton.Visible = false;
            logOutButton.Visible = true;
            registerButton.Visible = false;

            SqlCommand sqlcomm = new SqlCommand("SELECT Druzyna AS TEAM FROM UZYTKOWNICY WHERE Mail=" + "'" + LoggedIn + "'", connection);
            string DBteam = "BRAK";
            SqlDataReader r = sqlcomm.ExecuteReader();
            if (r.Read())
            {
                Object team = r["TEAM"];
                if(DBNull.Value != team)
                    DBteam = team.ToString();
            }
            r.Close();
            teamLabel.Text = DBteam;
            druzynaLabel.Visible = true;
            teamLabel.Visible = true;
        }

        private void registerTeam_Click(object sender, EventArgs e)
        {
            if(openedWindow == false)
            {
                if(LoggedIn == "Gość")
                    niezalogowany.Visible = true;
                else
                {
                    niezalogowany.Visible = false;
                    LogInForm logIn = new LogInForm(connection, this);
                    changeOpenedWindow();
                    DodajDruzyne dodaj = new DodajDruzyne(connection, this);
                    dodaj.Visible = true;
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
