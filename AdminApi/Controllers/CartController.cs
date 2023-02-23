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
    public class CartController : ControllerBase
    {

        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Cart> _cartRepo;

        private readonly IWebHostEnvironment _enviorment;
        public IConfiguration Configuration { get; }
        public CartController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Cart> areaRepo,
                                IWebHostEnvironment enviorment, IConfiguration configuration)
        {
            _config = config;
            _context = context;
            _cartRepo = areaRepo;
            _enviorment = enviorment;
            Configuration = configuration;
        }
        [HttpPost]
        public IActionResult AddToCart(CartDTO cartDTO)
        {
            var a = _context.Carts.Where(x => x.ProductId == cartDTO.ProductId && x.UserId == cartDTO.UserId && x.Type == cartDTO.Type).SingleOrDefault();
            if (a==null)
            {
                Cart cart = new Cart();
                cart.ProductId = cartDTO.ProductId;
                cart.UserId = cartDTO.UserId;
                cart.Type = cartDTO.Type;
                cart.StoreId = cartDTO.StoreId;
                cart.CreatedBy = cartDTO.CreatedBy;
                var x = _cartRepo.Insert(cart);
                return Ok(x);
            }
            else if(cartDTO.Type == "Wishlist" && a == null)
            {
                a.IsDeleted = true;
                a.UpdatedBy = cartDTO.CreatedBy;
                a.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok("Item Removed From Wishlist");
            }
            else
            {
                return Ok(a);
            }

        }

        [HttpGet("{ProductId}/{UserId}")]
        public IActionResult RemoveFromCart(int ProductId, int UserId)
        {
            var a = _context.Carts.Where(x => x.ProductId == ProductId && x.UserId == UserId).SingleOrDefault();
            if (a != null)
            {
                a.IsDeleted = true;
                a.UpdatedBy = UserId;
                a.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok("Item Removed From Cart");
            }
           
            else
            {
                return BadRequest("Item Already Removed From Cart.");
            }

        }

        [HttpGet("{UserId}/{Type}")]
        public IActionResult GetCartsAndWishlist(int UserId,string Type)
        {
            try
            {
                var list = (from u in _context.Carts
                            join r in _context.Products on u.ProductId equals r.ProductId
                            join l in _context.Stores on u.StoreId equals l.StoreId
                            select new
                            {
                                u.CartId,
                                u.ProductId,


                                u.StoreId,
                                u.UserId,
                                u.IsDeleted,
                                u.Type,
                                r.ProductName,
                                ProductImages= r.ProductImages.Where(p=>p.IsDeleted == false),
                                r.MRP,
                                r.SellingPrice,

                               l.StoreName,
                               l.Address,
                               l.Landmark,
                               l.Lat,
                               l.Long,
                               l.BusinessLogo,
                               l.BusineessContactInfo

                            }


                            ).Where(x => x.IsDeleted == false && x.Type == Type && x.UserId == UserId).ToList();

                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
