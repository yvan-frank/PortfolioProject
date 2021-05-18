
namespace Models
{
    public class Utilisateur
    {
        public Utilisateur(int id, string nom, string prenom, string email, int telephone, string adresse, string login, string password)
        {
            this._id = id;
            this._nom = nom;
            this._prenom = prenom;
            this._email = email;
            this._telephone = telephone;
            this._adresse = adresse;
            this._login = login;
            this._password = password;
        }

        public Utilisateur( string nom, string prenom, string email, int telephone, string adresse, string login, string password)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._email = email;
            this._telephone = telephone;
            this._adresse = adresse;
            this._login = login;
            this._password = password;
        }

        public Utilisateur(string login, string password)
        {
            this._login = login;
            this._password = password;
        }

        public Utilisateur()
        {

        }

        public void SetId(int id)
        {
            this._id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public void SetNom(string nom)
        {
            this._nom = nom;
        }

        public string GetNom()
        {
            return _nom;
        }

        public void SetPrenom(string prenom)
        {
            this._prenom = prenom;
        }

        public string GetPrenom()
        {
            return _prenom;
        }

        public void SetEmail(string email)
        {
            this._email = email;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetTelephone(int telephone)
        {
            this._telephone = telephone;
        }

        public int GetTelephone()
        {
            return _telephone;
        }

        public void SetAdresse(string adresse)
        {
            this._adresse = adresse;
        }

        public string Getadresse()
        {
            return _adresse;
        }

        public void SetLogin(string login)
        {
            this._login = login;
        }

        public string GetLogin()
        {
            return _login;
        }

        public void SetPassword(string password)
        {
            this._password = password;
        }

        public string GetPassword()
        {
            return _password;
        }


        private int _id;
        private string _nom;
        private string _prenom;
        private string _email;
        private int _telephone;
        private string _adresse;
        private string _login;
        private string _password;

    }
}
