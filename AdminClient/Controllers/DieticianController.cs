using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class DieticianController : Controller
    {
        public IActionResult DieticianCreate()
        {
            return View();
        }
        public IActionResult DieticianList()
        {
            return View();
        }

        public IActionResult DieticianEdit(int dieticianMasterId)
        {
            ViewBag.dieticianMasterId = dieticianMasterId;
            return View();
        }
    }
}
