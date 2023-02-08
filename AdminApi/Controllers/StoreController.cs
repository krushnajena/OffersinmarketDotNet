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
    public class StoreController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Store> _storeRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public StoreController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Store> storeRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _storeRepo = storeRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpPost]
        public IActionResult CreateStore(StoreDTO storeDTO)
        {
            var objCheck = _context.Stores.SingleOrDefault(opt => opt.UserId == storeDTO.UserId);
            if (objCheck == null)
            {

                var list = (from u in _context.Stores select new { u.StoreId }).ToList();
                int newcode = list.Count + 1;

                string storecode = "";

                if (newcode < 10)
                    storecode = "OS" + "0000" + newcode.ToString();
                else if (newcode < 100)
                    storecode = "OS" + "000" + newcode.ToString();
                else if (newcode < 1000)
                    storecode = "OS" + "00" + newcode.ToString();
                else if (newcode < 10000)
                    storecode = "OS" + "0" + newcode.ToString();
                else
                    storecode = "OS" + newcode.ToString();
                Store store = new Store();
                store.StoreCode = storecode;
                store.UserId = storeDTO.UserId;
                store.StoreName = storeDTO.StoreName;
                store.CategoryId = storeDTO.CategoryId;
                store.OwnerName = storeDTO.OwnerName;
                store.BusineessContactInfo = storeDTO.BusineessContactInfo;
                store.BusinessLogo = storeDTO.BusinessLogo;
                store.Lat = storeDTO.Lat;
                store.Long = storeDTO.Long;
                store.Address = storeDTO.Address;
                store.Landmark = storeDTO.Landmark;
                store.StateId = storeDTO.StateId;
                store.CityId = storeDTO.CityId;
                store.AreaId = storeDTO.AreaId;
                store.IsSundayOpen = storeDTO.IsSundayOpen;
                store.SundayOpenTime = storeDTO.SundayOpenTime;
                store.SundayCloseTime = storeDTO.SundayCloseTime;

                store.IsMondayOpen = storeDTO.IsMondayOpen;
                store.MondayOpenTime = storeDTO.MondayOpenTime;
                store.MondayCloseTime = storeDTO.MondayCloseTime;

                store.IsTuesdayOpen = storeDTO.IsTuesdayOpen;
                store.TuesdayOpenTime = storeDTO.TuesdayOpenTime;
                store.TuesdayCloseTime = storeDTO.TuesdayCloseTime;

                store.IsWednessdayOpen = storeDTO.IsWednessdayOpen;
                store.WednessdayOpenTime = storeDTO.WednessdayOpenTime;
                store.WednessdayCloseTime = storeDTO.WednessdayCloseTime;


                store.IsThursdayOpen = storeDTO.IsThursdayOpen;
                store.ThursdayOpenTime = storeDTO.ThursdayOpenTime;
                store.ThursdayCloseTime = storeDTO.ThursdayCloseTime;


                store.IsFridayOpen = storeDTO.IsFridayOpen;
                store.FridayOpenTime = storeDTO.FridayOpenTime;
                store.FridayCloseTime = storeDTO.FridayCloseTime;


                store.IsSaturdayOpen = storeDTO.IsSaturdayOpen;
                store.SaturdayOpenTime = storeDTO.SaturdayOpenTime;
                store.SaturdayCloseTime = storeDTO.SaturdayCloseTime;
                store.RefferedBy = storeDTO.RefferedBy;

                var obj = _storeRepo.Insert(store);
                return Ok(obj);

            }
            else
            {
                return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Seller Account Already Created For This User." });
            }

        }


        [HttpPost]
        public IActionResult UpdateStore(StoreUpdateDTO storeDTO)
        {
           
                var store = _context.Stores.SingleOrDefault(opt => opt.StoreId == storeDTO.StoreId);
              
                store.StoreName = storeDTO.StoreName!=null?store.StoreName : storeDTO.StoreName;
               
                store.OwnerName = storeDTO.OwnerName;
                store.BusineessContactInfo = storeDTO.BusineessContactInfo;

                store.BusinessLogo = storeDTO.BusinessLogo != null ? store.BusinessLogo : storeDTO.BusinessLogo; 

                store.Lat = storeDTO.Lat;
                store.Long = storeDTO.Long;
                store.Address = storeDTO.Address;
                store.Landmark = storeDTO.Landmark;
                store.StateId = storeDTO.StateId;
                store.CityId = storeDTO.CityId;
                store.AreaId = storeDTO.AreaId;
                store.IsSundayOpen = storeDTO.IsSundayOpen;
                store.SundayOpenTime = storeDTO.SundayOpenTime;
                store.SundayCloseTime = storeDTO.SundayCloseTime;

                store.IsMondayOpen = storeDTO.IsMondayOpen;
                store.MondayOpenTime = storeDTO.MondayOpenTime;
                store.MondayCloseTime = storeDTO.MondayCloseTime;

                store.IsTuesdayOpen = storeDTO.IsTuesdayOpen;
                store.TuesdayOpenTime = storeDTO.TuesdayOpenTime;
                store.TuesdayCloseTime = storeDTO.TuesdayCloseTime;

                store.IsWednessdayOpen = storeDTO.IsWednessdayOpen;
                store.WednessdayOpenTime = storeDTO.WednessdayOpenTime;
                store.WednessdayCloseTime = storeDTO.WednessdayCloseTime;


                store.IsThursdayOpen = storeDTO.IsThursdayOpen;
                store.ThursdayOpenTime = storeDTO.ThursdayOpenTime;
                store.ThursdayCloseTime = storeDTO.ThursdayCloseTime;


                store.IsFridayOpen = storeDTO.IsFridayOpen;
                store.FridayOpenTime = storeDTO.FridayOpenTime;
                store.FridayCloseTime = storeDTO.FridayCloseTime;


                store.IsSaturdayOpen = storeDTO.IsSaturdayOpen;
                store.SaturdayOpenTime = storeDTO.SaturdayOpenTime;
                store.SaturdayCloseTime = storeDTO.SaturdayCloseTime;
                store.RefferedBy = storeDTO.RefferedBy;

                var obj = _storeRepo.Insert(store);
                return Ok(obj);

            

        }

        [HttpGet("{UserId}")]
        public IActionResult GetStoreDetailsByUserId(int UserId)
        {
            var objStores = _context.Stores.SingleOrDefault(opt => opt.UserId == UserId && opt.IsDeleted == false );
            return Ok(objStores);

        }

        [HttpGet("{StoreId}")]
        public IActionResult GetStoreDetailsByStoreId(int StoreId)
        {
            var objStores = _context.Stores.SingleOrDefault(opt => opt.StoreId == StoreId && opt.IsDeleted == false);
            return Ok(objStores);

        }

        [HttpGet()]
        public IActionResult GetStores()
        {
          var a=  _context.Stores
                        .Include(s => s.StoreRattings.Where(post => post.IsDeleted == false))
                        .Where(p => p.IsDeleted == false)

                        .ToList();

            return Ok(a);

        }

       
    }
}
