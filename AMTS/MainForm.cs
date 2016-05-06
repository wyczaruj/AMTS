using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMTS
{
    public partial class MainForm : Form
    {
        SqlConnection connection;
        bool LoggedIn = false;
        bool AdminLogged = false; //bo sam LoggedIn to za mało by rozróżniać co może użytkownik, a co gość, a co admin
        User LoggedInUser;
        string connectionString;
        bool openedWindow = false; //obejscie zapobiegające wyświetleniu kilku okienek

        public MainForm()
        {
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
            teamRegistrationsButton.Visible = false;
            numberOfTeamRegistrationsLabel.Visible = false;
            registerTeamButton.Visible = true;
            LoggedIn = false;
            AdminLogged = false;
            LoggedInUser = null;
            LoggedInAsLabel.Text = "Gość";
            logInButton.Visible = true;
            logOutButton.Visible = false;
            registerButton.Visible = true;
            druzynaLabel.Visible = false;
            teamLabel.Visible = false;
            confirmConfirmationButton.Visible = false;
            myRegistrationButton.Visible = false;
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

        public void successfulLogIn(string mail)
        {
            LoggedIn = true;
            logInButton.Visible = false;
            logOutButton.Visible = true;
            myRegistrationButton.Visible = false;
            registerButton.Visible = false;
            niezalogowany.Visible = false;
            registerTeamButton.Visible = true;
            LoggedInUser = new User(connection, mail);

            if(LoggedInUser.getPendingConfirmation())
                confirmConfirmationButton.Visible = true;

            LoggedInAsLabel.Text = mail;

            string DBteam = "BRAK";
            if (LoggedInUser.getHasTeam())
            {
                registerTeamButton.Visible = false;
                DBteam = LoggedInUser.getTeamName();
                if (LoggedInUser.isCaptain())
                {
                    DBteam += "\n[KAPITAN]";
                }
            }
            if (LoggedInUser.getPending())
            {
                myRegistrationButton.Visible = true;
                registerTeamButton.Visible = false;
                confirmConfirmationButton.Visible = false;
                DBteam = LoggedInUser.getTeamName() + " [NIEZATWIERDZONA]";
                if (LoggedInUser.isCaptain())
                {
                    DBteam += "\n[KAPITAN]";
                }
            }
            teamLabel.Text = DBteam;
            druzynaLabel.Visible = true;
            teamLabel.Visible = true;
        }

        public void successfulTeamRegistration(string teamName)
        {
            teamLabel.Text = teamName + " [NIEZATWIERDZONA]\n[KAPITAN]";
            successfulLogIn(LoggedInUser.getEmail());
        }

        private void registerTeam_Click(object sender, EventArgs e)
        {
            if (openedWindow == false)
            {
                if (!LoggedIn)
                    niezalogowany.Visible = true;
                else
                {
                    changeOpenedWindow();
                    DodajDruzyne dodaj = new DodajDruzyne(connection, this, LoggedInUser);
                    dodaj.Visible = true;
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void teamRegistrationsButton_Click(object sender, EventArgs e)
        {
            if(openedWindow == false)
            {
                changeOpenedWindow();
                TeamRegistrations TR = new TeamRegistrations(connection, this);
                TR.Visible = true;
            }
        }

        public void successfulAdminLogin(string mail)
        {
            LoggedIn = true;
            AdminLogged = true;
            logInButton.Visible = false;
            logOutButton.Visible = true;
            registerButton.Visible = false;
            niezalogowany.Visible = false;
            registerTeamButton.Visible = false;
            teamRegistrationsButton.Visible = true;

            LoggedInAsLabel.Text = mail + " [ADMIN]";
        }

        private void terminarz_Click(object sender, EventArgs e)
        {
            if(openedWindow == false)
            {
                Terminarz terminarz = new Terminarz(connection, AdminLogged, this);
                changeOpenedWindow();
                terminarz.Visible = true;
            }
        }

        private void myRegistrationButton_Click(object sender, EventArgs e)
        {
            if (openedWindow == false)
            {
                changeOpenedWindow();
                MyTeamRegistration MTR = new MyTeamRegistration(LoggedInUser, connection, this);
                MTR.Visible = true;
            }
        }

        private void confirmConfirmationButton_Click(object sender, EventArgs e)
        {
            if (openedWindow == false)
            {
                changeOpenedWindow();
                Confirmation conf = new Confirmation(connection, this, LoggedInUser);
                conf.Visible = true;
            }
        }

        public void successfulConfirmation()
        {
            LoggedInUser.refreshData(connection);
            registerTeamButton.Visible = false;
            confirmConfirmationButton.Visible = false;
            myRegistrationButton.Visible = true;
        }
    }
}
