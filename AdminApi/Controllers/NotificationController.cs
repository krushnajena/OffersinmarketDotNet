using AdminApi.Models;
using AdminApi.Models.App;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NotificationController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Notification> _notificationRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public NotificationController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Notification> notificationRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _notificationRepo = notificationRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }


        [HttpGet("{UserId}")]
        public IActionResult GetNotificationsByUserId(int UserId) 
        {
            var a = _context.Notifications.Where(x => x.ToUser == UserId && x.IsArchived == false && x.IsDeleted == false).ToList();
            return Ok(a);
        }


        [HttpGet("{NotificationId}/{UserId}")]
        public IActionResult SeeNotification(int NotificationId,int UserId)
        {
            var a = _context.Notifications.Where(x => x.NotificationId == NotificationId).SingleOrDefault();
            a.IsSeen = true;
            a.UpdatedBy = UserId;
            a.UpdatedOn = System.DateTime.Now;
            _context.SaveChanges();
            return Ok(a);
        }


        [HttpGet("{NotificationId}/{UserId}")]
        public IActionResult ArchiveNotification(int NotificationId, int UserId)
        {
            var a = _context.Notifications.Where(x => x.NotificationId == NotificationId).SingleOrDefault();
            a.IsArchived = true;
            a.UpdatedBy = UserId;
            a.UpdatedOn = System.DateTime.Now;
            _context.SaveChanges();
            return Ok(a);
        }



        [HttpGet("{UserId}")]
        public IActionResult GetUnSeenNotificationsByUserId(int UserId)
        {
            var a = _context.Notifications.Where(x => x.ToUser == UserId && x.IsArchived == false && x.IsDeleted == false && x.IsSeen == false).ToList();
            return Ok(a);
        }


    }
}
