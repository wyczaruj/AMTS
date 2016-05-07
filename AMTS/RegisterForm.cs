using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AMTS
{
    public partial class RegisterForm : AbstractForm
    {
        MainForm mainForm;
        SqlConnection connection;
        bool accept = false;
        
        public RegisterForm() { }
        public RegisterForm(SqlConnection conn, MainForm f1)
        {
            mainForm = f1;
            connection = conn;
            InitializeComponent();
            //this.ControlBox
        }

        private void TextBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerButton.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void regulaminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regulamin regulamin = new Regulamin(false, this);
            regulamin.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            incorrectName.Visible = false;
            incorrectMail.Visible = false;
            incorrectLastName.Visible = false;
            incorrectPassword.Visible = false;
            incorrectPESEL.Visible = false;
            incorrectPhone.Visible = false;
            MailTaken.Visible = false;
            nameTaken.Visible = false;
            PESELTaken.Visible = false;
            acceptCheckBox.ForeColor = Color.Black;
            accLabel.ForeColor = Color.Black;

            string imie = imieTextBox.Text;
            string nazwisko = nazwiskoTextBox.Text;
            string telefon = telefonTextBox.Text;
            string email = mailTextBox.Text;
            string haslo = hasloTextBox.Text;
            string pesel = PESELTextBox.Text;
            bool error = false;

            string expr = "([A-Z][a-z]+)";
            if (check(imie, expr) == false)
            {
                incorrectName.Visible = true;
                error = true;
            }

            if (check(nazwisko, expr) == false)
            {
                incorrectLastName.Visible = true;
                error = true;
            }

            if (haslo.Equals(""))
            {
                incorrectPassword.Visible = true;
                error = true;
            }

            expr = "\\d{9}";
            if (!telefon.Equals(""))
            {
                if (check(telefon, expr) == false)
                {
                    incorrectPhone.Visible = true;
                    error = true;
                }
            }

            expr = "\\d{11}";
            if (check(pesel, expr) == false)
            {
                incorrectPESEL.Visible = true;
                error = true;
            }
            expr = "[A-z]+@[A-z]+\\.[A-z]+";
            if (check(email, expr) == false)
            {
                incorrectMail.Visible = true;
                error = true;
            }

            if (error == false)
            {
                SqlCommand sqlcomm = new SqlCommand("SELECT Mail AS EMAIL FROM UZYTKOWNICY WHERE Mail=" + "'" + email + "'", connection);
                SqlDataReader r = sqlcomm.ExecuteReader();
                if (r.Read())
                {
                    MailTaken.Visible = true;
                    error = true;
                }
                r.Close();

                sqlcomm = new SqlCommand("SELECT Imie AS NAME, Nazwisko AS SURNAME FROM UZYTKOWNICY WHERE Imie=" + "'" + imie + "' AND Nazwisko='" + nazwisko + "'", connection);
                r = sqlcomm.ExecuteReader();
                if (r.Read())
                {
                    nameTaken.Visible = true;
                    error = true;
                }
                r.Close();

                sqlcomm = new SqlCommand("SELECT PESEL AS PSL FROM UZYTKOWNICY WHERE PESEL=" + "'" + pesel + "'", connection);
                r = sqlcomm.ExecuteReader();
                if (r.Read())
                {
                    PESELTaken.Visible = true;
                    error = true;
                }
                r.Close();
            }

            if (acceptCheckBox.Checked == false)
            {
                error = true;
                acceptCheckBox.ForeColor = Color.Red;
                accLabel.ForeColor = Color.Red;
            }

            if (error == false)
            {
                string command = "exec dbo.rejestruj '" + imie + "', '" + nazwisko + "', '" + pesel + "', '" + email + "',";
                if (telefon.Equals(""))
                    command += "null , '" + haslo + "'";
                else
                    command += "'" + telefon + "', '" + haslo + "'";
                SqlCommand sqlcomm = new SqlCommand(command, connection);
                sqlcomm.ExecuteNonQuery();
                mainForm.successfulLogIn(email);
                this.Close();
            }
        }

        private bool check(string str, string expr)
        {
            if (str.Equals(""))
            {
                return false;
            }
            else
            {
                MatchCollection mc = Regex.Matches(str, expr);
                if (mc.Count == 0)
                    return false;
                if (mc[0].ToString().Equals(str))
                {
                    return true;
                }
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            accept = acceptCheckBox.Checked;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }
    }
}
