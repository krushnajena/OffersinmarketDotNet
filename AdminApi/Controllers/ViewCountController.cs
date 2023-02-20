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
            return Ok(obj);
        }

    }
}
