namespace Examen1.Models
{
    public class Utilisateur
    {
        public string Username { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Utilisateur(string username, string nom, string prenom)
        {
            Username = username;
            Nom = nom;
            Prenom = prenom;
        }   
    }
}
