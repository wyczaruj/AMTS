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
        private DataTable mecze2;
        private DataTable mecze;
        private DataTable table;
        private SqlDataAdapter adadd;
        private SqlDataAdapter adada;

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
            dataAd = new SqlDataAdapter("  select Imie, Nazwisko, Mail, Telefon from dbo.UZYTKOWNICY where Druzyna like '" + captain.getTeamName() + "'", conn);
            SqlCommandBuilder com = new SqlCommandBuilder(dataAd);
            dataAd.Fill(dataSet, "Kontakty");

            dataGridView1.DataSource = dataSet.Tables["Kontakty"];
            dataGridView1.ReadOnly = true;

            SqlDataAdapter ada = new SqlDataAdapter("select Imie, Nazwisko, PESEL from dbo.uzytkownicy where Druzyna like '" + captain.getTeamName() + "'", conn);
            table = new DataTable();
            ada.Fill(table);
            foreach (DataRow r in table.Rows)
            {
                comboBox2.Items.Add(r["Imie"].ToString() + " " + r["Nazwisko"].ToString());
                comboBox3.Items.Add(r["Imie"].ToString() + " " + r["Nazwisko"].ToString());
                comboBox4.Items.Add(r["Imie"].ToString() + " " + r["Nazwisko"].ToString());

            }
            adada = new SqlDataAdapter("  select Data, Druzyna, p1, p2, p3 from TERMINARZ where Przeciwnik like '" + captain.getTeamName() + "'", conn);
            adadd = new SqlDataAdapter("  select Data, Przeciwnik, z1, z2, z3 from TERMINARZ where Druzyna like '" + captain.getTeamName() + "'", conn);
            mecze = new DataTable();
            mecze2 = new DataTable();
            adada.Fill(mecze);
            adadd.Fill(mecze2);
            foreach (DataRow r in mecze.Rows)
            {
                comboBox1.Items.Add(r["Druzyna"].ToString() + ":" + r["Data"].ToString());
            }
            foreach (DataRow r in mecze2.Rows)
            {
                comboBox1.Items.Add(r["Przeciwnik"].ToString() + ":" + r["Data"].ToString());
            }
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
            foreach (DataGridViewRow row in dataGridView1.Rows)
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
            if (str.Equals("") || str.Equals("NULL") || str == null)
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


        private void Menage_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.changeOpenedWindow();
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            string[] data;
            if (!string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                data = comboBox1.SelectedItem.ToString().Split(':');
                DataRow[] row;
                string z1, z2, z3;
                row = mecze.Select("Druzyna like '" + data[0] + "'and Data like'" + data[1] + "'");

                if (row.Length <= 0)
                {
                    row = mecze2.Select("Przeciwnik like '" + data[0] + "'and Data like'" + data[1] + "'");
                    z1 = row[0]["z1"].ToString();
                    z2 = row[0]["z2"].ToString();
                    z3 = row[0]["z3"].ToString();
                }
                else
                {
                    z1 = row[0]["p1"].ToString();
                    z2 = row[0]["p2"].ToString();
                    z3 = row[0]["p3"].ToString();
                }


                if (check(z1, "\\d{11}"))
                {
                    row = table.Select("PESEL like'" + z1 + "'");
                    comboBox2.SelectedIndex = comboBox2.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    comboBox2.ResetText();
                    comboBox2.SelectedIndex = -1;
                }
                if (check(z2, "\\d{11}"))
                {
                    row = table.Select("PESEL like'" + z2 + "'");
                    comboBox3.SelectedIndex = comboBox3.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    comboBox3.ResetText();
                    comboBox3.SelectedIndex = -1;
                }
                if (check(z3, "\\d{11}"))
                {
                    row = table.Select("PESEL like'" + z3 + "'");
                    comboBox4.SelectedIndex = comboBox4.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    comboBox4.ResetText();
                    comboBox4.SelectedIndex = -1;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data;
            if (comboBox1.SelectedItem!=null &&!string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                data = comboBox1.SelectedItem.ToString().Split(':');
                DataRow[] row;
                string[] z1, z2, z3;
                string a1, a2, a3;
                if(comboBox2.SelectedItem!=null&&!string.IsNullOrEmpty(comboBox2.SelectedItem.ToString()))
                {
                    z1 = comboBox2.SelectedItem.ToString().Split(' ');
                    row = table.Select("Imie like '" + z1[0] + "'and Nazwisko like '" + z1[1] + "'");
                    a1 = row[0]["PESEL"].ToString();
                }
                else a1 = "";
                if (comboBox3.SelectedItem != null && !string.IsNullOrEmpty(comboBox3.SelectedItem.ToString()))
                {
                    z2 = comboBox3.SelectedItem.ToString().Split(' ');
                    row = table.Select("Imie like '" + z2[0] + "'and Nazwisko like '" + z2[1] + "'");
                    a2 = row[0]["PESEL"].ToString();
                }
                else a2 = "";
                if (comboBox4.SelectedItem != null && !string.IsNullOrEmpty(comboBox4.SelectedItem.ToString()))
                {
                    z3 = comboBox4.SelectedItem.ToString().Split(' ');
                    row = table.Select("Imie like '" + z3[0] + "'and Nazwisko like '" + z3[1] + "'");
                    a3 = row[0]["PESEL"].ToString();
                }
                else a3 = "";
               
                row = mecze.Select("Druzyna like '" + data[0] + "'and Data like'" + data[1] + "'");
                if (row.Length <= 0)
                {
                    if (!a1.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set z1 = '"+a1+"' where Przeciwnik like '"+data[0]+"' and Data like '"+data[1]+"'", conn);
                        com.ExecuteNonQuery();

                    }
                    if (!a2.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set z2 = '" + a2 + "' where Przeciwnik like '" + data[0] + "' and Data like '" + data[1] + "'", conn);
                        com.ExecuteNonQuery();
                    }
                    if (!a3.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set z3 = '" + a3 + "' where Przeciwnik like '" + data[0] + "' and Data like '" + data[1] + "'", conn);
                        com.ExecuteNonQuery();
                    }
                    mecze2.Clear();
                    adadd.Fill(mecze2);
                }
                else
                {
                    if (!a1.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set p1 = '" + a1 + "' where Druzyna like '" + data[0] + "' and Data like '" + data[1] + "'", conn);
                        com.ExecuteNonQuery();
                    }
                    if (!a2.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set p2 = '" + a2 + "' where Druzyna like '" + data[0] + "' and Data like '" + data[1] + "'", conn);
                        com.ExecuteNonQuery();
                    }
                    if (!a3.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set p3 = '" + a3 + "' where Druzyna like '" + data[0] + "' and Data like '" + data[1] + "'", conn);
                        com.ExecuteNonQuery();
                    }
                    mecze.Clear();
                    adada.Fill(mecze);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] data;
            if (!string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()))
            {
                data = comboBox1.SelectedItem.ToString().Split(':');
                DataRow[] row;
                string z1, z2, z3;
                row = mecze.Select("Druzyna like '" + data[0] + "'and Data like'" + data[1] + "'");

                if (row.Length <= 0)
                {
                    row = mecze2.Select("Przeciwnik like '" + data[0] + "'and Data like'" + data[1] + "'");
                    z1 = row[0]["z1"].ToString();
                    z2 = row[0]["z2"].ToString();
                    z3 = row[0]["z3"].ToString();
                }
                else
                {
                    z1 = row[0]["p1"].ToString();
                    z2 = row[0]["p2"].ToString();
                    z3 = row[0]["p3"].ToString();
                }


                if (check(z1, "\\d{11}"))
                {
                    row = table.Select("PESEL like'" + z1 + "'");
                    comboBox2.SelectedIndex = comboBox2.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    comboBox2.ResetText();
                    comboBox2.SelectedIndex = -1;
                }
                if (check(z2, "\\d{11}"))
                {
                    row = table.Select("PESEL like'" + z2 + "'");
                    comboBox3.SelectedIndex = comboBox3.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    comboBox3.ResetText();
                    comboBox3.SelectedIndex = -1;
                }
                if (check(z3, "\\d{11}"))
                {
                    row = table.Select("PESEL like'" + z3 + "'");
                    comboBox4.SelectedIndex = comboBox4.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    comboBox4.ResetText();
                    comboBox4.SelectedIndex = -1;
                }
            }
        }
    }
}
