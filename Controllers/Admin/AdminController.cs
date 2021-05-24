using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Models;
using Models.AdminModel;

namespace Controllers.Admin
{
    public class AdminController
    {
        AdminModels adminModels = new AdminModels();

        public bool LoginAdmin(string username, string password)
        {
            return adminModels.Login(username, password);
        }

        public bool AddToUser(Utilisateur user)
        {
            return adminModels.AddToUser(user.Login, user.Email, user.Password);
        }


        public void AddUserAdmin(Utilisateur user  ,int typeUser)
        {
            adminModels.AddUser(user.Nom, user.Prenom, user.Email, user.Telephone, user.Address, 
                user.Login, user.Password, typeUser);
        }


        public string SendEmailPasswordToUser(Utilisateur user)
        {
            return adminModels.SendPasswordToUser(user.Email,user.Login, user.Password);
        }

        public bool Checkdata(Utilisateur user)
        {
            return adminModels.Checkdata(user.Nom, user.Prenom, user.Email,user.Login);
        }
    }
}
