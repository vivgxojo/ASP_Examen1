namespace Examen1.Models
{
    public class ListeHotels
    {
        public static List<Hotel> liste = new List<Hotel> { 
            new Hotel("1", "Hilton", "Gatineau", 100),
            new Hotel("2", "Ramada", "Gatineau", 50),
            new Hotel("3", "Hilton", "Ottawa", 300),
        };
    }
}
