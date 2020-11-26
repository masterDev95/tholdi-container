using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TholdiContainer.DBA;

namespace TholdiContainer.Tables
{
    class Decision
    {
        private static string selectSql = "SELECT * FROM DECISION";
        private static string selectByIdSql = "SELECT * FROM DECISION WHERE NUMCONTAINER = ?NumContainer AND NUMINSPECTION=?NumInspection AND CODETRAVAUX=?CodeTravaux";
        private static string updateSql = "UPDATE DECISION SET DATEACHAT=?DateAchat, TYPECONTAINER=?TypeContainer, DATEDERNIEREINSP=?DateDerniereInsp WHERE NUMCONTAINER=?NumContainer";
        private static string insertSql = "INSERT INTO DECISION (NUMCONTAINER, NUMINSPECTION, CODETRAVAUX, DATEDERNIEREINSP) VALUES (?NumContainer, ?DateAchat, ?TypeContainer, ?DateDerniereInsp)";

        private bool isNew = true;

        public int NumContainer { get; private set; }
        public short NumInspection { get; set; }
        public string CodeTravaux { get; set; }
        public DateTime DateEnvoi { get; set; }
        public DateTime DateRetour { get; set; }
        public string CommentaireDecision { get; set; }

        public Decision(int numContainer, short numInspection, string codeTravaux)
        {
            this.NumContainer = numContainer;
            this.NumInspection = numInspection;
            this.CodeTravaux = codeTravaux;
            this.isNew = true;
        }

        static public Decision Fetch(int numContainer, short numInspection, string codeTravaux)
        {
            Decision uneDecision = null;
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Decision.selectByIdSql;
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", numContainer));
            commandSql.Parameters.Add(new MySqlParameter("?NumInspection", numInspection));
            commandSql.Parameters.Add(new MySqlParameter("?CodeTravaux", codeTravaux));
            commandSql.Prepare();

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            bool existEnregistrement = jeuEnregistrements.Read();

            if (existEnregistrement)
            {
                numContainer = int.Parse(jeuEnregistrements["NumContainer"].ToString());
                numInspection = short.Parse(jeuEnregistrements["NumInspection"].ToString());
                codeTravaux = jeuEnregistrements["CodeTravaux"].ToString();

                uneDecision = new Decision(numContainer, numInspection, codeTravaux)
                {
                    DateEnvoi = DateTime.Parse(jeuEnregistrements["DateEnvoi"].ToString()),
                    DateRetour = DateTime.Parse(jeuEnregistrements["DateRetour"].ToString()),
                    CommentaireDecision = jeuEnregistrements["CommentaireDecision"].ToString(),
                    isNew = false
                };
            }

            openConnection.Close();
            return uneDecision;
        }

        static public List<Decision> FetchAll()
        {
            List<Decision> resultat = new List<Decision>();
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Decision.selectSql;

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();

            while (jeuEnregistrements.Read())
            {
                int numContainer = int.Parse(jeuEnregistrements["NumContainer"].ToString());
                short numInspection = short.Parse(jeuEnregistrements["NumInspection"].ToString());
                string codeTravaux = jeuEnregistrements["CodeTravaux"].ToString();

                Decision uneDecision = new Decision(numContainer, numInspection, codeTravaux)
                {
                    DateEnvoi = DateTime.Parse(jeuEnregistrements["DateEnvoi"].ToString()),
                    DateRetour = DateTime.Parse(jeuEnregistrements["DateRetour"].ToString()),
                    CommentaireDecision = jeuEnregistrements["CommentaireDecision"].ToString(),
                    isNew = false
                };

                resultat.Add(uneDecision);
            }

            openConnection.Close();
            return resultat;
        }

        private void Insert()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Decision.insertSql;
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", this.NumContainer));
            commandSql.Parameters.Add(new MySqlParameter("?NumInspection", this.NumInspection));
            commandSql.Parameters.Add(new MySqlParameter("?CodeTravaux", this.CodeTravaux));
            commandSql.Parameters.Add(new MySqlParameter("?DateEnvoi", this.DateEnvoi));
            commandSql.Parameters.Add(new MySqlParameter("?DateRetour", this.DateRetour));
            commandSql.Parameters.Add(new MySqlParameter("?CommentaireDecision", this.CommentaireDecision));
            commandSql.Prepare();
            commandSql.ExecuteNonQuery();

            this.NumContainer = Convert.ToInt16(commandSql.LastInsertedId);

            openConnection.Close();
        }

        private void Update()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Decision.updateSql;
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", this.NumContainer));
            commandSql.Parameters.Add(new MySqlParameter("?NumInspection", this.NumInspection));
            commandSql.Parameters.Add(new MySqlParameter("?CodeTravaux", this.CodeTravaux));
            commandSql.Parameters.Add(new MySqlParameter("?DateEnvoi", this.DateEnvoi));
            commandSql.Parameters.Add(new MySqlParameter("?DateRetour", this.DateRetour));
            commandSql.Parameters.Add(new MySqlParameter("?CommentaireDecision", this.CommentaireDecision));
            commandSql.Prepare();
            commandSql.ExecuteNonQuery();

            openConnection.Close();
        }

        public void Save()
        {
            if (isNew)
                Insert();
            else
                Update();
        }
    }
}
