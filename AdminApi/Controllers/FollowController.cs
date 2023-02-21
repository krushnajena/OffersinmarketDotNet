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
    public class FollowController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Follower> _followerRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public FollowController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Follower> areaRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _followerRepo = areaRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpGet("{StoreId}/{UserId}")]
        public IActionResult FollowUnFollow(int StoreId, int UserId)
        {
            var objCheck = _context.Followers.SingleOrDefault(opt => opt.UserId == UserId && opt.StoreId == StoreId && opt.IsDeleted == false);
            if (objCheck == null)
            {
                Follower follower = new Follower();
                follower.UserId = UserId;   
                follower.StoreId = StoreId;
                follower.CreatedBy = UserId;
                _followerRepo.Insert(follower);
                return Ok(new { followstatus = "Followed Successfully" });
            }
            else
            {
                objCheck.IsDeleted = true;
                objCheck.UpdatedBy= UserId;
                objCheck.UpdatedOn=System.DateTime.Now;
                _context.SaveChanges();
                return Ok(new { followstatus = "UnFollowed Successfully" });
            }
        }

        [HttpGet("{UserId}")]
        public IActionResult GetMyFollowedStores(int UserId) {
            var list = (from u in _context.Followers
                        join r in _context.Stores on u.StoreId equals r.StoreId
                        join l in _context.Categories on r.CategoryId equals l.CategoryId
                        join c in _context.Cities on r.CityId equals c.CityId
                        join a in _context.Areas on r.AreaId equals a.AreaId
                        select new
                        {
                            u.UserId,
                            u.IsDeleted,

                            r.StoreId,
                            r.StoreCode,
                            r.StoreName,

                          
                            r.OwnerName,
                            r.BusineessContactInfo,

                            r.BusinessLogo,
                            r.Lat,
                            r.Long,
                            r.CategoryId,
                            r.CityId,
                            r.AreaId,

                            r.Address,
                            r.Landmark,
                            l.CategoryName,
                            c.CityName,
                            a.AreaName


                        }


                        ).Where(x => x.IsDeleted == false && x.UserId == UserId).ToList();

            return Ok(list);
        }

    }
}
