using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class FoodTypeController : Controller
    {
        public IActionResult FoodtypeCreate()
        {
            return View();
        }

        public IActionResult FoodTypeList()
        {
            return View();
        }

        public IActionResult FoodtypeEdit(int foodTypeMasterId)
        {
            ViewBag.foodTypeMasterId = foodTypeMasterId;
            return View();
        }
    }
}
