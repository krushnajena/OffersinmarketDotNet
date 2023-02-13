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
    public class CityController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<City> _cityRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public CityController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<City> cityRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _cityRepo = cityRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CreateCity(CityDTO cityDTO)
        {
            var objCheck = _context.Cities.SingleOrDefault(opt => opt.CityName == cityDTO.CityName && opt.IsDeleted == false && opt.StateId ==  cityDTO.StateId);
            try
            {
                if (objCheck == null)
                {
                    City city = new City();
                    city.StateId = cityDTO.StateId;
                    city.CityName = cityDTO.CityName;
                    city.CreatedBy = cityDTO.CreatedBy;
                    var obj = _cityRepo.Insert(city);
                    return Ok(obj);
                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Category!" });
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
        public IActionResult GetCityList()
        {
            try
            {
                var list = (from u in _context.Cities
                            join r in _context.States on u.StateId equals r.StateId
                            select new
                            {
                                u.StateId,
                                r.StateName,
                                u.CityId   ,
                                u.CityName,
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

        [HttpGet]
        public IActionResult GetCitiesList()
        {
            try
            {
                var list = (from u in _context.Cities
                            join r in _context.States on u.StateId equals r.StateId
                            select new
                            {
                                u.StateId,
                                r.StateName,
                                u.CityId,
                                u.CityName,
                                u.IsDeleted

                            }


                            ).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{StateId}")]
        public IActionResult GetCityListByStateId(int StateId)
        {
            try
            {
                var list = (from u in _context.Cities
                            join r in _context.States on u.StateId equals r.StateId
                            select new
                            {
                                u.StateId,
                                r.StateName,
                                u.CityId,
                                u.CityName,
                                u.IsDeleted

                            }


                            ).Where(x => x.IsDeleted == false && x.StateId == StateId).ToList();

                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{id}")]
        public ActionResult GetSingleCity(int id)
        {
            try
            {
                var singleCity = _cityRepo.SelectById(id);
                return Ok(singleCity);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult UpdateCity(CityUpdateDTO cityUpdateDTO)
        {
            try
            {
                try
                {
                    var objState = _context.Cities.SingleOrDefault(opt => opt.CityId == cityUpdateDTO.CityId);
                    objState.CityName = cityUpdateDTO.CityName;
                    objState.StateId = cityUpdateDTO.StateId;
                    objState.UpdatedBy = cityUpdateDTO.CreatedBy;
                    objState.UpdatedOn = System.DateTime.Now; ;
                    _context.SaveChanges();
                    return Ok(objState);
                }
                catch (Exception ex)
                {
                    return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [Authorize(Roles = "Admin")]
        [HttpGet("{cityid}/{DeletedBy}")]
        public ActionResult DeleteCity(int cityid, int DeletedBy)
        {
            try
            {
                var city = _context.Cities.SingleOrDefault(opt => opt.CityId == cityid);
                city.IsDeleted = true;
                city.UpdatedBy = DeletedBy;
                city.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(city);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


    }
}
