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
    }
}
