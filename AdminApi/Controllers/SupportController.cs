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
    public class SupportController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Support> _supportRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public SupportController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Support> supportRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _supportRepo = supportRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }
        [HttpPost]
        public IActionResult SupportCreate(SupportDTO supportDTO)
        {
            Support support = new Support();
            support.UserId = supportDTO.UserId;
            support.UserType = supportDTO.UserType;
            support.SupportType = supportDTO.SupportType;
            support.Name = supportDTO.Name;
            support.PhoneNo = supportDTO.PhoneNo;
            support.EmailId = supportDTO.EmailId;
            support.Message = supportDTO.Message;
            support.CreatedBy = supportDTO.CreatedBy;
            var a = _supportRepo.Insert(support);
            return Ok(a);
        }

    }
}
