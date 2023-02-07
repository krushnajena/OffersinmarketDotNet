using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class PatientDietController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
