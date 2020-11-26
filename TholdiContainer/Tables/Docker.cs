using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TholdiContainer.DBA;

namespace TholdiContainer.Tables
{
    class Docker
    {
        private static string selectSql = "SELECT * FROM DOCKER";
        private static string selectByIdSql = "SELECT * FROM DOCKER WHERE CODEDOCKER=?CodeDocker ";
        private static string updateSql = "UPDATE DOCKER SET NOMDOCKER=?NomDocker, PRENOMDOCKER=?PrenomDocker WHERE CODEDOCKER=?CodeDocker";
        private static string insertSql = "INSERT INTO DOCKER (CODEDOCKER, NOMDOCKER, PRENOMDOCKER) VALUES (?CodeDocker, ?NomDocker, ?PrenomDocker)";

        private bool isNew = true;

        public short CodeDocker { get; private set; }
        public string NomDocker { get; set; }
        public string PrenomDocker { get; set; }

        public static Docker Fetch(short codeDocker)
        {
            Docker unDocker = null;
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Docker.selectByIdSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeDocker", codeDocker));
            commandSql.Prepare();

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            bool existEnregistrement = jeuEnregistrements.Read();

            if (existEnregistrement)
            {
                unDocker = new Docker()
                {
                    CodeDocker = short.Parse(jeuEnregistrements["CodeDocker"].ToString()),
                    NomDocker = jeuEnregistrements["NomDocker"].ToString(),
                    PrenomDocker = jeuEnregistrements["PrenomDocker"].ToString(),
                    isNew = false
                };
            }

            openConnection.Close();
            return unDocker;
        }

        static public List<Docker> FetchAll()
        {
            List<Docker> resultat = new List<Docker>();
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Docker.selectSql;

            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();

            while (jeuEnregistrements.Read())
            {
                Docker unDocker = new Docker()
                {
                    CodeDocker = short.Parse(jeuEnregistrements["CodeDocker"].ToString()),
                    NomDocker = jeuEnregistrements["NomDocker"].ToString(),
                    PrenomDocker = jeuEnregistrements["PrenomDocker"].ToString(),
                    isNew = false
                };

                resultat.Add(unDocker);
            }

            openConnection.Close();
            return resultat;
        }

        private void Insert()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Docker.insertSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeDocker", this.CodeDocker));
            commandSql.Parameters.Add(new MySqlParameter("?NomDocker", this.NomDocker));
            commandSql.Parameters.Add(new MySqlParameter("?PrenomDocker", this.PrenomDocker));
            commandSql.Prepare();
            commandSql.ExecuteNonQuery();

            openConnection.Close();
        }

        private void Update()
        {
            MySqlConnection openConnection = DataBaseAccess.getOpenMySqlConnection();
            MySqlCommand commandSql = openConnection.CreateCommand();

            commandSql.CommandText = Docker.updateSql;
            commandSql.Parameters.Add(new MySqlParameter("?CodeDocker", this.CodeDocker));
            commandSql.Parameters.Add(new MySqlParameter("?NomDocker", this.NomDocker));
            commandSql.Parameters.Add(new MySqlParameter("?PrenomDocker", this.PrenomDocker));
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
