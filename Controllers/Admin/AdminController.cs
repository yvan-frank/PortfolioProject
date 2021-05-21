using Models;
using Models.AdminModel;

namespace Controllers.Admin
{
    public class AdminController:Utilisateur
    {
        AdminModels adminModels = new AdminModels();
        public void AddUser(string nom, string prenom, string email, string telephone, string adresse, string login,
            string password, int typeUser)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Telephone = int.Parse(telephone);
            Address = adresse;
            Login = login;
            Password = password;

            adminModels.AddUser(Nom, Prenom, Email, Telephone, Address, Login, Password, typeUser);
        }

        public bool LoginAdmin(string username, string password)
        {
            return adminModels.Login(username, password);
        }

        public bool AddToUser(string login, string email, string pass)
        {
            return adminModels.AddToUser(Login, Email, Password);
        }

        //
        public string SendEmailPasswordToUser(string email, string username, string password)
        {
            return adminModels.SendPasswordToUser(email, username, password);
        }
    }
}
