using AdminApi.DTO.App;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.Helper;
using AdminApi.Models.User;
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
          var a=  _context.Stores.Include(s => s.StoreRattings).Where(p => p.IsDeleted == false).Select(p => new
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
                             IsSundayOpen=p.IsSundayOpen,
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
                             Rattings = p.StoreRattings.Where(c => c.IsDeleted == false)
                         })

                        .ToList();

            return Ok(a);

        }

        [HttpGet]
        public IActionResult GetStoreList()
        {
            try
            {
                var list = (from u in _context.Stores
                         
                            select new
                            {
                                u.StoreId,
                               u.StateId,
                               u.StoreCode,
                               u.UserId,
                               u.StoreName,
                               u.CategoryId,
                               u.OwnerName,
                               u.BusineessContactInfo,
                               u.BusinessLogo,
                               u.Lat,
                               u.Long,
                               u.Address,
                               u.Landmark,
                               u.CityId,
                               u.AreaId,
                               u.IsSundayOpen,
                               u.SundayOpenTime,
                               u.SundayCloseTime,
                               u.IsMondayOpen,
                               u.MondayOpenTime,
                               u.MondayCloseTime,
                               u.IsTuesdayOpen,
                               u.TuesdayOpenTime,
                               u.TuesdayCloseTime,
                               u.IsWednessdayOpen,
                               u.WednessdayOpenTime,
                               u.WednessdayCloseTime,
                               u.IsThursdayOpen,
                               u.ThursdayOpenTime,
                               u.ThursdayCloseTime,
                               u.IsFridayOpen,
                               u.FridayOpenTime,
                               u.FridayCloseTime,
                               u.IsSaturdayOpen,
                               u.SaturdayOpenTime,
                               u.SaturdayCloseTime,
                            
                               u.CreatedBy,
                               u.CreatedOn,
                               u.UpdatedBy,
                               u.UpdatedOn,
                            

                             

                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false).ToList();

                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{StoreId}")]
        public IActionResult GetResturentDetailsByStoreId(int StoreId)
        {
            var objStores = _context.Stores.Include(s => s.StoreRattings)
                                            .Include(s => s.Followers)
                                                .Include(s => s.RestaurantImages)
                                                    .Include(s => s.RestaurantCuisines)
                                                    .Include(s => s.RestaurantPriceForTwos)
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
                            Ratting = p.StoreRattings.Where(c => c.IsDeleted == false).Average(l=>l.AppliedRatting),

                            Followers = p.Followers.Where(c => c.IsDeleted == false),
                            Cusines =( from h in p.RestaurantCuisines
                             join l in _context.Cuisines on h.CusineId equals l.CuisineId
                                       select new
                                       {
                                           h.CusineId,
                                           l.CuisineName,
                                           h.IsDeleted

                                       }
                             )
                            .Where(c => c.IsDeleted == false),
                            RestaurantPriceForTwo = p.RestaurantPriceForTwos.Where(c => c.IsDeleted == false),
                            Banners = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Banner" && c.IsActive == true),
                            Menu = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Menu" && c.IsActive == true),
                            Ambience = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Ambience" && c.IsActive == true),
                            Food = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Food" && c.IsActive == true),
                        }).SingleOrDefault(opt => opt.StoreId == StoreId && opt.IsDeleted == false)

                       


            ;
            return Ok(objStores);

        }

        [HttpGet("{CategoryId}")]
        public IActionResult GetStoresByCategoryId(int CategoryId)
        {
            #region For Resturent
            if (CategoryId == 1)
            {

                var objStores = _context.Stores.Include(s => s.StoreRattings)
                                                .Include(s => s.Followers)
                                                    .Include(s => s.RestaurantImages)
                                                        .Include(s => s.RestaurantCuisines)
                                                        .Include(s => s.RestaurantPriceForTwos)
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

                                Followers = p.Followers.Where(c => c.IsDeleted == false),
                                Cusines = (from h in p.RestaurantCuisines
                                           join l in _context.Cuisines on h.CusineId equals l.CuisineId
                                           select new
                                           {
                                               h.CusineId,
                                               l.CuisineName,
                                               h.IsDeleted

                                           }
                                 )
                                .Where(c => c.IsDeleted == false),
                                RestaurantPriceForTwo = p.RestaurantPriceForTwos.Where(c => c.IsDeleted == false),
                                Banners = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Banner" && c.IsActive == true),
                                Menu = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Menu" && c.IsActive == true),
                                Ambience = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Ambience" && c.IsActive == true),
                                Food = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Food" && c.IsActive == true),
                            }).Where(opt => opt.CategoryId == CategoryId && opt.IsDeleted == false).ToList();
                
                return Ok(objStores);


            }
