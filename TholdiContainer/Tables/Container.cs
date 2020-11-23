using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TholdiContainer.DBA;

namespace TholdiContainer.Tables
{
    class Container
    {
        private static string selectSql = "SELECT * FROM PROBLEME";
        private static string selectByIdSql = "SELECT * FROM PROBLEME WHERE NUMCONTAINER = ?NumContainer ";
        private static string updateSql = "UPDATE PROBLEME SET DATEACHAT=?DateAchat, TYPECONTAINER=?TypeContainer, DATEDERNIEREINSP=?DateDerniereInsp WHERE NUMCONTAINER=?NumContainer";
        private static string insertSql = "INSERT INTO PROBLEME (NUMCONTAINER, DATEACHAT, TYPECONTAINER, DATEDERNIEREINSP) VALUES (?NumContainer, ?DateAchat, ?TypeContainer, ?DateDerniereInsp)";

        private bool isNew;

        public int NumContainer { get; private set; }
        public DateTime DateAchat { get; set; }
        public string TypeContainer { get; set; }
        public DateTime DateDerniereInsp { get; set; }

        public Container(int numContainer)
        {
            this.NumContainer = numContainer;
            this.isNew = true;
        }

        static public Container Fetch(int numContainer)
        {
            Container unContainer = null;
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Container.selectByIdSql;
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", numContainer));
            commandSql.Prepare();

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            bool existEnregistrement = jeuEnregistrements.Read();

            if (existEnregistrement)
            {
                unContainer = new Container(int.Parse(jeuEnregistrements["NumContainer"].ToString()))
                {
                    DateAchat = DateTime.Parse(jeuEnregistrements["DateAchat"].ToString()),
                    TypeContainer = jeuEnregistrements["TypeContainer"].ToString(),
                    DateDerniereInsp = DateTime.Parse(jeuEnregistrements["DateDerniereInsp"].ToString()),
                    isNew = false
                };
            }

            openConnection.Close();
            return unContainer;
        }

        static public List<Container> FetchAll()
        {
            List<Container> resultat = new List<Container>();
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Container.selectSql;

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();

            while (jeuEnregistrements.Read())
            {
                Container unContainer = new Container(int.Parse(jeuEnregistrements["NumContainer"].ToString()))
                {
                    DateAchat = DateTime.Parse(jeuEnregistrements["DateAchat"].ToString()),
                    TypeContainer = jeuEnregistrements["TypeContainer"].ToString(),
                    DateDerniereInsp = DateTime.Parse(jeuEnregistrements["DateDerniereInsp"].ToString()),
                    isNew = false
                };

                resultat.Add(unContainer);
            }

            openConnection.Close();
            return resultat;
        }

        private void Insert()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Container.insertSql;
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", this.NumContainer));
            commandSql.Parameters.Add(new MySqlParameter("?DateAchat", this.DateAchat));
            commandSql.Parameters.Add(new MySqlParameter("?TypeContainer", this.TypeContainer));
            commandSql.Parameters.Add(new MySqlParameter("?DateDerniereInsp", this.DateDerniereInsp));
            commandSql.Prepare();
            commandSql.ExecuteNonQuery();

            openConnection.Close();
        }

        private void Update()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Container.updateSql;
            commandSql.Parameters.Add(new MySqlParameter("?NumContainer", this.NumContainer));
            commandSql.Parameters.Add(new MySqlParameter("?DateAchat", this.DateAchat));
            commandSql.Parameters.Add(new MySqlParameter("?TypeContainer", this.TypeContainer));
            commandSql.Parameters.Add(new MySqlParameter("?DateDerniereInsp", this.DateDerniereInsp));
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
