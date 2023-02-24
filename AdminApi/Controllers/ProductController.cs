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
    public class ProductController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Product> _productRepo;
        private readonly ISqlRepository<ProductImage> _productImageRepo;
        private readonly ISqlRepository<ProductSpecification> _productSpecificationRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public ProductController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Product> productRepo,
                                 ISqlRepository<ProductImage> productImageRepo,
                                  ISqlRepository<ProductSpecification> productSpecificationRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _productRepo = productRepo;
            _productImageRepo = productImageRepo;
            _productSpecificationRepo = productSpecificationRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }
        [HttpPost]
        public IActionResult CreateProduct(ProductDTO productDTO)
        {
            var list = (from u in _context.Products select new { u.ProductId }).ToList();
            int newcode = list.Count + 1;

            string productcode = "";

            if (newcode < 10)
                productcode = "OP" + "0000" + newcode.ToString();
            else if (newcode < 100)
                productcode = "OP" + "000" + newcode.ToString();
            else if (newcode < 1000)
                productcode = "OP" + "00" + newcode.ToString();
            else if (newcode < 10000)
                productcode = "OP" + "0" + newcode.ToString();
            else
                productcode = "OP" + newcode.ToString();
            Product product = new Product();
            product.StoreId = productDTO.StoreId;
            product.ProductCode = productcode;
            product.ProductName = productDTO.ProductName;
            product.CategoryId = productDTO.CategoryId;
            product.SecondaryCategoryId = productDTO.SecondaryCategoryId;
            product.TernaryCategoryId = productDTO.TernaryCategoryId;

            product.MRP = productDTO.MRP;
            product.SellingPrice = productDTO.SellingPrice;
            product.Unit = productDTO.Unit;
            product.ProductDescription = productDTO.ProductDescription;

            product.IsActive = false;
            product.InStock = true;
                product.ProductView = 0;
            product.CreatedBy = productDTO.CreatedBy;
            var obj = _productRepo.Insert(product);
            for(int i = 0; i < productDTO.productImageDTOs.Count; i++)
            {
                ProductImage productImage = new ProductImage();
                productImage.ProductId = obj.ProductId;
                productImage.Image = productDTO.productImageDTOs[i].Image;
                productImage.CreatedBy= productDTO.CreatedBy;
                _productImageRepo.Insert(productImage);
            }

            for (int i = 0; i < productDTO.productSpecificationsDTOs.Count; i++)
            {
                ProductSpecification productSpecification = new ProductSpecification();
                productSpecification.ProductId = obj.ProductId;
                productSpecification.Key = productDTO.productSpecificationsDTOs[i].Key;
                productSpecification.Value = productDTO.productSpecificationsDTOs[i].Value;
                productSpecification.CreatedBy = productDTO.CreatedBy;
                _productSpecificationRepo.Insert(productSpecification);
            }
            return Ok(obj);
        }

        [HttpGet("{StoreId}")]
        public IActionResult GetProductsByStoreIdStoreSide(int StoreId)
        {
            var objProducts = _context.Products.Include(s => s.ProductImages)
                                    
                                      .Select(p => new
                                      {
                                          StoreId = p.StoreId,
                                          ProductId = p.ProductId,
                                          ProductCode = p.ProductCode,
                                          ProductName = p.ProductName,
                                          CategoryId = p.CategoryId,
                                          SecondaryCategoryId = p.SecondaryCategoryId,
                                          TernaryCategoryId = p.TernaryCategoryId,
                                          MRP = p.MRP,
                                          SellingPrice = p.SellingPrice,
                                          Discount = p.MRP-p.SellingPrice,
                                          DiscountPercentage = (p.MRP - p.SellingPrice)>0? (((p.MRP - p.SellingPrice) / p .MRP) *100):0,
                                          Unit = p.Unit,
                                          ProductDescription = p.ProductDescription,
                                          IsActive = p.IsActive,
                                          InStock = p.InStock,
                                          IsDeleted = p.IsDeleted,
                                          ProductView= p.ProductView,
                                          ProductImages = p.ProductImages.Where(c => c.IsDeleted == false)
                                         
                                      }).Where(opt => opt.StoreId == StoreId && opt.IsDeleted == false ).ToList();

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


                            ).Where(x => x.IsDeleted == false && x.StoreId == StoreId ).Distinct().ToList();

               return Ok(new { products = objProducts, categories = categoryList, }); 
        }


        [HttpGet("{ProductId}/{CreatedBy}")]
        public IActionResult DeleteProduct(int ProductId,int CreatedBy)
        {
            try
            {
                var objState = _context.Products.SingleOrDefault(opt => opt.ProductId == ProductId);
                objState.IsDeleted = true;
                objState.UpdatedBy = CreatedBy;
                objState.UpdatedOn = System.DateTime.Now; ;
                _context.SaveChanges();
                return Ok(objState);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{ProductId}/{CreatedBy}/{InStock}")]
        public IActionResult UpdateProductStock(int ProductId, int CreatedBy,bool InStock)
        {
            try
            {
                var objState = _context.Products.SingleOrDefault(opt => opt.ProductId == ProductId);
                objState.InStock = InStock;
                objState.UpdatedBy = CreatedBy;
                objState.UpdatedOn = System.DateTime.Now; ;
                _context.SaveChanges();
                return Ok(objState);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{ProductId}")]
        public IActionResult GetProductDetailsByProductId(int ProductId)
        {
            var objProducts = _context.Products.Include(s => s.ProductImages)
                                               .Include(s=>s.ProductSpecifications)
                                               
                                               

                                     .Select(p => new
                                     {

                                         StoreId = p.StoreId,
                                         ProductId = p.ProductId,
                                         ProductCode = p.ProductCode,
                                         ProductName = p.ProductName,
                                         CategoryId = p.CategoryId,
                                         SecondaryCategoryId = p.SecondaryCategoryId,
                                         TernaryCategoryId = p.TernaryCategoryId,
                                         MRP = p.MRP,
                                         SellingPrice = p.SellingPrice,
                                         Discount = p.MRP - p.SellingPrice,
                                         DiscountPercentage = (p.MRP - p.SellingPrice) > 0 ? (((p.MRP - p.SellingPrice) / p.MRP) * 100) : 0,
                                         Unit = p.Unit,
                                         ProductDescription = p.ProductDescription,
                                         IsActive = p.IsActive,
                                         InStock = p.InStock,
                                         IsDeleted = p.IsDeleted,
                                         ProductView = p.ProductView,
                                         ProductImages = p.ProductImages.Where(c => c.IsDeleted == false),
                                         ProductSpecifications = p.ProductSpecifications.Where(c => c.IsDeleted == false),
                                        

                                     }).Where(opt => opt.ProductId == ProductId && opt.IsDeleted == false).SingleOrDefault();

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
                         //  IFollow = p.Followers.Where((c => c.IsDeleted == false && c.UserId == UserId)),
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

                              .Where(c => c.IsDeleted == false && c.IsActive == true && c.InStock == true && c.TernaryCategoryId == objProducts.TernaryCategoryId),



                       }).SingleOrDefault(opt => opt.StoreId == objProducts.StoreId && opt.IsDeleted == false);
            return Ok(new { prodcutDetails = objProducts, storeDetails = objStores, });

        }



    }
}
