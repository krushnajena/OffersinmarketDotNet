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
    public class BannerController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Banner> _bannerRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public BannerController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Banner> bannerRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _bannerRepo = bannerRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CreateBanner(BannerDTO bannerDto)
        {
            Banner banner = new Banner();
            banner.BannerType = bannerDto.BannerType;
            banner.OnClickType = bannerDto.OnClickType;
            banner.OnClickId = bannerDto.OnClickId;
            banner.Image = bannerDto.Image;
            banner.CreatedBy = bannerDto.CreatedBy;
            var obj = _bannerRepo.Insert(banner);
            return Ok(obj);

        }
        [HttpGet("{bannerType}")]
        public IActionResult GetBannersByBannerType(string bannerType)
        {
            var banner = (from u in _context.Banners
                          select new
                          {
                              u.BannerType,
                              u.OnClickType,
                              u.OnClickId,
                              u.Image,
                              u.BannerId,
                              u.CreatedBy,
                             
                              u.IsDeleted

                          }


                          ).Where(x => x.IsDeleted == false && x.BannerType == bannerType).ToList();
            return Ok(banner);
        }

        [HttpGet]
        public IActionResult GetBannerList()
        {
            try
            {
                var banner = (from u in _context.Banners
                              join z in _context.Stores on u.OnClickId equals z.StoreId
                              select new
                              {
                                  u.BannerType,
                                  u.OnClickType,
                                  u.OnClickId,
                                  z.StoreName,
                                  u.Image,
                                  u.BannerId,
                                  u.CreatedBy,

                                  u.IsDeleted

                              }


                             ).Where(x => x.IsDeleted == false);

                int totalRecords = banner.Count();
                return Ok(new { data = banner, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetSingleBanner(int id)
        {
            try
            {
                var singleBanner = _bannerRepo.SelectById(id);
                return Ok(singleBanner);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult UpdateBanner(UpdateBannerDTO updateBannerDTO)
        {
            try
            {
                try
                {
                    var objBanner = _context.Banners.SingleOrDefault(opt => opt.BannerId == updateBannerDTO.BannerId);
                    objBanner.BannerType = updateBannerDTO.BannerType;
                    objBanner.OnClickType = updateBannerDTO.OnClickType;
                    objBanner.OnClickId = updateBannerDTO.OnClickId;
                    objBanner.Image = updateBannerDTO.Image;
                    objBanner.UpdatedBy = updateBannerDTO.CreatedBy;
                    objBanner.UpdatedOn = System.DateTime.Now; ;
                    _context.SaveChanges();
                    return Ok(objBanner);
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
        [HttpGet("{Bannerid}/{DeletedBy}")]
        public ActionResult DeleteBanner(int Bannerid, int DeletedBy)
        {
            try
            {
                var Banner = _context.Banners.SingleOrDefault(opt => opt.BannerId == Bannerid);
                Banner.IsDeleted = true;
                Banner.UpdatedBy = DeletedBy;
                Banner.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(Banner);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
