using MySql.Data.MySqlClient;

namespace TholdiContainer.DBA
{
    class DataBaseAccess
    {
        public static MySqlConnection getOpenMySqlConnection()
        {
            MySqlConnection msc = new MySqlConnection(
                "Database=mydb_aott;" +
                "Data Source=217.167.171.227;" +
                "UserId=aott;Password=12/11/1998;" +
                "Ssl Mode=None;" +
                "charset=utf8");

            msc.Open();
            return msc;
        }
    }
}
