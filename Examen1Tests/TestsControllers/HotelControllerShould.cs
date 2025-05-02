using Microsoft.AspNetCore.Mvc;
using Examen1.Controllers;
using Examen1.Models;

namespace Examen1Tests.Contrellers
{
    public class HotelControllerShould
    {
        [Fact]
        public void RechercherShouldReturnView()
        {
            HotelController controller = new HotelController();
            var result = controller.Rechercher("Gatineau");
            var vw = Assert.IsType<ViewResult>(result);
            Assert.NotNull(vw.Model);
            var model = Assert.IsType<Hotel>(vw.Model);

        }
    }
}