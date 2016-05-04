using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMTS
{
    public partial class LogInForm : Form
    {
        MainForm mainForm;
        SqlConnection connection;

        public LogInForm(SqlConnection conn, MainForm f1)
        {
            connection = conn;
            mainForm = f1;
            InitializeComponent();
            incorrectLabel.Visible = false;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            //connect

            String email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            if (password.Equals(""))
                incorrectLabel.Visible = true;
            else {
                string DBpassword = "";

                SqlCommand sqlcomm = new SqlCommand("SELECT Haslo AS PASSWORD FROM HASLA WHERE Mail=" + "'" + email + "'", connection);
                SqlDataReader r = sqlcomm.ExecuteReader();
                if (r.Read())
                {
                    Object pw = r["PASSWORD"];
                    DBpassword = pw.ToString();
                }
                r.Close();

                if (!(DBpassword.Equals(password))) {
                    incorrectLabel.Visible = true;
                }
                else
                {
                    sqlcomm = new SqlCommand("SELECT Administrator AS ADMIN FROM UZYTKOWNICY WHERE Mail=" + "'" + email + "'", connection);
                    r = sqlcomm.ExecuteReader();
                    r.Read();
                    bool admin = (bool)r["ADMIN"];
                    r.Close();
                    if (admin)
                        mainForm.successfulAdminLogin(email);
                    else                    
                        mainForm.successfulLogIn(email);
                    this.Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logInButton.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }


        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }

        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            passwordTextBox_KeyDown(sender, e);
        }
    }
}
