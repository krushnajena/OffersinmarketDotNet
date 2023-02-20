using AdminClient.DTO;
using AdminClient.Model.Product;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System;
using System.Net.Http.Headers;

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
            string filename = ContentDispositionHeaderValue.Parse(productDTO.file.ContentDisposition).FileName.Trim('"');

            filename = EnsureCorrectFilename(filename);

            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
            string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
            productDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
            string photopath = "/images/" + uniqueFileName;
            ProductNewDTO product = new ProductNewDTO();




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
