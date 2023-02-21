using AdminClient.DTO;
using AdminClient.Model.Product;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace AdminClient.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        private readonly IProduct _product;

        public ProductController(IWebHostEnvironment hostingEnvironment,

                              IProduct productP)
        {
            _hostingEnvironment = hostingEnvironment;

            _product = productP;
        }
        [HttpPost]
        public IActionResult ProductCreate(ProductDTO productDTO)
        {
            List<ProductImageDTO> list = new List<ProductImageDTO>();
            for(int i = 0; i < productDTO.files.Count; i++)
            {
                string filename = ContentDispositionHeaderValue.Parse(productDTO.files[i].ContentDisposition).FileName.Trim('"');

                filename = EnsureCorrectFilename(filename);

                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "productimages");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
                productDTO.files[i].CopyTo(new FileStream(imagePath, FileMode.Create));
                string photopath = "/productimages/" + uniqueFileName;
                ProductImageDTO productImageDTO = new ProductImageDTO();
                productImageDTO.Image = photopath;
                list.Add(productImageDTO);

            }
            
            ProductNewDTO product = new ProductNewDTO();
            product.StoreId = productDTO.StoreId;
            product.ProductName = productDTO.ProductName;
            product.CategoryId = productDTO.CategoryId;
            product.SecondaryCategoryId = productDTO.SecondaryCategoryId;
            product.TernaryCategoryId = productDTO.TernaryCategoryId;
            product.MRP = productDTO.MRP;
            product.SellingPrice = productDTO.SellingPrice;
            product.Unit = productDTO.Unit;
            product.ProductDescription = productDTO.ProductDescription;

            product.CreatedBy = productDTO.CreatedBy;
            product.productImageDTOs = list;

            product.productSpecificationsDTOs = productDTO.productSpecificationsDTOs;

            var a = _product.CreateProduct(product);

            return Ok(a);
        }
        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }
    }
}
