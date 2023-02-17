using AdminClient.DTO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System;
using System.Net.Http.Headers;
using AdminClient.Model.Store;
using AdminClient.Model.Story;

namespace AdminClient.Controllers
{
    public class StoryController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        private readonly IStory _story;

        public StoryController(IWebHostEnvironment hostingEnvironment,

                              IStory storeP)
        {
            _hostingEnvironment = hostingEnvironment;

            _story = storeP;
        }
        public IActionResult StoryCreate(StoryDTO storyDTO)
        {
            for(int i = 0; i < storyDTO.files.Count; i++)
            {
                string filename = ContentDispositionHeaderValue.Parse(storyDTO.files[i].ContentDisposition).FileName.Trim('"');
                 filename = EnsureCorrectFilename(filename);

                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "story");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
                storyDTO.files[i].CopyTo(new FileStream(imagePath, FileMode.Create));
                string photopath = "/story/" + uniqueFileName;
                StoryNewDTO story = new StoryNewDTO();
                story.StoreId = storyDTO.StoreId;
                story.Text = storyDTO.Text;
                story.Image = photopath;
                story.CreatedBy = storyDTO.CreatedBy;
                _story.StoryCreate(story);
            }
            return Ok("Record Submitted Successfullt.");
        }

        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }
    }
}
