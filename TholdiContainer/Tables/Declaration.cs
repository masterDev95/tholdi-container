using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TholdiContainer.DBA;

namespace TholdiContainer.Tables
{
    class Declaration
    {
        private static string selectSql = "SELECT * FROM DECLARATION";
        private static string selectByIdSql = "SELECT * FROM DECLARATION WHERE CODEDECLARATION=?CodeDeclaration";
        private static string updateSql = "UPDATE DECLARATION" +
                                          "SET NUMCONTAINER=?CodeDocker, CODEDOCKER=?CodeProbleme, CODEPROBLEME=?CodeProbleme, COMMENTAIREDECLARATION=?CommentaireDeclaration, DATEDECLARATION=?DateDeclaration, URGENCE=?Urgence, TRAITE=?Traite" +
                                          "WHERE NUMCONTAINER=?CommentaireDeclaration";
        private static string insertSql = "INSERT INTO DECLARATION (NUMCONTAINER, CODEDOCKER, CODEPROBLEME, COMMENTAIREDECLARATION, DATEDECLARATION, URGENCE, TRAITE)" +
                                          "VALUES (?NumContainer, ?CodeDocker, ?CodeProbleme, ?CommentaireDeclaration, ?DateDeclaration, ?Urgence, ?Traite)";

        private bool isNew = true;

        public int CodeDeclaration { get; private set; }
        public string CommentaireDeclaration { get; set; }
        public DateTime DateDeclaration { get; set; }
        public bool Urgence { get; set; }
        public bool Traite { get; set; }
        public Conteneur UnContainer { get; set; }
        public Docker UnDocker { get; set; }
        public Probleme UnProbleme { get; set; }

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
                Declaration uneDeclaration = new Declaration()
                {
                    CodeDeclaration = int.Parse(jeuEnregistrements["CodeDeclaration"].ToString()),
                    CommentaireDeclaration = jeuEnregistrements["CommentaireDeclaration"].ToString(),
                    DateDeclaration = DateTime.Parse(jeuEnregistrements["DateDeclaration"].ToString()),
                    Urgence = bool.Parse(jeuEnregistrements["Urgence"].ToString()),
                    Traite = bool.Parse(jeuEnregistrements["Traite"].ToString()),
                    UnContainer = Conteneur.Fetch(int.Parse(jeuEnregistrements["NumContainer"].ToString())),
                    UnDocker = Docker.Fetch(short.Parse(jeuEnregistrements["NumContainer"].ToString())),
                    UnProbleme = Probleme.Fetch(short.Parse(jeuEnregistrements["NumContainer"].ToString())),
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

                Declaration uneDeclaration = new Declaration()
                {
                    CodeDeclaration = int.Parse(jeuEnregistrements["CodeDeclaration"].ToString()),
                    CommentaireDeclaration = jeuEnregistrements["CommentaireDeclaration"].ToString(),
                    DateDeclaration = DateTime.Parse(jeuEnregistrements["DateDeclaration"].ToString()),
                    Urgence = bool.Parse(jeuEnregistrements["Urgence"].ToString()),
                    Traite = bool.Parse(jeuEnregistrements["Traite"].ToString()),
                    UnContainer = Conteneur.Fetch(int.Parse(jeuEnregistrements["NumContainer"].ToString())),
                    UnDocker = Docker.Fetch(short.Parse(jeuEnregistrements["NumContainer"].ToString())),
                    UnProbleme = Probleme.Fetch(short.Parse(jeuEnregistrements["NumContainer"].ToString())),
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
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", this.UnContainer.NumContainer));
            commandSql.Parameters.Add(new MySqlParameter("?CodeDocker", this.UnDocker.CodeDocker));
            commandSql.Parameters.Add(new MySqlParameter("?CodeProbleme", this.UnProbleme.CodeProbleme));
            commandSql.Parameters.Add(new MySqlParameter("?CommentaireDeclaration", this.CommentaireDeclaration));
            commandSql.Parameters.Add(new MySqlParameter("?DateDeclaration", this.DateDeclaration));
            commandSql.Parameters.Add(new MySqlParameter("?Urgence", this.Urgence));
            commandSql.Parameters.Add(new MySqlParameter("?Traite", this.Traite));
            commandSql.Prepare();
            commandSql.ExecuteNonQuery();

            this.CodeDeclaration = (int)commandSql.LastInsertedId;

            openConnection.Close();
        }

        private void Update()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Declaration.updateSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeDeclaration", this.CodeDeclaration));
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", this.UnContainer.NumContainer));
            commandSql.Parameters.Add(new MySqlParameter("?CodeDocker", this.UnDocker.CodeDocker));
            commandSql.Parameters.Add(new MySqlParameter("?CodeProbleme", this.UnProbleme.CodeProbleme));
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
