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
    public class StoryController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Story> _storyRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public StoryController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Story> cuisineRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _storyRepo = cuisineRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }

        [HttpPost]
        public IActionResult StoryCreate(StoryDTO storyDTO)
        {
            Story story = new Story();
            story.StoreId = storyDTO.StoreId;
            story.Text = storyDTO.Text;
            story.Image = storyDTO.Image;
            story.CreatedBy = storyDTO.CreatedBy;
           var a =  _storyRepo.Insert(story);
            return Ok(a);
        }

        [HttpGet("{StoreId}")]
        public IActionResult GetStoryListByStoreId(int StoreId)
        {
            try
            {
                var list = (from u in _context.Stories
                            select new
                            {
                                u.StoryId,
                                u.StoreId,
                                u.Text,

                                u.Image,
                                u.CreatedBy,
                                u.CreatedOn,
                                VisibleTill = u.CreatedOn.AddHours(24),
                                u.IsDeleted

                            }


                            ).Where(x => x.IsDeleted == false && x.StoreId==StoreId && x.VisibleTill > System.DateTime.Now ).ToList();

                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{StoryId}/{CreatedBy}")]
        public IActionResult DeleteStory(int StoryId, int CreatedBy)
        {
            try
            {
                var objState = _context.Stories.SingleOrDefault(opt => opt.StoryId == StoryId);
                objState.IsDeleted = true   ;
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


    }
}
