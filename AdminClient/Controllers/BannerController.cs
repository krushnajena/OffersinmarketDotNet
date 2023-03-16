using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class BannerController : Controller
    {
        public IActionResult BannerCreate()
        {
            return View();
        }
        public IActionResult BannerList()
        {
            return View();
        }
        public IActionResult BannerEdit(int bannerId)
        {
            ViewBag.bannerId = bannerId;
            return View();
        }
    }
}
