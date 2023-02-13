using AdminClient.DTO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System;
using System.Net.Http.Headers;
using AdminClient.Model.Store;
using AdminClient.Model.Restaurant;

namespace AdminClient.Controllers
{
    public class RestaurantImageController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        private readonly IRestaurantImage _restaurantImage;

        public RestaurantImageController(IWebHostEnvironment hostingEnvironment,

                              IRestaurantImage restaurantImage)
        {
            _hostingEnvironment = hostingEnvironment;

            _restaurantImage = restaurantImage;
        }
        [HttpPost]
        public IActionResult CreateRestaurantImage(RestaurantImageDTO restaurantImageDTO)
        {

            string filename = ContentDispositionHeaderValue.Parse(restaurantImageDTO.file.ContentDisposition).FileName.Trim('"');

            filename = EnsureCorrectFilename(filename);

            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "resturentimages");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
            string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
            restaurantImageDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
            string photopath = "/resturentimages/" + uniqueFileName;

            RestaurantImageNewDTO restaurantImageNewDTO = new RestaurantImageNewDTO();
            restaurantImageNewDTO.StoreId = restaurantImageDTO.StoreId;
            restaurantImageNewDTO.ImageType = restaurantImageDTO.ImageType;
            restaurantImageNewDTO.Image = photopath;

            restaurantImageNewDTO.Text = restaurantImageDTO.Text;
            restaurantImageNewDTO.CreatedBy = restaurantImageDTO.CreatedBy;
          
            var a = _restaurantImage.CreateRestaurantImage(restaurantImageNewDTO);

            return Ok(a);
        }

        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }
        public IActionResult ResturantImageApprove()
        {
            return View();
        }
        public IActionResult ResturantImage()
        {
            return View();
        }
    }
}
