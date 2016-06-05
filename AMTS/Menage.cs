using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AMTS
{
    public partial class Menage : AbstractForm
    {
        SqlConnection connection;
        AbstractForm mainForm;
        DataSet dataSet;
        SqlDataAdapter dataAd;
        User captain;
        private DataTable mecze2;
        private DataTable mecze;
        private DataTable zawodnicy;
        private SqlDataAdapter dataAdMecze2;
        private SqlDataAdapter dataAdMecze;

        public Menage(SqlConnection connection, AbstractForm MF, User cpt)
        {
            this.connection = connection;
            mainForm = MF;
            captain = cpt;
            InitializeComponent();
            Zapisz.Visible = false;
            Anuluj.Visible = false;
            telefon.Visible = false;
            mail.Visible = false;
            zmiany.Visible = false;
            dataSet = new DataSet();
            dataAd = new SqlDataAdapter("  select Imie, Nazwisko, Mail, Telefon from dbo.UZYTKOWNICY where Druzyna like '" + captain.getTeamName() + "'", this.connection);
            SqlCommandBuilder com = new SqlCommandBuilder(dataAd);
            dataAd.Fill(dataSet, "Kontakty");

            daneKontaktowe.DataSource = dataSet.Tables["Kontakty"];
            daneKontaktowe.ReadOnly = true;

            SqlDataAdapter ada = new SqlDataAdapter("select Imie, Nazwisko, PESEL from dbo.uzytkownicy where Druzyna like '" + captain.getTeamName() + "'", this.connection);
            zawodnicy = new DataTable();
            ada.Fill(zawodnicy);
            foreach (DataRow r in zawodnicy.Rows)
            {
                pierwszy.Items.Add(r["Imie"].ToString() + " " + r["Nazwisko"].ToString());
                drugi.Items.Add(r["Imie"].ToString() + " " + r["Nazwisko"].ToString());
                trzeci.Items.Add(r["Imie"].ToString() + " " + r["Nazwisko"].ToString());

            }
            dataAdMecze = new SqlDataAdapter("  select Data, Druzyna, p1, p2, p3 from TERMINARZ where Przeciwnik like '" + captain.getTeamName() + "'", this.connection);
            dataAdMecze = new SqlDataAdapter("  select Data, Przeciwnik, z1, z2, z3 from TERMINARZ where Druzyna like '" + captain.getTeamName() + "'", this.connection);
            mecze = new DataTable();
            mecze2 = new DataTable();
            dataAdMecze.Fill(mecze);
            dataAdMecze.Fill(mecze2);
            foreach (DataRow r in mecze.Rows)
            {
                mecz.Items.Add(r["Druzyna"].ToString() + ":" + r["Data"].ToString());
            }
            foreach (DataRow r in mecze2.Rows)
            {
                mecz.Items.Add(r["Przeciwnik"].ToString() + ":" + r["Data"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zapisz.Visible = true;
            Anuluj.Visible = true;
            Edytuj.Visible = false;
            telefon.Visible = false;
            mail.Visible = false;
            zmiany.Visible = false;
            daneKontaktowe.ReadOnly = false;
            daneKontaktowe.Columns[0].ReadOnly = true;
            daneKontaktowe.Columns[1].ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zapisz.Visible = false;
            Anuluj.Visible = false;
            Edytuj.Visible = true;
            daneKontaktowe.ReadOnly = true;
            dataSet.Clear();
            dataAd.Fill(dataSet, "Kontakty");
            daneKontaktowe.DataSource = dataSet.Tables["Kontakty"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool noChanges = false;
            string expr;
            foreach (DataGridViewRow row in daneKontaktowe.Rows)
            {
                expr = "\\d{9}";
                if (!row.Cells[3].Value.ToString().Equals(""))
                {
                    if (check(row.Cells[3].Value.ToString(), expr) == false)
                    {
                        noChanges = true;
                        telefon.Visible = true;
                    }
                }

                expr = "[A-z]+@[A-z]+\\.[A-z]+";
                if (check(row.Cells[2].Value.ToString(), expr) == false)
                {
                    noChanges = true;
                    mail.Visible = true;
                }



            }
            if (noChanges)
            {
                zmiany.Visible = true;
                dataSet.Clear();
                dataAd.Fill(dataSet, "Kontakty");
                daneKontaktowe.DataSource = dataSet.Tables["Kontakty"];
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
                com.Connection = connection;
                com2.Connection = connection;
                com3.Connection = connection;
                b1.Connection = connection;
                b2.Connection = connection;
                e1.Connection = connection;
                e2.Connection = connection;
                b1.ExecuteNonQuery();
                b2.ExecuteNonQuery();
                foreach (DataGridViewRow row in daneKontaktowe.Rows)
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
            daneKontaktowe.ReadOnly = true;
            Zapisz.Visible = false;
            Anuluj.Visible = false;
            Edytuj.Visible = true;
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
            if (!string.IsNullOrEmpty(mecz.SelectedItem.ToString()))
            {
                data = mecz.SelectedItem.ToString().Split(':');
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
                    row = zawodnicy.Select("PESEL like'" + z1 + "'");
                    pierwszy.SelectedIndex = pierwszy.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    pierwszy.ResetText();
                    pierwszy.SelectedIndex = -1;
                }
                if (check(z2, "\\d{11}"))
                {
                    row = zawodnicy.Select("PESEL like'" + z2 + "'");
                    drugi.SelectedIndex = drugi.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    drugi.ResetText();
                    drugi.SelectedIndex = -1;
                }
                if (check(z3, "\\d{11}"))
                {
                    row = zawodnicy.Select("PESEL like'" + z3 + "'");
                    trzeci.SelectedIndex = trzeci.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    trzeci.ResetText();
                    trzeci.SelectedIndex = -1;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data;
            if (mecz.SelectedItem!=null &&!string.IsNullOrEmpty(mecz.SelectedItem.ToString()))
            {
                data = mecz.SelectedItem.ToString().Split(':');
                DataRow[] row;
                string[] z1, z2, z3;
                string a1, a2, a3;
                if(pierwszy.SelectedItem!=null&&!string.IsNullOrEmpty(pierwszy.SelectedItem.ToString()))
                {
                    z1 = pierwszy.SelectedItem.ToString().Split(' ');
                    row = zawodnicy.Select("Imie like '" + z1[0] + "'and Nazwisko like '" + z1[1] + "'");
                    a1 = row[0]["PESEL"].ToString();
                }
                else a1 = "";
                if (drugi.SelectedItem != null && !string.IsNullOrEmpty(drugi.SelectedItem.ToString()))
                {
                    z2 = drugi.SelectedItem.ToString().Split(' ');
                    row = zawodnicy.Select("Imie like '" + z2[0] + "'and Nazwisko like '" + z2[1] + "'");
                    a2 = row[0]["PESEL"].ToString();
                }
                else a2 = "";
                if (trzeci.SelectedItem != null && !string.IsNullOrEmpty(trzeci.SelectedItem.ToString()))
                {
                    z3 = trzeci.SelectedItem.ToString().Split(' ');
                    row = zawodnicy.Select("Imie like '" + z3[0] + "'and Nazwisko like '" + z3[1] + "'");
                    a3 = row[0]["PESEL"].ToString();
                }
                else a3 = "";
               
                row = mecze.Select("Druzyna like '" + data[0] + "'and Data like'" + data[1] + "'");
                if (row.Length <= 0)
                {
                    if (!a1.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set z1 = '"+a1+"' where Przeciwnik like '"+data[0]+"' and Data like '"+data[1]+"'", connection);
                        com.ExecuteNonQuery();

                    }
                    if (!a2.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set z2 = '" + a2 + "' where Przeciwnik like '" + data[0] + "' and Data like '" + data[1] + "'", connection);
                        com.ExecuteNonQuery();
                    }
                    if (!a3.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set z3 = '" + a3 + "' where Przeciwnik like '" + data[0] + "' and Data like '" + data[1] + "'", connection);
                        com.ExecuteNonQuery();
                    }
                    mecze2.Clear();
                    dataAdMecze.Fill(mecze2);
                }
                else
                {
                    if (!a1.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set p1 = '" + a1 + "' where Druzyna like '" + data[0] + "' and Data like '" + data[1] + "'", connection);
                        com.ExecuteNonQuery();
                    }
                    if (!a2.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set p2 = '" + a2 + "' where Druzyna like '" + data[0] + "' and Data like '" + data[1] + "'", connection);
                        com.ExecuteNonQuery();
                    }
                    if (!a3.Equals(""))
                    {
                        SqlCommand com = new SqlCommand("  update TERMINARZ set p3 = '" + a3 + "' where Druzyna like '" + data[0] + "' and Data like '" + data[1] + "'", connection);
                        com.ExecuteNonQuery();
                    }
                    mecze.Clear();
                    dataAdMecze.Fill(mecze);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] data;
            if (!string.IsNullOrEmpty(mecz.SelectedItem.ToString()))
            {
                data = mecz.SelectedItem.ToString().Split(':');
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
                    row = zawodnicy.Select("PESEL like'" + z1 + "'");
                    pierwszy.SelectedIndex = pierwszy.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    pierwszy.ResetText();
                    pierwszy.SelectedIndex = -1;
                }
                if (check(z2, "\\d{11}"))
                {
                    row = zawodnicy.Select("PESEL like'" + z2 + "'");
                    drugi.SelectedIndex = drugi.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    drugi.ResetText();
                    drugi.SelectedIndex = -1;
                }
                if (check(z3, "\\d{11}"))
                {
                    row = zawodnicy.Select("PESEL like'" + z3 + "'");
                    trzeci.SelectedIndex = trzeci.FindStringExact(row[0]["Imie"].ToString() + " " + row[0]["Nazwisko"].ToString());
                }
                else
                {
                    trzeci.ResetText();
                    trzeci.SelectedIndex = -1;
                }
            }
        }
    }
}
