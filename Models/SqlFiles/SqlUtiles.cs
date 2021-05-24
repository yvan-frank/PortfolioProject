
using System.Data;
using MySql.Data.MySqlClient;

namespace Models.SqlFiles
{
    public class SqlUtiles
    {
        private ConnexionDb con = new ConnexionDb();
        private MySqlCommand command = new MySqlCommand();
        private string _type;


        public string FillComboBox()
        {
            using (var connect = con.GetConnection())
            {
                connect.Open();
                using (command)
                {
                    command.Connection = connect;
                    command.CommandText = "select * from user_type";
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();

                    
                    while (reader.Read())
                    {
                       _type  = reader.GetString(1);
                    }

                    return _type;
                }
            }
        }
    }
}
