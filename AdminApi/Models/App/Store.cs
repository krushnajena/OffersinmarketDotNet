using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace AdminApi.Models.App
{
    public class Store
    {
        public int StoreId { get; set; }
        public string StoreCode { get; set; }
        public int UserId { get; set; }
        public string StoreName { get; set; }
        public int CategoryId { get; set; }
        public string OwnerName { get; set; }
        public string BusineessContactInfo { get; set; }
        public string BusinessLogo { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public string Address { get; set; } 
        public string Landmark { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public bool IsSundayOpen { get; set; }
        public TimeSpan? SundayOpenTime { get; set; }
        public TimeSpan? SundayCloseTime { get; set; }


        public bool IsMondayOpen { get; set; }
        public TimeSpan? MondayOpenTime { get; set; }
        public TimeSpan? MondayCloseTime { get; set; }


        public bool IsTuesdayOpen { get; set; }
        public TimeSpan? TuesdayOpenTime { get; set; }
        public TimeSpan? TuesdayCloseTime { get; set; }


        public bool IsWednessdayOpen { get; set; }
        public TimeSpan? WednessdayOpenTime { get; set; }
        public TimeSpan? WednessdayCloseTime { get; set; }


        public bool IsThursdayOpen { get; set; }
        public TimeSpan? ThursdayOpenTime { get; set; }
        public TimeSpan? ThursdayCloseTime { get; set; }


        public bool IsFridayOpen { get; set; }
        public TimeSpan? FridayOpenTime { get; set; }
        public TimeSpan? FridayCloseTime { get; set; }


        public bool IsSaturdayOpen { get; set; }
        public TimeSpan? SaturdayOpenTime { get; set; }
        public TimeSpan? SaturdayCloseTime { get; set; }

        public string RefferedBy { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }


        public ICollection<StoreRatting> StoreRattings { get; set; }
        public ICollection<Follower> Followers { get; set; }
        public ICollection<RestaurantImage> RestaurantImages { get; set; }
        public ICollection<RestaurantCuisine> RestaurantCuisines{ get; set; }

        public ICollection<RestaurantPriceForTwo> RestaurantPriceForTwos { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Story> Stories{ get; set; }

        [JsonIgnore]
        public Category Category { get; set; }
    }
}
