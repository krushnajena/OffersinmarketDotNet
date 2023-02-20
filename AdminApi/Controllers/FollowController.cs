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

    }
}
