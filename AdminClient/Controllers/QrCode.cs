using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class QrCode : Controller
    {
        public IActionResult QrCodeCreate()
        {
            return View();
        }
        public IActionResult QrCodeList()
        {
            return View();
        }
    }
}
