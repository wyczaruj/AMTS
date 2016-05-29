using AMTS.Data;
using AMTS.Properties;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace AMTS
{
    public partial class MainForm : AbstractForm
    {
        SqlConnection connection;
        bool LoggedIn = false;
        bool AdminLogged = false; //bo sam LoggedIn to za mało by rozróżniać co może użytkownik, a co gość, a co admin
        User LoggedInUser;
        string connectionString;
      
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
            loggedInAsLabel.Text = "Gość";
            logInButton.Visible = true;
            logOutButton.Visible = false;
            registerButton.Visible = true;
            druzynaLabel.Visible = false;
            teamLabel.Visible = false;
            confirmConfirmationButton.Visible = false;
            myRegistrationButton.Visible = false;
            messagesButton.Visible = false;
            panelAdmina.Visible = false;
            usunUzyt.Visible = false;
            usunDruz.Visible = false;
            zbanuj.Visible = false;
            panelDruzyny.Visible = false;
            zarzadzajDruzyna.Visible = false;
            loggedInAs.Visible = false;
            loggedInAsLabel.Visible = false;
            admin.Visible = false;
            kapitan.Visible = false;
            gosc.Visible = true;
            brakDruzyny.Visible = false;

            messagesButton.Image = Resources.greyMailImage;

            if (messageBackgroundWorker.IsBusy)
            {
                messageBackgroundWorker.CancelAsync();
            }
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
            panelDruzyny.Visible = true;
            loggedInAs.Visible = true;
            loggedInAsLabel.Visible = true;
            gosc.Visible = false;

            if(LoggedInUser.getPendingConfirmation())
                confirmConfirmationButton.Visible = true;

            loggedInAsLabel.Text = mail;

            string DBteam = "";
            brakDruzyny.Visible = true;
            if (LoggedInUser.getHasTeam())
            {
                registerTeamButton.Visible = false;
                DBteam = LoggedInUser.getTeamName();
                brakDruzyny.Visible = false;
                if (LoggedInUser.isCaptain())
                {
                    kapitan.Visible = true;
                    zarzadzajDruzyna.Visible = true;
                }
            }
            if (LoggedInUser.getPendingTeamRequest())
            {
                myRegistrationButton.Visible = true;
                registerTeamButton.Visible = false;
                confirmConfirmationButton.Visible = false;
                brakDruzyny.Visible = false;
                DBteam = LoggedInUser.getTeamName() + " [NIEZATWIERDZONA]";
                if (LoggedInUser.isCaptain())
                {
                    kapitan.Visible = true;
                }
            }
            teamLabel.Text = DBteam;
            druzynaLabel.Visible = true;
            teamLabel.Visible = true;
            messagesButton.Visible = true;
            if (!messageBackgroundWorker.IsBusy)
            {
                messageBackgroundWorker.RunWorkerAsync();
            }
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
            messagesButton.Visible = true;
            LoggedInUser = new User(connection, mail);
            loggedInAs.Visible = true;
            loggedInAsLabel.Visible = true;
            gosc.Visible = false;
            loggedInAsLabel.Text = mail;
            admin.Visible = true;
            if (!messageBackgroundWorker.IsBusy)
            {
                messageBackgroundWorker.RunWorkerAsync();
            }
            usunUzyt.Visible = true;
            usunDruz.Visible = true;
            zbanuj.Visible = true;
            panelAdmina.Visible = true;
        }

        private void terminarzButton_Click(object sender, EventArgs e)
        {
            if (openedWindow == false)
            {
                Terminarz terminarz = new Terminarz(connection, AdminLogged, this);
                changeOpenedWindow();
                terminarz.Visible = true;
            }
        }

        private void regulaminButton_Click(object sender, EventArgs e)
        {
            if (openedWindow == false)
            {
                Regulamin regulamin = new Regulamin(AdminLogged, this);
                changeOpenedWindow();
                regulamin.Visible = true;
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

        private void klasyfikacjaButton_Click(object sender, EventArgs e)
        {
            if(openedWindow == false)
            {
                Klasyfikacja klasyfikacja = new Klasyfikacja(connection, this);
                changeOpenedWindow();
                klasyfikacja.Visible = true;
            }
        }

        private void wynikiButton_Click(object sender, EventArgs e)
        {
            if(openedWindow == false)
            {
                WynikiForm wyniki = new WynikiForm(connection, this, AdminLogged);
                changeOpenedWindow();
                wyniki.Visible = true;
            }
        }

        private void messagesButton_Click(object sender, EventArgs e)
        {
            if (openedWindow == false)
            {
                LoggedInUser = new User(connection, LoggedInUser.getEmail());
                Messages messages = new Messages(connection, this, LoggedInUser,  AdminLogged);
                changeOpenedWindow();
                changeMessageStatus();
                messages.Visible = true;
                
            }
        }

        private void changeMessageStatus()
        {
            messagesButton.Image = Resources.greyMailImage;
            string command = "exec dbo.wiadomoscPrzeczytana '" + LoggedInUser.getEmail() + "'";
            SqlCommand sqlcomm = new SqlCommand(command, connection);
            sqlcomm.ExecuteNonQuery();
        }

        private void messageBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string command = "Select Wiadomosc from UZYTKOWNICY WHERE Wiadomosc = 1 AND Mail ='" + LoggedInUser.getEmail() + "'";
            SqlCommand sqlcomm;
            SqlDataReader r;
            while (true)
            {
                Thread.Sleep(5000);
                sqlcomm = new SqlCommand(command, connection);
                r = sqlcomm.ExecuteReader();
                if (r.Read())
                    messageBackgroundWorker.ReportProgress(1);
                r.Close();
                
                if (messageBackgroundWorker.CancellationPending)
                {
                    e.Cancel = true;                    
                    return;
                }
            }
        }

        private void messageBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            messagesButton.Image = Resources.newMailImage;
        }

        private void usunUzyt_Click(object sender, EventArgs e)
        {
            UsunOsobe usunOs = new UsunOsobe(connection, this);
            changeOpenedWindow();
            usunOs.Visible = true;
        }

        private void usunDruz_Click(object sender, EventArgs e)
        {
            UsunDruzyne usunDruz = new UsunDruzyne(connection, this);
            changeOpenedWindow();
            usunDruz.Visible = true;
        }

        private void facebook_LinkClicked(object sender, EventArgs e)
        {
            ProcessStartInfo link = new ProcessStartInfo("https://www.facebook.com/pages/Miejski-O%C5%9Brodek-Sportu-i-Rekreacji-w-O%C5%9Bwi%C4%99cimiu/104461466356564?ref=hl");
            Process.Start(link);
        }

        private void twitter_LinkClicked(object sender, EventArgs e)
        {
            ProcessStartInfo link = new ProcessStartInfo("https://twitter.com/");
            Process.Start(link);
        }

        private void instagram_LinkClicked(object sender, EventArgs e)
        {
            ProcessStartInfo link = new ProcessStartInfo("https://www.instagram.com/");
            Process.Start(link);
        }

        private void youtube_LinkClicked(object sender, EventArgs e)
        {
            ProcessStartInfo link = new ProcessStartInfo("https://www.youtube.com/");
            Process.Start(link);
        }

        private void googleplus_LinkClicked(object sender, EventArgs e)
        {
            ProcessStartInfo link = new ProcessStartInfo("https://plus.google.com/");
            Process.Start(link);
        }
    }
}
