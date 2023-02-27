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
    public class PopularStoreController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PopularStore> _pouplarStoreRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public PopularStoreController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<PopularStore> areaRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _pouplarStoreRepo = areaRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetPopularStoresForUserHome()
        {
            try
            {
                var list = (from u in _context.PopularStores
                            join r in _context.Stores on u.StoreId equals r.StoreId
                            join k in _context.Categories on r.CategoryId equals k.CategoryId
                            select new
                            {
                                u.StoreId,
                                r.StoreName,
                                r.BusinessLogo,
                                k.CategoryName,
                                k.CategoryId,
                                u.IsDeleted

                            }


                            ).Where(x => x.IsDeleted == false).ToList();

                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
