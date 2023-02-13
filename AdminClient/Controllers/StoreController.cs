using AdminClient.DTO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System;
using System.Net.Http.Headers;
using AdminClient.Model.Store;

namespace AdminClient.Controllers
{
    public class StoreController : Controller
    {

        private readonly IWebHostEnvironment _hostingEnvironment;
     
        private readonly IStore _store;

        public StoreController(IWebHostEnvironment hostingEnvironment,
                             
                              IStore storeP)
        {
            _hostingEnvironment = hostingEnvironment;
            
            _store = storeP;
        }

        [HttpPost]
        public IActionResult StoreCreate(StoreDTO storeDTO)
        {

            string filename = ContentDispositionHeaderValue.Parse(storeDTO.file.ContentDisposition).FileName.Trim('"');

            filename = EnsureCorrectFilename(filename);

            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
            string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
            storeDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
            string photopath = "/images/" + uniqueFileName;
            StoreNewDTO store = new StoreNewDTO();
            store.UserId = storeDTO.UserId;
            store.StoreName = storeDTO.StoreName;
            store.CategoryId = storeDTO.CategoryId;
            store.OwnerName = storeDTO.OwnerName;
            store.BusineessContactInfo = storeDTO.BusineessContactInfo;
            store.BusinessLogo = photopath;
   
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
            var a = _store.CreateStore(store);

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
