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
    public class AreaController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Area> _areaRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public AreaController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Area> areaRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _areaRepo = areaRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CreateArea(AreaDTO areaDTO)
        {
            var objCheck = _context.Areas.SingleOrDefault(opt => opt.AreaName == areaDTO.AreaName&& opt.IsDeleted == false && opt.CityId == areaDTO.CityId);
            try
            {
                if (objCheck == null)
                {
                    Area area = new Area();
                    area.CityId = areaDTO.CityId;
                    area.AreaName = areaDTO.AreaName;
                    area.CreatedBy = areaDTO.CreatedBy;
                    var obj = _areaRepo.Insert(area);
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
        public IActionResult GetAreaList()
        {
            try
            {
                var list = (from u in _context.Areas
                            join l in _context.Cities on u.CityId equals l.CityId
                            join r in _context.States on l.StateId equals r.StateId
                            select new
                            {
                               u.AreaName,
                                u.AreaId,
                                u.CityId,
                                r.StateName,
                           
                                l.CityName,
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
        public IActionResult GetAreasList()
        {
            try
            {
                var list = (from u in _context.Areas
                            join l in _context.Cities on u.CityId equals l.CityId
                            join r in _context.States on l.StateId equals r.StateId
                            select new
                            {
                                u.AreaName,
                                u.AreaId,
                                u.CityId,
                                r.StateName,

                                l.CityName,
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


        [HttpGet("{CityId}")]
        public IActionResult GetAreaListByCityId(int CityId)
        {
            try
            {
                var list = (from u in _context.Areas
                            join l in _context.Cities on u.CityId equals l.CityId
                            join r in _context.States on l.StateId equals r.StateId
                            select new
                            {
                                u.AreaName,
                                u.AreaId,
                                u.CityId,
                                r.StateName,

                                l.CityName,
                                u.IsDeleted

                            }


                            ).Where(x => x.IsDeleted == false && x.CityId== CityId).ToList();

                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleArea(int id)
        {
            try
            {
                var singleCity = _areaRepo.SelectById(id);
                return Ok(singleCity);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult UpdateArea(AreaUpdateDTO areaUpdateDTO)
        {
            try
            {
                try
                {
                    var objState = _context.Areas.SingleOrDefault(opt => opt.AreaId == areaUpdateDTO.AreaId);
                    objState.AreaName = areaUpdateDTO.AreaName;
                    objState.CityId = areaUpdateDTO.CityId;
                    objState.UpdatedBy = areaUpdateDTO.CreatedBy;
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
        [HttpGet("{areaid}/{DeletedBy}")]
        public ActionResult DeleteArea(int areaid, int DeletedBy)
        {
            try
            {
                var Area = _context.Areas.SingleOrDefault(opt => opt.AreaId == areaid);
                Area.IsDeleted = true;
                Area.UpdatedBy = DeletedBy;
                Area.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(Area);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
