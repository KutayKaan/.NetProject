using System.Data.SqlClient;

namespace GameMarkt.Classes
{
    public static class SQLConnection
    {
        public static SqlConnection connection = new SqlConnection("Data Source=KUTAY\\MSSQLSERVER01;Initial Catalog=GameMarktDB;Integrated Security=True;Encrypt=False");

        public static void CheckConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
    }
}
