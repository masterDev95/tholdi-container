using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TholdiContainer.DBA;

namespace TholdiContainer.Tables
{
    class Declaration
    {
        private static string selectSql = "SELECT * FROM DECLARATION";
        private static string selectByIdSql = "SELECT * FROM DECLARATION WHERE CODEDECLARATION = ?CodeDeclaration";
        private static string updateSql = "UPDATE DECISION SET DATEACHAT=?NumContainer, TYPECONTAINER=?CodeDocker, DATEDERNIEREINSP=?CodeProbleme WHERE NUMCONTAINER=?CommentaireDeclaration";
        private static string insertSql = "INSERT INTO DECISION (NUMCONTAINER, DATEACHAT, TYPECONTAINER, DATEDERNIEREINSP) VALUES (?NumContainer, ?DateAchat, ?TypeContainer, ?DateDerniereInsp)";

        private bool isNew;

        public int CodeDeclaration { get; set; }
        public int NumContainer { get; set; }
        public string CodeDocker { get; set; }
        public string CodeProbleme { get; set; }
        public string CommentaireDeclaration { get; set; }
        public DateTime DateDeclaration { get; set; }
        public bool Urgence { get; set; }
        public bool Traite { get; set; }

        public Declaration(int codeDeclaration, int numContainer, string codeDocker, string codeProbleme)
        {
            this.CodeDeclaration = codeDeclaration;
            this.NumContainer = numContainer;
            this.CodeDocker = CodeDocker;
            this.CodeProbleme = CodeProbleme;
            this.isNew = true;
        }

        static public Declaration Fetch(int codeDeclaration)
        {
            Declaration uneDecision = null;
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Declaration.selectByIdSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeDeclaration", codeDeclaration));
            commandSql.Prepare();

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            bool existEnregistrement = jeuEnregistrements.Read();

            if (existEnregistrement)
            {
                codeDeclaration = int.Parse(jeuEnregistrements["CodeDeclaration"].ToString());
                int numContainer = int.Parse(jeuEnregistrements["NumContainer"].ToString());
                string codeDocker = jeuEnregistrements["CodeDocker"].ToString();
                string codeProbleme = jeuEnregistrements["CodeProbleme"].ToString();

                Declaration uneDeclaration = new Declaration(codeDeclaration, numContainer, codeDocker, codeProbleme)
                {
                    CommentaireDeclaration = jeuEnregistrements["CommentaireDeclaration"].ToString(),
                    DateDeclaration = DateTime.Parse(jeuEnregistrements["DateDeclaration"].ToString()),
                    Urgence = bool.Parse(jeuEnregistrements["Urgence"].ToString()),
                    Traite = bool.Parse(jeuEnregistrements["Traite"].ToString()),
                    isNew = false
                };
            }

            openConnection.Close();
            return uneDecision;
        }

        static public List<Declaration> FetchAll()
        {
            List<Declaration> resultat = new List<Declaration>();
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Declaration.selectSql;

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();

            while (jeuEnregistrements.Read())
            {
                int codeDeclaration = int.Parse(jeuEnregistrements["CodeDeclaration"].ToString());
                int numContainer = int.Parse(jeuEnregistrements["NumContainer"].ToString());
                string codeDocker = jeuEnregistrements["CodeDocker"].ToString();
                string codeProbleme = jeuEnregistrements["CodeProbleme"].ToString();

                Declaration uneDeclaration = new Declaration(codeDeclaration, numContainer, codeDocker, codeProbleme)
                {
                    CommentaireDeclaration = jeuEnregistrements["CommentaireDeclaration"].ToString(),
                    DateDeclaration = DateTime.Parse(jeuEnregistrements["DateDeclaration"].ToString()),
                    Urgence = bool.Parse(jeuEnregistrements["Urgence"].ToString()),
                    Traite = bool.Parse(jeuEnregistrements["Traite"].ToString()),
                    isNew = false
                };
            }

            openConnection.Close();
            return resultat;
        }

        private void Insert()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Declaration.insertSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeDeclaration", this.CodeDeclaration));
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", this.NumContainer));
            commandSql.Parameters.Add(new MySqlParameter("?CodeDocker", this.CodeDocker));
            commandSql.Parameters.Add(new MySqlParameter("?CodeProbleme", this.CodeProbleme));
            commandSql.Parameters.Add(new MySqlParameter("?CommentaireDeclaration", this.CommentaireDeclaration));
            commandSql.Parameters.Add(new MySqlParameter("?DateDeclaration", this.DateDeclaration));
            commandSql.Parameters.Add(new MySqlParameter("?Urgence", this.Urgence));
            commandSql.Parameters.Add(new MySqlParameter("?Traite", this.Traite));
            commandSql.Prepare();
            commandSql.ExecuteNonQuery();

            this.NumContainer = Convert.ToInt16(commandSql.LastInsertedId);

            openConnection.Close();
        }

        private void Update()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Declaration.updateSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeDeclaration", this.CodeDeclaration));
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", this.NumContainer));
            commandSql.Parameters.Add(new MySqlParameter("?CodeDocker", this.CodeDocker));
            commandSql.Parameters.Add(new MySqlParameter("?CodeProbleme", this.CodeProbleme));
            commandSql.Parameters.Add(new MySqlParameter("?CommentaireDeclaration", this.CommentaireDeclaration));
            commandSql.Parameters.Add(new MySqlParameter("?DateDeclaration", this.DateDeclaration));
            commandSql.Parameters.Add(new MySqlParameter("?Urgence", this.Urgence));
            commandSql.Parameters.Add(new MySqlParameter("?Traite", this.Traite));
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