#endregion
            #region For Other Store Categories
            else
            {
                var objStores = _context.Stores.Include(s => s.StoreRattings)
                                               .Include(s => s.Followers)
                                                   .Include(s => s.Products
                                                   
                                                   
                                                   ).ThenInclude(s=>s.ProductImages)
                                                        
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

                               Followers = p.Followers.Where(c => c.IsDeleted == false),
                              
                               Products = p.Products
                               .Select(c => new
                               {

                                   StoreId = c.StoreId,
                                   ProductId = c.ProductId,
                                   ProductCode = c.ProductCode,
                                   ProductName = c.ProductName,
                                   CategoryId = c.CategoryId,
                                   SecondaryCategoryId = c.SecondaryCategoryId,
                                   TernaryCategoryId = c.TernaryCategoryId,
                                   MRP = c.MRP,
                                   SellingPrice = c.SellingPrice,
                                   Discount = c.MRP - c.SellingPrice,
                                   DiscountPercentage = (c.MRP - c.SellingPrice) > 0 ? (((c.MRP - c.SellingPrice) / c.MRP) * 100) : 0,
                                   Unit = c.Unit,
                                   ProductDescription = c.ProductDescription,
                                   IsActive = c.IsActive,
                                   InStock = c.InStock,
                                   IsDeleted = c.IsDeleted,
                                   ProductView = c.ProductView,
                                   ProductImages = c.ProductImages.Where(c => c.IsDeleted == false)
                                

                               })
                               
                               .Where(c => c.IsDeleted == false &&  c.TernaryCategoryId == CategoryId && c.IsActive ==true && c.InStock == true),
                             
                           }).Where(opt =>  opt.IsDeleted == false && opt.Products.Count()>0).ToList();

                return Ok(objStores);

            }
            #endregion



        }


        [HttpGet("{CategoryId}/{AreaId}")]
        public IActionResult GetStoresByCategoryIdAndAreaId(int CategoryId,int AreaId)
        {
            #region For Resturent
            if (CategoryId == 1)
            {
                var objStores = _context.Stores.Include(s => s.StoreRattings)
                                            .Include(s => s.Followers)
                                                .Include(s => s.RestaurantImages)
                                                    .Include(s => s.RestaurantCuisines)
                                                    .Include(s => s.RestaurantPriceForTwos)
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

                            Followers = p.Followers.Where(c => c.IsDeleted == false),
                            Cusines = (from h in p.RestaurantCuisines
                                       join l in _context.Cuisines on h.CusineId equals l.CuisineId
                                       select new
                                       {
                                           h.CusineId,
                                           l.CuisineName,
                                           h.IsDeleted

                                       }
                             )
                            .Where(c => c.IsDeleted == false),
                            RestaurantPriceForTwo = p.RestaurantPriceForTwos.Where(c => c.IsDeleted == false),
                            Banners = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Banner" && c.IsActive == true),
                            Menu = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Menu" && c.IsActive == true),
                            Ambience = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Ambience" && c.IsActive == true),
                            Food = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Food" && c.IsActive == true),
                        }).Where(opt => opt.CategoryId == CategoryId && opt.IsDeleted == false && opt.AreaId == AreaId).ToList();





                return Ok(objStores);
            }
            #endregion
            #region For Other Store Categories
            else
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

                               Followers = p.Followers.Where(c => c.IsDeleted == false),

                               Products = p.Products
                               .Select(c => new
                               {

                                   StoreId = c.StoreId,
                                   ProductId = c.ProductId,
                                   ProductCode = c.ProductCode,
                                   ProductName = c.ProductName,
                                   CategoryId = c.CategoryId,
                                   SecondaryCategoryId = c.SecondaryCategoryId,
                                   TernaryCategoryId = c.TernaryCategoryId,
                                   MRP = c.MRP,
                                   SellingPrice = c.SellingPrice,
                                   Discount = c.MRP - c.SellingPrice,
                                   DiscountPercentage = (c.MRP - c.SellingPrice) > 0 ? (((c.MRP - c.SellingPrice) / c.MRP) * 100) : 0,
                                   Unit = c.Unit,
                                   ProductDescription = c.ProductDescription,
                                   IsActive = c.IsActive,
                                   InStock = c.InStock,
                                   IsDeleted = c.IsDeleted,
                                   ProductView = c.ProductView,
                                   ProductImages = c.ProductImages.Where(c => c.IsDeleted == false)


                               })

                               .Where(c => c.IsDeleted == false && c.TernaryCategoryId == CategoryId && c.IsActive == true && c.InStock == true),

                           }).Where(opt => opt.IsDeleted == false && opt.Products.Count() > 0 && opt.AreaId == AreaId).ToList();

                return Ok(objStores);

            }
            #endregion
        }



        [HttpGet("{StoreId}/{UserId}")]
        public IActionResult GetResturentDetailsByStoreIdBuyerSide(int StoreId, int UserId)
        {
            var objStores = _context.Stores.Include(s => s.StoreRattings)
                                            .Include(s => s.Followers)
                                                .Include(s => s.RestaurantImages)
                                                    .Include(s => s.RestaurantCuisines)
                                                    .Include(s => s.RestaurantPriceForTwos)
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

                            Followers = p.Followers.Where(c => c.IsDeleted == false),
                            IFollow = p.Followers.Where((c => c.IsDeleted == false && c.UserId == UserId)),
                            Cusines = (from h in p.RestaurantCuisines
                                       join l in _context.Cuisines on h.CusineId equals l.CuisineId
                                       select new
                                       {
                                           h.CusineId,
                                           l.CuisineName,
                                           h.IsDeleted

                                       }
                             )
                            .Where(c => c.IsDeleted == false),
                            RestaurantPriceForTwo = p.RestaurantPriceForTwos.Where(c => c.IsDeleted == false),
                            Banners = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Banner" && c.IsActive == true),
                            Menu = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Menu" && c.IsActive == true),
                            Ambience = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Ambience" && c.IsActive == true),
                            Food = p.RestaurantImages.Where(c => c.IsDeleted == false && c.ImageType == "Food" && c.IsActive == true),
                        }).SingleOrDefault(opt => opt.StoreId == StoreId && opt.IsDeleted == false);
            return Ok(objStores);

        }



        [HttpGet("{StoreId}/{UserId}")]
        public IActionResult GetStoreDetailsByStoreIdBuyerSide(int StoreId, int UserId)
        {
            var categoryList = (from u in _context.Products
                                join r in _context.Categories on u.TernaryCategoryId equals r.CategoryId
                                select new
                                {
                                    u.StoreId,
                                    u.IsDeleted,
                                    u.TernaryCategoryId,
                                    r.CategoryName,
                                    r.Icon
                                }


                            ).Where(x => x.IsDeleted == false && x.StoreId == StoreId).Distinct().ToList();

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

                            Followers = p.Followers.Where(c => c.IsDeleted == false),
                            IFollow = p.Followers.Where((c => c.IsDeleted == false && c.UserId == UserId)),
                            Products = p.Products
                               .Select(c => new
                               {

                                   StoreId = c.StoreId,
                                   ProductId = c.ProductId,
                                   ProductCode = c.ProductCode,
                                   ProductName = c.ProductName,
                                   CategoryId = c.CategoryId,
                                   SecondaryCategoryId = c.SecondaryCategoryId,
                                   TernaryCategoryId = c.TernaryCategoryId,
                                   MRP = c.MRP,
                                   SellingPrice = c.SellingPrice,
                                   Discount = c.MRP - c.SellingPrice,
                                   DiscountPercentage = (c.MRP - c.SellingPrice) > 0 ? (((c.MRP - c.SellingPrice) / c.MRP) * 100) : 0,
                                   Unit = c.Unit,
                                   ProductDescription = c.ProductDescription,
                                   IsActive = c.IsActive,
                                   InStock = c.InStock,
                                   IsDeleted = c.IsDeleted,
                                   ProductView = c.ProductView,
                                   ProductImages = c.ProductImages.Where(c => c.IsDeleted == false)


                               })

                               .Where(c => c.IsDeleted == false && c.IsActive == true && c.InStock == true),



                        }).SingleOrDefault(opt => opt.StoreId == StoreId && opt.IsDeleted == false);

            return Ok(new { stores = objStores, categories = categoryList, });

        }


        [HttpGet]
        public IActionResult GetTopStoresForHome()
        {
            var a = _context.Categories.Include(s => s.Stores)
                .ThenInclude(s => s.StoreRattings)
                .Include(s => s.Stores)
                                               .ThenInclude(s => s.Followers)
                                               .Include(s => s.Stores)
                                                   .ThenInclude(s => s.Products


                                                   ).ThenInclude(s => s.ProductImages)

                           .Select(p => new
                           {
                               p.CategoryId,
                               p.CategoryName,
                               p.IsActive,
                               p.IsDeleted,
                               p.Order,
                               p.Icon,
                               p.Parent,
                               Stores = p.Stores
                               .Select(c => new
                               {

                                   StoreId = c.StoreId,

                                   StoreName = c.StoreName,

                                   StoreCode = c.StoreCode,
                                   UserId = c.UserId,

                                   CategoryId = c.CategoryId,
                                   OwnerName = c.OwnerName,

                                   BusineessContactInfo = c.BusineessContactInfo,
                                   BusinessLogo = c.BusinessLogo,

                                   Lat = c.Lat,
                                   Long = c.Long,

                                   Address = c.Address,
                                   Landmark = c.Landmark,

                                   StateId = c.StateId,
                                   CityId = c.CityId,

                                   AreaId = c.AreaId,
                                   IsSundayOpen = c.IsSundayOpen,
                                   SundayOpenTime = c.SundayOpenTime,
                                   SundayCloseTime = c.SundayCloseTime,
                                   IsMondayOpen = c.IsMondayOpen,
                                   MondayOpenTime = c.MondayOpenTime,
                                   MondayCloseTime = c.MondayCloseTime,
                                   IsTuesdayOpen = c.IsTuesdayOpen,
                                   TuesdayOpenTime = c.TuesdayOpenTime,
                                   TuesdayCloseTime = c.TuesdayCloseTime,
                                   IsWednessdayOpen = c.IsWednessdayOpen,
                                   WednessdayOpenTime = c.WednessdayOpenTime,
                                   WednessdayCloseTime = c.WednessdayCloseTime,

                                   IsThursdayOpen = c.IsThursdayOpen,
                                   ThursdayOpenTime = c.ThursdayOpenTime,
                                   ThursdayCloseTime = c.ThursdayCloseTime,

                                   IsFridayOpen = c.IsFridayOpen,
                                   FridayOpenTime = c.FridayOpenTime,

                                   FridayCloseTime = c.FridayCloseTime,
                                   IsSaturdayOpen = c.IsSaturdayOpen,

                                   SaturdayOpenTime = c.SaturdayOpenTime,
                                   SaturdayCloseTime = c.SaturdayCloseTime,
                                   RefferedBy = c.RefferedBy,
                                   IsDeleted = c.IsDeleted,
                                   Rattings = c.StoreRattings.Where(c => c.IsDeleted == false),
                                   Ratting = c.StoreRattings.Where(c => c.IsDeleted == false).Average(l => l.AppliedRatting),

                                   Followers = c.Followers.Where(c => c.IsDeleted == false),
                                   StoreIndex = 0,
                                   Products = c.Products.Select(e => new
                                   {


                                       ProductImages = e.ProductImages.Where(c => c.IsDeleted == false),
                                       ProductId = e.ProductId,
                                       ProductCode = e.ProductCode,
                                       ProductName = e.ProductName,
                                       CategoryId = e.CategoryId,
                                       SecondaryCategoryId = e.SecondaryCategoryId,
                                       TernaryCategoryId = e.TernaryCategoryId,
                                       MRP = e.MRP,
                                       SellingPrice = e.SellingPrice,
                                       Discount = e.MRP - e.SellingPrice,
                                       DiscountPercentage = (e.MRP - e.SellingPrice) > 0 ? (((e.MRP - e.SellingPrice) / e.MRP) * 100) : 0,
                                       Unit = e.Unit,
                                       ProductDescription = e.ProductDescription,
                                       IsActive = e.IsActive,
                                       InStock = e.InStock,
                                       IsDeleted = e.IsDeleted,
                                       ProductView = e.ProductView,
                                   }).Where(c => c.IsDeleted == false && c.IsActive == true && c.InStock == true).OrderByDescending(t => t.ProductView).Take(10),

                                   ProductsCount = c.Products.Where(c => c.IsDeleted == false && c.IsActive == true && c.InStock == true).Count(),

                               }).Where(l => l.IsDeleted == false && ((l.ProductsCount>0) || (l.CategoryId == 1))).OrderByDescending(k => k.StoreIndex).Take(2),

                               StoreCount = p.Stores
                               .Select(c => new
                               {

                                   StoreId = c.StoreId,

                                   StoreName = c.StoreName,

                                   StoreCode = c.StoreCode,
                                   UserId = c.UserId,

                                   CategoryId = c.CategoryId,
                                   OwnerName = c.OwnerName,

                                   BusineessContactInfo = c.BusineessContactInfo,
                                   BusinessLogo = c.BusinessLogo,

                                   Lat = c.Lat,
                                   Long = c.Long,

                                   Address = c.Address,
                                   Landmark = c.Landmark,

                                   StateId = c.StateId,
                                   CityId = c.CityId,

                                   AreaId = c.AreaId,
                                   IsSundayOpen = c.IsSundayOpen,
                                   SundayOpenTime = c.SundayOpenTime,
                                   SundayCloseTime = c.SundayCloseTime,
                                   IsMondayOpen = c.IsMondayOpen,
                                   MondayOpenTime = c.MondayOpenTime,
                                   MondayCloseTime = c.MondayCloseTime,
                                   IsTuesdayOpen = c.IsTuesdayOpen,
                                   TuesdayOpenTime = c.TuesdayOpenTime,
                                   TuesdayCloseTime = c.TuesdayCloseTime,
                                   IsWednessdayOpen = c.IsWednessdayOpen,
                                   WednessdayOpenTime = c.WednessdayOpenTime,
                                   WednessdayCloseTime = c.WednessdayCloseTime,

                                   IsThursdayOpen = c.IsThursdayOpen,
                                   ThursdayOpenTime = c.ThursdayOpenTime,
                                   ThursdayCloseTime = c.ThursdayCloseTime,

                                   IsFridayOpen = c.IsFridayOpen,
                                   FridayOpenTime = c.FridayOpenTime,

                                   FridayCloseTime = c.FridayCloseTime,
                                   IsSaturdayOpen = c.IsSaturdayOpen,

                                   SaturdayOpenTime = c.SaturdayOpenTime,
                                   SaturdayCloseTime = c.SaturdayCloseTime,
                                   RefferedBy = c.RefferedBy,
                                   IsDeleted = c.IsDeleted,
                                   Rattings = c.StoreRattings.Where(c => c.IsDeleted == false),
                                   Ratting = c.StoreRattings.Where(c => c.IsDeleted == false).Average(l => l.AppliedRatting),

                                   Followers = c.Followers.Where(c => c.IsDeleted == false),
                                   StoreIndex = 0,
                                   Products = c.Products.Select(e => new
                                   {


                                       ProductImages = e.ProductImages.Where(c => c.IsDeleted == false),
                                       ProductId = e.ProductId,
                                       ProductCode = e.ProductCode,
                                       ProductName = e.ProductName,
                                       CategoryId = e.CategoryId,
                                       SecondaryCategoryId = e.SecondaryCategoryId,
                                       TernaryCategoryId = e.TernaryCategoryId,
                                       MRP = e.MRP,
                                       SellingPrice = e.SellingPrice,
                                       Discount = e.MRP - e.SellingPrice,
                                       DiscountPercentage = (e.MRP - e.SellingPrice) > 0 ? (((e.MRP - e.SellingPrice) / e.MRP) * 100) : 0,
                                       Unit = e.Unit,
                                       ProductDescription = e.ProductDescription,
                                       IsActive = e.IsActive,
                                       InStock = e.InStock,
                                       IsDeleted = e.IsDeleted,
                                       ProductView = e.ProductView,
                                   }).Where(c => c.IsDeleted == false && c.IsActive == true && c.InStock == true).OrderByDescending(t => t.ProductView).Take(10),

                                   ProductsCount = c.Products.Where(c => c.IsDeleted == false && c.IsActive == true && c.InStock == true).Count(),

                               }).Where(l => l.IsDeleted == false && ((l.ProductsCount > 0) || (l.CategoryId == 1))).OrderByDescending(k => k.StoreIndex).Count(),



                           }).Where(opt => opt.IsDeleted == false && opt.Parent == null && opt.StoreCount>0).ToList();
            return Ok(a);

        }



    }
}
