namespace Examen1.Models
{
    public class Hotel
    {
        public string NoEnregistrement;
        public string Nom;
        public string Ville;
        public int NbChambres;

        public Hotel(string noEnregistrement, string nom, string ville, int nbChambres)
        {
            NoEnregistrement = noEnregistrement;
            Nom = nom;
            Ville = ville;
            NbChambres = nbChambres;
        }
    }
}
