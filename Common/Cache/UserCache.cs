using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Cache
{
    public static class UserCache
    {
        public static int Id { get; set; }
        public static string Nom { get; set; }
        
        public static string Prenom { get; set; }
        public static string Email { get; set; }
       
        public static int Telephone { get; set; }
       
        public static string Address { get; set; }
        
        public static string Login { get; set; }
        public static string Password { get; set; }
    }
}
