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
    public class RestaurantCuisineController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<RestaurantCuisine> _cusineRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public RestaurantCuisineController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<RestaurantCuisine> cuisineRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _cusineRepo = cuisineRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpPost]
        public IActionResult CreateResturentCuisine(ResturentCuisineDTO resturentCuisineDTO)
        {
            var list = (from u in _context.RestaurantCuisines
                        select new
                        {
                           
                            u.IsDeleted,
                            u.StoreId,
                            u.RestaurantCuisineId

                        }


                          ).Where(x => x.IsDeleted == false && x.StoreId == resturentCuisineDTO.StoreId).ToList();
            for(int i = 0; i < list.Count; i++)
            {
                var objState = _context.RestaurantCuisines.SingleOrDefault(opt => opt.RestaurantCuisineId == list[i].RestaurantCuisineId);
                objState.IsDeleted = false;
                objState.UpdatedBy = resturentCuisineDTO.CreatedBy;
                objState.UpdatedOn = System.DateTime.Now; ;
                _context.SaveChanges();
            }
            for(int i=0;i< resturentCuisineDTO.resturentCus.Count; i++)
            {
                RestaurantCuisine restaurant = new RestaurantCuisine();
                restaurant.StoreId = resturentCuisineDTO.StoreId;
                restaurant.CusineId = resturentCuisineDTO.resturentCus[i].CusineId;
                restaurant.CreatedBy = resturentCuisineDTO.CreatedBy;
                _cusineRepo.Insert(restaurant);
            }
            return Ok(resturentCuisineDTO);
        }

        [HttpGet("{StoreId}")]
        public IActionResult GetResturentCuisine(int StoreId)
        {
            var list = (from u in _context.RestaurantCuisines
                        join r in _context.Cuisines on u.CusineId equals r.CuisineId
                        select new
                        {
                            u.CusineId,
                            r.CuisineName,
                            u.StoreId,
                            u.IsDeleted

                        }


                           ).Where(x => x.IsDeleted == false && x.StoreId == StoreId).ToList();

            return Ok(list);
        }

    }
}
