using System;
using System.Collections.Generic;
using System.Data;
using Common.Cache;
using MySql.Data.MySqlClient;
namespace Models.AdminModel
{
    
    public class AdminModels
    {
        private ConnexionDb con = new ConnexionDb();
        private MySqlCommand command = new MySqlCommand();
        //create user
        public void AddUser(string nom, string prenom, string email, int telephone, string adresse, string login,
            string password, int typeUser)
        {
            try
            {
                string sql =
                    "insert into utilisateur (nom, prenom, mail, telephone, adresse, login, mdp, user_type_id ) values('" +
                    nom + "', '" + prenom + "', '" + email + "', '" + telephone + "','" + adresse + "','" + login +
                    "', '" + password + "','" + typeUser + "')";
                using (var connection = con.GetConnection())
                {
                    connection.Open();

                    using (command)
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
               //
            }
        }

        public bool AddToUser(string login,string email, string password)
        {
            string sql =
                "insert into membre (login,email mdp) values('" + login + "', '" + email + "','" + password + "')";
            int row;
            try
            {
                using (var connection = con.GetConnection())
                {
                    connection.Open();

                    using (command)
                    {
                        command.Connection = connection;
                        command.CommandText = sql;
                        command.CommandType = CommandType.Text;
                        row = command.ExecuteNonQuery();
                    }

                }

                if (row > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                //
            }

            return false;
        }

        //method to send password to user
        public string SendPasswordToUser(string email, string username, string password)
        {
            var mailService = new MailServer.SystemSupportMail();
            mailService.SendMail(
                "GESTION DE PORTEFEUILLE DE PROJET: Votre mot de passe", 
                "Hey, " + username + "\n\n\nYour request to have password" + " votre mot de passe est " + password,
                new List<string>{email}
            );

            return "He! Vos identifiants sont: \n\n E-mail: "+ email + " \n Nom d'utilisateur: " + username + "\n " +
                   " Mot de passe: " + password;
        }

        //login admin
        public bool Login(string login, string password)
        {
            const string sql = "select * from admin where login = @login and mdp = @pass";

            using (var connect = con.GetConnection())
            {
                MySqlDataReader reader;
                
                try
                {
                    connect.Open();
                    using (command)
                    {
                        command.Connection = connect;
                        command.CommandText = sql;
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@pass", password);
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();

                        if (reader.HasRows)
                            return true;
                        else
                            return false;
                    }
                }
                catch
                {
                    //
                }finally{connect.Close();}

                return false;
            }

        }

        //check out data in database
        public bool Checkdata(string nom, string prenom, string email, string login)
        {
            string sql = "select * from utilisateur";
            using (var connection = con.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (command)
                    {
                        command.Connection = connection;
                        command.CommandText = sql;
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();


                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                UserCache.Nom = reader.GetString(1);
                                UserCache.Prenom = reader.GetString(2);
                                UserCache.Email = reader.GetString(3);
                                UserCache.Login = reader.GetString(6);
                            }
                        }

                        if (UserCache.Nom == nom && UserCache.Prenom == prenom &&
                            UserCache.Email == email && UserCache.Login == login)
                            return true;
                        else
                            return false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

        }
    }
}
