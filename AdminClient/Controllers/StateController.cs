using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class StateController : Controller
    {
        public IActionResult StateCraete()
        {
            return View();
        }
        public IActionResult StateList()
        {
            return View();
        }
        public IActionResult StateEdit(int stateId)
        {
            ViewBag.stateId = stateId;
            return View();
        }
    }
}
