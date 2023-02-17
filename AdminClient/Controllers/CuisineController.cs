using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CuisineController : Controller
    {
        public IActionResult CuisineCreate()
        {
            return View();
        }
        public IActionResult CuisineList()
        {
            return View();
        }
        public IActionResult CuisineEdit(int cuisineId)
        {
            ViewBag.cuisineId = cuisineId;
            return View();
        }
    }
}
