using System;
using System.Data.SqlClient;

namespace AMTS
{
    public class User
    {
        private bool hasTeam;
        private string teamName;
        private string email;
        private bool pendingTeamRequest;
        private bool isCaptain;

        public User(SqlConnection connection, string email)
        {
            isCaptain = false;
            hasTeam = false;
            pendingTeamRequest = false;
            this.email = email;
            teamName = "";
            SqlCommand sqlcomm = new SqlCommand("SELECT Druzyna AS TEAM, PESEL AS PSL FROM UZYTKOWNICY WHERE Mail=" + "'" + email + "'", connection);
            string pesel;
            SqlDataReader r = sqlcomm.ExecuteReader();
            r.Read();
            Object team = r["TEAM"];
            pesel = r["PSL"].ToString();
            if (DBNull.Value != team)
            {
                teamName = team.ToString();
                hasTeam = true;
            }
            else
            {
                r.Close();
                SqlCommand sqlcomm2 = new SqlCommand("SELECT Druzyna AS TEAMNAME FROM ZGLOSZENIA WHERE Mail= '" + email 
                    + "' AND Potwierdzenie = 1", connection);
                SqlDataReader r2 = sqlcomm2.ExecuteReader();
                if (r2.Read())
                {
                    pendingTeamRequest = true;
                    teamName = r2["TEAMNAME"].ToString();
                }
                r2.Close();
            }
            r.Close();
            if(pendingTeamRequest || hasTeam)
            {
                sqlcomm = new SqlCommand("SELECT Kapitan AS CAP FROM DRUZYNY WHERE Nazwa=" + "'" + teamName + "'", connection);
                r = sqlcomm.ExecuteReader();
                r.Read();
                if (r["CAP"].ToString().Equals(pesel))
                {
                    isCaptain = true;
                }
                r.Close();
            }
        }

        public string getTeamName()
        {
            return teamName;
        }

        public string getEmail()
        {
            return email;
        }

        public bool getHasTeam()
        {
            return hasTeam;
        }

        public bool getPending()
        {
            return pendingTeamRequest;
        }

        public bool getCaptain()
        {
            return isCaptain;
        }

    }
}
