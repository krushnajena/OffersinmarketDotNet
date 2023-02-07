using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class FoodProviderLoginController : Controller
    {
        public IActionResult FPLoginCreate()
        {
            return View();
        }
        public IActionResult FPLoginList()
        {
            return View();
        }

        public IActionResult FPLoginEdit(int foodProviderLoginId)
        {
            ViewBag.foodProviderLoginId = foodProviderLoginId;
            return View();
        }
    }
}
