using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AMTS
{
    public partial class Menage : AbstractForm
    {
        SqlConnection conn;
        AbstractForm mainForm;
        DataSet dataSet;
        SqlDataAdapter dataAd;
        User captain;
        public Menage(SqlConnection connection, AbstractForm MF, User cpt)
        {
            this.conn = connection;
            mainForm = MF;
            captain = cpt;
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            dataSet = new DataSet();
            dataAd = new SqlDataAdapter("  select Imie, Nazwisko, Mail, Telefon from dbo.UZYTKOWNICY where Druzyna like '"+captain.getTeamName()+"'", conn);
            SqlCommandBuilder com = new SqlCommandBuilder(dataAd);
            dataAd.Fill(dataSet, "Kontakty");

            dataGridView1.DataSource = dataSet.Tables["Kontakty"];
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
            dataGridView1.ReadOnly = true;
            dataSet.Clear();
            dataAd.Fill(dataSet, "Kontakty");
            dataGridView1.DataSource = dataSet.Tables["Kontakty"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool noChanges = false;
            string expr;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                expr = "\\d{9}";
                if (!row.Cells[3].Value.ToString().Equals(""))
                {
                    if (check(row.Cells[3].Value.ToString(), expr) == false)
                    {
                        noChanges = true;
                        label1.Visible = true;
                    }
                }

                expr = "[A-z]+@[A-z]+\\.[A-z]+";
                if (check(row.Cells[2].Value.ToString(), expr) == false)
                {
                    noChanges = true;
                    label2.Visible = true;
                }

                

            }
            if (noChanges)
            {
                label3.Visible = true;
                dataSet.Clear();
                dataAd.Fill(dataSet, "Kontakty");
                dataGridView1.DataSource = dataSet.Tables["Kontakty"];
            }
            else
            {
                SqlCommand com = new SqlCommand();
                SqlCommand com2 = new SqlCommand();
                SqlCommand com3 = new SqlCommand();
                SqlCommand b1 = new SqlCommand();
                SqlCommand b2 = new SqlCommand();
                SqlCommand e1 = new SqlCommand();
                SqlCommand e2 = new SqlCommand();
                com.CommandText = "update UZYTKOWNICY set Mail = @c, Telefon = @d where Imie like @a and Nazwisko like @b";
                com2.CommandText = "update HASLA set Mail = @c where Mail = @e";
                com3.CommandText = "select Mail from UZYTKOWNICY where Imie like @a and Nazwisko like @b";
                b1.CommandText = " alter table HASLA nocheck constraint all";
                b2.CommandText = "alter table UZYTKOWNICY nocheck constraint all";
                e1.CommandText = "ALTER TABLE HASLA WITH CHECK CHECK CONSTRAINT ALL";
                e2.CommandText = "ALTER TABLE UZYTKOWNICY WITH CHECK CHECK CONSTRAINT ALL";
                com.Connection = conn;
                com2.Connection = conn;
                com3.Connection = conn;
                b1.Connection = conn;
                b2.Connection = conn;
                e1.Connection = conn;
                e2.Connection = conn;
                b1.ExecuteNonQuery();
                b2.ExecuteNonQuery();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    com.Parameters.Clear();
                    com2.Parameters.Clear();
                    com3.Parameters.Clear();
                    com.Parameters.Add("@a", SqlDbType.VarChar).Value = row.Cells[0].Value;
                    com3.Parameters.Add("@a", SqlDbType.VarChar).Value = row.Cells[0].Value;
                    com.Parameters.Add("@b", SqlDbType.VarChar).Value = row.Cells[1].Value;
                    com3.Parameters.Add("@b", SqlDbType.VarChar).Value = row.Cells[1].Value;
                    com.Parameters.Add("@c", SqlDbType.VarChar).Value = row.Cells[2].Value;
                    com2.Parameters.Add("@c", SqlDbType.VarChar).Value = row.Cells[2].Value;
                    com.Parameters.Add("@d", SqlDbType.Int).Value = row.Cells[3].Value;
                    com2.Parameters.Add("@e", SqlDbType.VarChar).Value = ((string)com3.ExecuteScalar());
                    com.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                }
                e1.ExecuteNonQuery();
                e2.ExecuteNonQuery();
            }
            dataGridView1.ReadOnly = true;
            button2.Visible = false;
            button3.Visible = false;
            button1.Visible = true;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }
    }
}
