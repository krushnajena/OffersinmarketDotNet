using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class BedController : Controller
    {
        public IActionResult BedCreate()
        {
            return View();
        }

        public IActionResult BedList()
        {
            return View();
        }

        public IActionResult BedEdit(int bedMasterId)
        {
            ViewBag.bedMasterId = bedMasterId;
            return View();
        }
    }
}
