using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CityController : Controller
    {
        public IActionResult CityCreate()
        {
            return View();
        }
        public IActionResult CityList()
        {
            return View();
        }
        public IActionResult CityEdit(int cityId)
        {
            ViewBag.cityId = cityId;
            return View();
        }
    }
}
