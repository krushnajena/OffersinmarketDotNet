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
    public class RestaurantImageController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<RestaurantImage> _restaurentImageRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public RestaurantImageController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<RestaurantImage> stateRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _restaurentImageRepo = stateRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }
        [HttpPost]
        public IActionResult CreateResturentImage(RestaurantImageDTO restaurantImageDTO)
        {
            RestaurantImage restaurantImage = new RestaurantImage();
            restaurantImage.Image = restaurantImageDTO.Image;
            restaurantImage.StoreId = restaurantImageDTO.StoreId;
            restaurantImage.ImageType = restaurantImageDTO.ImageType;
            restaurantImage.Text = restaurantImageDTO.Text;
            restaurantImage.CreatedBy = restaurantImageDTO.CreatedBy;
            restaurantImage.IsActive = false;
            var a = _restaurentImageRepo.Insert(restaurantImage);
            return Ok(a);
        }
        [HttpGet("{StoreId}")]
        public IActionResult GetResturentImagesStoreSide(int StoreId)
        {
            try
            {
                var banner = (from u in _context.RestaurantImages
                            select new
                            {
                                u.RestaurantImageId,
                                u.StoreId,
                                u.Image,
                                u.ImageType,
                                u.Text,
                                u.CreatedBy,
                                u.IsActive,
                                u.IsDeleted

                            }


                            ).Where(x => x.IsDeleted == false && x.StoreId == StoreId && x.ImageType == "Banner").ToList();

                var menu = (from u in _context.RestaurantImages
                              select new
                              {
                                  u.RestaurantImageId,
                                  u.StoreId,
                                  u.Image,
                                  u.ImageType,
                                  u.Text,
                                  u.CreatedBy,
                                  u.IsActive,
                                  u.IsDeleted

                              }


                            ).Where(x => x.IsDeleted == false && x.StoreId == StoreId && x.ImageType == "Menu").ToList();

                var ambiance = (from u in _context.RestaurantImages
                            select new
                            {
                                u.RestaurantImageId,
                                u.StoreId,
                                u.Image,
                                u.ImageType,
                                u.Text,
                                u.CreatedBy,
                                u.IsActive,
                                u.IsDeleted

                            }


                           ).Where(x => x.IsDeleted == false && x.StoreId == StoreId && x.ImageType == "Ambience").ToList();

                var food = (from u in _context.RestaurantImages
                                select new
                                {
                                    u.RestaurantImageId,
                                    u.StoreId,
                                    u.Image,
                                    u.ImageType,
                                    u.Text,
                                    u.CreatedBy,
                                    u.IsActive,
                                    u.IsDeleted

                                }


                          ).Where(x => x.IsDeleted == false && x.StoreId == StoreId && x.ImageType == "Food").ToList();

                return Ok(new { banner = banner, food = food, ambiance = ambiance , menu = menu });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{RestaurantImageId}/{CreatedBy}")]
        public IActionResult DeleteResturentImages(int RestaurantImageId,int CreatedBy)
        {
            try
            {
                var objState = _context.RestaurantImages.SingleOrDefault(opt => opt.RestaurantImageId == RestaurantImageId);
                objState.IsDeleted = true;
                objState.UpdatedBy = CreatedBy;
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
