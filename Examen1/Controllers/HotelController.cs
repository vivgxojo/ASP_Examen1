using Microsoft.AspNetCore.Mvc;
using Examen1.Models;
using System.Reflection;

namespace Examen1.Controllers
{
    public class HotelController : Controller
    {
        List<Hotel> hotels = ListeHotels.liste;

        /// <summary>
        /// Méthode pour afficher la liste d'hôtels
        /// </summary>
        /// <returns>la liste d'hôtels</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Méthode pour chercher un hôtel par ville ou par nom
        /// </summary>
        /// <param name="MotCle">le nom de l'hotel ou de la ville cherchée</param>
        /// <returns>le premier hotel trouvé</returns>
        public IActionResult Rechercher(string MotCle)
        {
            Hotel hotel = hotels.Find(h => h.Nom == MotCle);
            return View("Hotel", hotel);
        }

        public IActionResult Reserver()
        {
            return View();
        }
    }
}
