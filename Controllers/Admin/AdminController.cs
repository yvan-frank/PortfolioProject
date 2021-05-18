using Models;
using Models.AdminModel;

namespace Controllers.Admin
{
    public class AdminController
    {
        AdminModels adminModels = new AdminModels();
        public void AddUser(string nom, string prenom, string email, string telephone, string adresse, string login,
            string password, int typeUser)
        {
            adminModels.AddUser(nom, prenom,email,int.Parse(telephone), adresse,login,password,typeUser);
        }

        public bool LoginAdmin(string username, string password)
        {
            return adminModels.Login(username, password);
        }
    }
}
