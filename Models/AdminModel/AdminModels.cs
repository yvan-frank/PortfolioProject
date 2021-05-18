using System;
using System.Data;
using System.Runtime.ConstrainedExecution;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Xml;

namespace Models.AdminModel
{
    
    public class AdminModels:Utilisateur
    {
        private ConnexionDb con = new ConnexionDb();
        //create user
        public void AddUser(string nom, string prenom, string email, int telephone, string adresse, string login,
            string password, int typeUser)
        {
            //this.SetNom(nom);
            //this.SetPrenom(prenom);
            //this.SetEmail(email);
            //this.SetTelephone(telephone);
            //this.SetAdresse(adresse);
            //this.SetLogin(login);
            //this.SetPassword(password);
            try
            {
                string sql =
                    "insert into utilisateur (nom,prenom, mail, telephone, adresse, login, mdp, type_id) values('" +
                    nom + "', '" + prenom + "', '" + email + "', '" + telephone + "','" + adresse + "','" + login +
                    "', '" + password + "','" + typeUser + "')";
                using (var connection = con.GetConnection())
                {
                    connection.Open();

                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = sql;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch
            {
               
            }
        }

        public bool Login(string login, string password)
        {
            string sql = "select * from admin where login=@login and mdp=@password";
            using (var connect = con.GetConnection())
            {
                connect.Open();
                using (var com = new MySqlCommand())
                {
                    com.Connection = connect;
                    com.CommandText = sql;
                    com.Parameters.AddWithValue("@login", login);
                    com.Parameters.AddWithValue("@password", password);
                    com.CommandType = CommandType.Text;

                    MySqlDataReader reader = com.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
