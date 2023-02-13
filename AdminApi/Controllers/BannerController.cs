﻿using AdminApi.DTO.App;
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
    }
}
