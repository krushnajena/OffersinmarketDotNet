using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult AreaCreate()
        {
            return View();
        }
        public IActionResult AreaList()
        {  
            return View();
        }
        public IActionResult AreaEdit(int areaId)
        {
            ViewBag.areaId = areaId;
            return View();
        }
    }
}
