using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers.Admin;
using Models;
using Models.AdminModel;
using MySql.Data.MySqlClient;

namespace TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminController useController = new AdminController()
            {
               
            };

            var user = new Utilisateur()
            {
                Nom = "Ngoban",
                Prenom = "yvan",
                Email = "yavn!@jnjds.com",
                Telephone = 21556,
                Address = "contoller",
                Login = "vans",
                Password = "vans"
            };


            useController.AddUserAdmin(user, 2);

            if (user != null)
            {
                Console.WriteLine("insertion termine");
            }

            Console.ReadKey();
        }
    }
}