using AdminApi.DTO.App;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CuisineController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Cuisine> _cuisineRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public CuisineController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Cuisine> cuisineRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _cuisineRepo = cuisineRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpPost]
        public IActionResult CreateCuisine(CusineDTO cusineDTO)
        {
            var objCheck = _context.Cuisines.SingleOrDefault(opt => opt.CuisineName == cusineDTO.CuisineName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    Cuisine cuisine = new Cuisine();
                    cuisine.CuisineName = cusineDTO.CuisineName;
                    cuisine.CreatedBy = cusineDTO.CreatedBy;

                    var obj = _cuisineRepo.Insert(cuisine);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation
                {
                    Status = "error",
                    ResponseMsg = ex.Message
                });
            }
        }



        [HttpGet]
        public IActionResult GetCuisineList()
        {
            try
            {
                var list = (from u in _context.Cuisines
                            select new
                            {
                                u.CuisineName,
                                u.CuisineId,
                                u.IsDeleted

                            }


                            ).Where(x => x.IsDeleted == false).ToList();

                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{id}")]
        public ActionResult GetSingleCuisine(int id)
        {
            try
            {
                var singleState = _cuisineRepo.SelectById(id);
                return Ok(singleState);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult UpdateCuisine(CusineUpdateDTO cusineUpdateDTO)
        {
            try
            {
                var objState = _context.Cuisines.SingleOrDefault(opt => opt.CuisineId == cusineUpdateDTO.CuisineId);
                objState.CuisineName = cusineUpdateDTO.CuisineName;
                objState.UpdatedBy = cusineUpdateDTO.CreatedBy;
                objState.UpdatedOn = System.DateTime.Now; ;
                _context.SaveChanges();
                return Ok(objState);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult DeleteCuisine(CusineUpdateDTO cusineUpdateDTO)
        {
            try
            {
                var objState = _context.Cuisines.SingleOrDefault(opt => opt.CuisineId == cusineUpdateDTO.CuisineId);
                objState.IsDeleted = false;
                objState.UpdatedBy = cusineUpdateDTO.CreatedBy;
                objState.UpdatedOn = System.DateTime.Now; ;
                _context.SaveChanges();
                return Ok(objState);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


    }
}
