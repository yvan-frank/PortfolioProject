using MySql.Data.MySqlClient;
namespace Models
{
    public class ConnexionDb
    {
        private string host = "127.0.0.1";
        private int port = 3306;
        private string database = "testportfolio";
        private string username = "root";
        private string password = "";

        private readonly string chaineConnection;

        public ConnexionDb()
        {
            chaineConnection = "Server=" + host + ";Database=" + database + ";port=" + port + ";User id=" + username +
                               ";password=" + password;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(chaineConnection);
        }
    }
}
