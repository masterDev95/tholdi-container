using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TholdiContainer.DBA;

namespace TholdiContainer.Tables
{
    class Probleme
    {
        private static string selectSql = "SELECT * FROM PROBLEME";
        private static string selectByIdSql = "SELECT * FROM PROBLEME WHERE CODEPROBLEME = ?CodeProbleme ";
        private static string updateSql = "UPDATE PROBLEME SET LIBELLEPROBLEME=?LibelleProbleme WHERE CODEPROBLEME=?CodeProbleme";
        private static string insertSql = "INSERT INTO PROBLEME (CODEPROBLEME, LIBELLEPROBLEME) VALUES (?CodeProbleme, ?LibelleProbleme)";

        private bool isNew = true;

        public short CodeProbleme { get; private set; }
        public string LibelleProbleme { get; set; }

        static public Probleme Fetch(short codeProbleme)
        {
            Probleme unProbleme = null;
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Probleme.selectByIdSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeProbleme", codeProbleme));
            commandSql.Prepare();

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            bool existEnregistrement = jeuEnregistrements.Read();

            if (existEnregistrement)
            {
                unProbleme = new Probleme()
                {
                    CodeProbleme = short.Parse(jeuEnregistrements["CodeProbleme"].ToString()),
                    LibelleProbleme = jeuEnregistrements["LibelleProbleme"].ToString(),
                    isNew = false
                };
            }

            openConnection.Close();
            return unProbleme;
        }

        static public List<Probleme> FetchAll()
        {
            List<Probleme> resultat = new List<Probleme>();
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Probleme.selectSql;

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();

            while (jeuEnregistrements.Read())
            {
                Probleme unProbleme = new Probleme()
                {
                    CodeProbleme = short.Parse(jeuEnregistrements["CodeProbleme"].ToString()),
                    LibelleProbleme = jeuEnregistrements["LibelleProbleme"].ToString(),
                    isNew = false
                };

                resultat.Add(unProbleme);
            }

            openConnection.Close();
            return resultat;
        }

        private void Insert()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Probleme.insertSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeProbleme", this.CodeProbleme));
            commandSql.Parameters.Add(new MySqlParameter("?LibelleProbleme", this.LibelleProbleme));
            commandSql.Prepare();
            commandSql.ExecuteNonQuery();

            openConnection.Close();
        }

        private void Update()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Probleme.updateSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeProbleme", this.CodeProbleme));
            commandSql.Parameters.Add(new MySqlParameter("?LibelleProbleme", this.LibelleProbleme));
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
