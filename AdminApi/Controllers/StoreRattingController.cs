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
    public class StoreRattingController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<StoreRatting> _storeRattingRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public StoreRattingController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<StoreRatting> areaRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _storeRattingRepo = areaRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }


        [HttpPost]
        public IActionResult ApplyStoreRatting(StoreRatttingDTO storeRatttingDTO)
        {
            var objCheck = _context.StoreRattings.SingleOrDefault(opt => opt.StoreId == storeRatttingDTO.StoreId && opt.IsDeleted == false && opt.UserId == storeRatttingDTO.UserId);
            if(objCheck == null)
            {
                StoreRatting storeRatting = new StoreRatting();
                storeRatting.StoreId = storeRatttingDTO.StoreId;
                storeRatting.UserId = storeRatttingDTO.UserId;
                storeRatting.AppliedRatting = storeRatttingDTO.AppliedRatting;
                storeRatting.CreatedBy = storeRatttingDTO.CreatedBy;
                var a = _storeRattingRepo.Insert(storeRatting);
                return Ok(a);
            }
            else
            {
                objCheck.AppliedRatting = storeRatttingDTO.AppliedRatting;
                objCheck.UpdatedOn = System.DateTime.Now;
                objCheck.UpdatedBy = storeRatttingDTO.CreatedBy;
                _context.SaveChanges();
                return Ok(objCheck);
            }

        }

        [HttpGet("{StoreId}/{UserId}")]
        public IActionResult GetRattingsByStoreId(int StoreId,int UserId)
        {
            var objStores = _context.Stores.Include(s => s.StoreRattings)
                                        .Include(s => s.Followers)
                                            .Include(s => s.Products
                                               ).ThenInclude(s => s.ProductImages)
                    .Select(p => new
                    {
                        StoreId = p.StoreId,
                        StoreName = p.StoreName,

                        StoreCode = p.StoreCode,
                        UserId = p.UserId,

                        CategoryId = p.CategoryId,
                        OwnerName = p.OwnerName,

                        BusineessContactInfo = p.BusineessContactInfo,
                        BusinessLogo = p.BusinessLogo,

                        Lat = p.Lat,
                        Long = p.Long,

                        Address = p.Address,
                        Landmark = p.Landmark,

                        StateId = p.StateId,
                        CityId = p.CityId,

                        AreaId = p.AreaId,
                        IsSundayOpen = p.IsSundayOpen,
                        SundayOpenTime = p.SundayOpenTime,
                        SundayCloseTime = p.SundayCloseTime,
                        IsMondayOpen = p.IsMondayOpen,
                        MondayOpenTime = p.MondayOpenTime,
                        MondayCloseTime = p.MondayCloseTime,
                        IsTuesdayOpen = p.IsTuesdayOpen,
                        TuesdayOpenTime = p.TuesdayOpenTime,
                        TuesdayCloseTime = p.TuesdayCloseTime,
                        IsWednessdayOpen = p.IsWednessdayOpen,
                        WednessdayOpenTime = p.WednessdayOpenTime,
                        WednessdayCloseTime = p.WednessdayCloseTime,

                        IsThursdayOpen = p.IsThursdayOpen,
                        ThursdayOpenTime = p.ThursdayOpenTime,
                        ThursdayCloseTime = p.ThursdayCloseTime,

                        IsFridayOpen = p.IsFridayOpen,
                        FridayOpenTime = p.FridayOpenTime,

                        FridayCloseTime = p.FridayCloseTime,
                        IsSaturdayOpen = p.IsSaturdayOpen,

                        SaturdayOpenTime = p.SaturdayOpenTime,
                        SaturdayCloseTime = p.SaturdayCloseTime,
                        RefferedBy = p.RefferedBy,
                        IsDeleted = p.IsDeleted,
                        Rattings = p.StoreRattings.Where(c => c.IsDeleted == false),
                        Ratting = p.StoreRattings.Where(c => c.IsDeleted == false).Average(l => l.AppliedRatting),
                        IRattings = p.StoreRattings.Where(c => c.IsDeleted == false && c.UserId == UserId),
                        Followers = p.Followers.Where(c => c.IsDeleted == false),
                        IFollow = p.Followers.Where((c => c.IsDeleted == false && c.UserId == UserId)),
                        



                    }).SingleOrDefault(opt => opt.StoreId == StoreId && opt.IsDeleted == false);

            return Ok(objStores);
        }



    }
}
