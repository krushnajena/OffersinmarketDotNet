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
    public class ViewCountController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<ViewCount> _viewCountRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public ViewCountController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<ViewCount> areaRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _viewCountRepo = areaRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpPost]
        public IActionResult AddViewCount(ViewCountDTO viewCountDTO)
        {
            ViewCount view = new ViewCount();
            view.UserId = viewCountDTO.UserId;
            view.ContentType = viewCountDTO.ContentType;
            view.ContentId = viewCountDTO.ContentId;
            view.CreatedBy = viewCountDTO.CreatedBy;
         
            var obj= _viewCountRepo.Insert(view);
            if(viewCountDTO.ContentType == "Story")
            {
                var objState = _context.Stories.SingleOrDefault(opt => opt.StoryId == viewCountDTO.ContentId);
                if (objState.StoryView != null)
                {
                    objState.StoryView = objState.StoryView + 1;
                    _context.SaveChanges();
                }
                else
                {
                    objState.StoryView =  1;
                    _context.SaveChanges();
                }
              
            }
            else if (viewCountDTO.ContentType == "Product")
            {
                var objState = _context.Products.SingleOrDefault(opt => opt.ProductId == viewCountDTO.ContentId);
                if (objState.ProductView != null)
                {
                    objState.ProductView = objState.ProductView + 1;
                    _context.SaveChanges();
                }
                else
                {
                    objState.ProductView = 1;
                    _context.SaveChanges();
                }
               
              
            }
            return Ok(obj);
        }

        [HttpGet("{QueryType}/{CategoryId}/{StoreId}")]
        public IActionResult GetDashBoardSummery(string QueryType, int CategoryId,int StoreId)
        {
            int days = (int)DateTime.Now.DayOfWeek;
            DateTime lastMonth = DateTime.Now.AddMonths(-1);
            var weekStart = DateTime.Now.AddDays(-days);
            var weekEnd = weekStart.AddDays(6);
            var monthStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var monthEnd = monthStart.AddMonths(1).AddDays(-1);
           
            DateTime dtYesterday = DateTime.Now.Date.AddDays(-1);

            var storeViews =   QueryType == "LifeTime" ? _context.ViewCounts.Where(x => x.ContentType == "store" && x.IsDeleted == false && x.ContentId == StoreId).ToList()
                             : QueryType == "Yesterday" ? _context.ViewCounts.Where(x => x.ContentType == "store" && x.IsDeleted == false && x.CreatedOn.Date == dtYesterday.Date && x.ContentId == StoreId).ToList()
                             : QueryType == "Today" ? _context.ViewCounts.Where(x => x.ContentType == "store" && x.IsDeleted == false && x.CreatedOn.Date == System.DateTime.Today.Date && x.ContentId == StoreId).ToList()
                             : QueryType == "Week" ? _context.ViewCounts.Where(x => x.ContentType == "store" && x.IsDeleted == false && x.CreatedOn.Date >= weekStart.Date && x.CreatedOn.Date <= weekEnd.Date && x.ContentId == StoreId).ToList()
                             : QueryType == "Month" ? _context.ViewCounts.Where(x => x.ContentType == "store" && x.IsDeleted == false && x.CreatedOn.Date >= monthStart.Date && x.CreatedOn.Date <= monthEnd.Date && x.ContentId == StoreId).ToList()

                             : _context.ViewCounts.Where(x => x.ContentType == "store" && x.IsDeleted == false && x.ContentId == StoreId).ToList();



            var followers = QueryType == "LifeTime" ? _context.Followers.Where(x =>  x.IsDeleted == false && x.StoreId == StoreId).ToList()
                           : QueryType == "Yesterday" ? _context.Followers.Where(x => x.IsDeleted == false && x.CreatedOn.Date == dtYesterday.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Today" ? _context.Followers.Where(x =>  x.IsDeleted == false && x.CreatedOn.Date == System.DateTime.Today.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Week" ? _context.Followers.Where(x => x.IsDeleted == false && x.CreatedOn.Date >= weekStart.Date && x.CreatedOn.Date <= weekEnd.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Month" ? _context.Followers.Where(x => x.IsDeleted == false && x.CreatedOn.Date >= monthStart.Date && x.CreatedOn.Date <= monthEnd.Date && x.StoreId == StoreId).ToList()

                           : _context.Followers.Where(x => x.IsDeleted == false && x.StoreId == StoreId).ToList();


            var storeRattings = QueryType == "LifeTime" ? _context.StoreRattings.Where(x => x.IsDeleted == false && x.StoreId == StoreId).ToList()
                           : QueryType == "Yesterday" ? _context.StoreRattings.Where(x => x.IsDeleted == false && x.CreatedOn.Date == dtYesterday.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Today" ? _context.StoreRattings.Where(x => x.IsDeleted == false && x.CreatedOn.Date == System.DateTime.Today.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Week" ? _context.StoreRattings.Where(x => x.IsDeleted == false && x.CreatedOn.Date >= weekStart.Date && x.CreatedOn.Date <= weekEnd.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Month" ? _context.StoreRattings.Where(x => x.IsDeleted == false && x.CreatedOn.Date >= monthStart.Date && x.CreatedOn.Date <= monthEnd.Date && x.StoreId == StoreId).ToList()

                           : _context.StoreRattings.Where(x => x.IsDeleted == false && x.StoreId == StoreId).ToList();


            if (CategoryId == 1)
            {
                var restImages = _context.RestaurantImages.Where(x => x.StoreId == StoreId && x.IsDeleted == false );
                var imageViews = QueryType == "LifeTime" ? _context.ViewCounts.Where(x => x.ContentType == "restimage" && x.IsDeleted == false && restImages.Any(bc => bc.RestaurantImageId == x.ContentId)).ToList()
                                 : QueryType == "Yesterday" ? _context.ViewCounts.Where(x => x.ContentType == "restimage" && x.IsDeleted == false && x.CreatedOn.Date == dtYesterday.Date && restImages.Any(bc => bc.RestaurantImageId == x.ContentId)).ToList()
                                 : QueryType == "Today" ? _context.ViewCounts.Where(x => x.ContentType == "restimage" && x.IsDeleted == false && x.CreatedOn.Date == System.DateTime.Today.Date && restImages.Any(bc => bc.RestaurantImageId == x.ContentId)).ToList()
                                 : QueryType == "Week" ? _context.ViewCounts.Where(x => x.ContentType == "restimage" && x.IsDeleted == false && x.CreatedOn.Date >= weekStart.Date && x.CreatedOn.Date <= weekEnd.Date && restImages.Any(bc => bc.RestaurantImageId == x.ContentId)).ToList()
                                 : QueryType == "Month" ? _context.ViewCounts.Where(x => x.ContentType == "restimage" && x.IsDeleted == false && x.CreatedOn.Date >= monthStart.Date && x.CreatedOn.Date <= monthEnd.Date && restImages.Any(bc => bc.RestaurantImageId == x.ContentId)).ToList()
                                 
                                 : _context.ViewCounts.Where(x => x.ContentType == "restimage" && x.IsDeleted == false && restImages.Any(bc => bc.RestaurantImageId == x.ContentId)).ToList();

                var imageListing = QueryType == "LifeTime" ? _context.RestaurantImages.Where(x => x.IsDeleted == false && x.StoreId == StoreId).ToList()
                           : QueryType == "Yesterday" ? _context.RestaurantImages.Where(x => x.IsDeleted == false && x.CreatedOn.Date == dtYesterday.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Today" ? _context.RestaurantImages.Where(x => x.IsDeleted == false && x.CreatedOn.Date == System.DateTime.Today.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Week" ? _context.RestaurantImages.Where(x => x.IsDeleted == false && x.CreatedOn.Date >= weekStart.Date && x.CreatedOn.Date <= weekEnd.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Month" ? _context.RestaurantImages.Where(x => x.IsDeleted == false && x.CreatedOn.Date >= monthStart.Date && x.CreatedOn.Date <= monthEnd.Date && x.StoreId == StoreId).ToList()

                           : _context.RestaurantImages.Where(x => x.IsDeleted == false && x.StoreId == StoreId).ToList();

                return Ok(
                          new { imageViews = imageViews.Count,
                                storeViews = storeViews.Count, 
                                followers = followers.Count,
                                imageListing = imageListing.Count, 
                                storeRattings = storeRattings.Count }
                        );

            }
            else
            {

                var products = _context.Products.Where(x => x.StoreId == StoreId && x.IsDeleted == false);
                var productViews = QueryType == "LifeTime" ? _context.ViewCounts.Where(x => x.ContentType == "Product" && x.IsDeleted == false && products.Any(bc => bc.ProductId == x.ContentId)).ToList()
                                 : QueryType == "Yesterday" ? _context.ViewCounts.Where(x => x.ContentType == "Product" && x.IsDeleted == false && x.CreatedOn.Date == dtYesterday.Date && products.Any(bc => bc.ProductId == x.ContentId)).ToList()
                                 : QueryType == "Today" ? _context.ViewCounts.Where(x => x.ContentType == "Product" && x.IsDeleted == false && x.CreatedOn.Date == System.DateTime.Today.Date && products.Any(bc => bc.ProductId == x.ContentId)).ToList()
                                 : QueryType == "Week" ? _context.ViewCounts.Where(x => x.ContentType == "Product" && x.IsDeleted == false && x.CreatedOn.Date >= weekStart.Date && x.CreatedOn.Date <= weekEnd.Date && products.Any(bc => bc.ProductId == x.ContentId)).ToList()
                                 : QueryType == "Month" ? _context.ViewCounts.Where(x => x.ContentType == "Product" && x.IsDeleted == false && x.CreatedOn.Date >= monthStart.Date && x.CreatedOn.Date <= monthEnd.Date && products.Any(bc => bc.ProductId == x.ContentId)).ToList()

                                 : _context.ViewCounts.Where(x => x.ContentType == "Product" && x.IsDeleted == false && products.Any(bc => bc.ProductId == x.ContentId)).ToList();

                var productListing = QueryType == "LifeTime" ? _context.Products.Where(x => x.IsDeleted == false && x.StoreId == StoreId).ToList()
                           : QueryType == "Yesterday" ? _context.Products.Where(x => x.IsDeleted == false && x.CreatedOn.Date == dtYesterday.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Today" ? _context.Products.Where(x => x.IsDeleted == false && x.CreatedOn.Date == System.DateTime.Today.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Week" ? _context.Products.Where(x => x.IsDeleted == false && x.CreatedOn.Date >= weekStart.Date && x.CreatedOn.Date <= weekEnd.Date && x.StoreId == StoreId).ToList()
                           : QueryType == "Month" ? _context.Products.Where(x => x.IsDeleted == false && x.CreatedOn.Date >= monthStart.Date && x.CreatedOn.Date <= monthEnd.Date && x.StoreId == StoreId).ToList()

                           : _context.Products.Where(x => x.IsDeleted == false && x.StoreId == StoreId).ToList();

                return Ok(
                          new
                          {
                              productViews = productViews.Count,
                              storeViews = storeViews.Count,
                              followers = followers.Count,
                              productListing = productListing.Count,
                              storeRattings = storeRattings.Count
                          }
                        );
                
            }

        }
    }
}
