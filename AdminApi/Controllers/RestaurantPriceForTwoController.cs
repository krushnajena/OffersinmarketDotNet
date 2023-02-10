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
    public class RestaurantPriceForTwoController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<RestaurantPriceForTwo> _priceForTwoRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public RestaurantPriceForTwoController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<RestaurantPriceForTwo> cuisineRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _priceForTwoRepo = cuisineRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }
        [HttpPost]
        public IActionResult CreateAndUpdatePriceForTwo(RestaurantPriceForTwoDTO restaurantPriceForTwoDTO)
        {
            var objCheck = _context.RestaurantPriceForTwos.SingleOrDefault(opt => opt.StoreId == restaurantPriceForTwoDTO.StoreId && opt.IsDeleted == false);
            if (objCheck == null)
            {
                RestaurantPriceForTwo restaurantPriceForTwo = new RestaurantPriceForTwo();
                restaurantPriceForTwo.StoreId = restaurantPriceForTwoDTO.StoreId;
                restaurantPriceForTwo.Price = restaurantPriceForTwoDTO.Price;
                restaurantPriceForTwo.About = restaurantPriceForTwoDTO.About;
                restaurantPriceForTwo.CreatedBy = restaurantPriceForTwoDTO.CreatedBy;
                var obj = _priceForTwoRepo.Insert(restaurantPriceForTwo);
                return Ok(obj);
            }
            else
            {
                objCheck.Price = restaurantPriceForTwoDTO.Price;
                objCheck.About = restaurantPriceForTwoDTO.About;
                objCheck.UpdatedBy = restaurantPriceForTwoDTO.CreatedBy;
                objCheck.UpdatedOn = System.DateTime.Now; ;
                _context.SaveChanges();
                return Ok(objCheck);
            }
        }
        [HttpGet("{StoreId}")]
        public IActionResult GetPriceForTwoDetailsByStoreId(int StoreId)
        {
            var objCheck = _context.RestaurantPriceForTwos.SingleOrDefault(opt => opt.StoreId == StoreId && opt.IsDeleted == false);
            return Ok(objCheck);

        }
    }
}
