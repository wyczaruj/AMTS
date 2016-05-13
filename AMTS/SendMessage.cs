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
    public partial class SendMessage : Form
    {
        Messages messagesForm;
        SqlConnection connection;
        private string messageSender;

        public SendMessage()
        {
            InitializeComponent();
        }

        public SendMessage(SqlConnection conn, Messages mess, User user)
        {
            connection = conn;
            messagesForm = mess;
            messageSender = user.getEmail();
            InitializeComponent();

        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            string error = "";
            string subject = "";
            string message = "";
            string recipient = "";
            subject = subjectTextBox.Text;
            message = messageTextBox.Text;
            if (subject.Equals(""))
                error += "Wpisz tematu\n";
            if (message.Equals("Wpisz wiadomość")) ;
            if (!error.Equals(""))
            {
                MessageBox.Show(error);
            }
            else
            {
                string command = "exec dbo.wyslijWiadomosc '" + messageSender + "', '" + recipient + 
                    "', '" + subject + "', '" + message + "',";
                SqlCommand sqlcomm = new SqlCommand(command, connection);
                sqlcomm.ExecuteNonQuery();
                this.Close();
            }
        }

        private void SendMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            messagesForm.changeOpenedWindow();
        }
    }
}
