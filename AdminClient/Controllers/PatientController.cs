using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult PatientCreate()
        {
            return View();
        }
        public IActionResult PatientList()
        {
            return View();
        }
        public IActionResult PatientEdit(int patientMasterid)
        {
            ViewBag.patientMasterid = patientMasterid;
            return View();
        }
    }
}
