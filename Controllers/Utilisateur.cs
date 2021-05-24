using System.ComponentModel.DataAnnotations;

namespace Controllers
{
    public class Utilisateur
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le champ nom est vide")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le champ prénom est vide")]
        public string Prenom { get; set; }
        [Required(ErrorMessage = "Le champ Email est vide"), 
         EmailAddress(ErrorMessage = "L'adresse email que vous avez entré n'est valide")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Le champ numéro de téléphone est vide")]
        public int Telephone { get; set; }
        [Required(ErrorMessage = "Le champ adresse est vide")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner un identifiant valide")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner un mot de passe valide")]
        public string Password { get; set; }

    }

    public class LoginConnection:Utilisateur
    {
        public LoginConnection(string username, string password)
        {
            Login = username;
            Password = password;
        }
    }
}
