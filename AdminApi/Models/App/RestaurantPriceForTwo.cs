using System;
using System.Text.Json.Serialization;

namespace AdminApi.Models.App
{
    public class RestaurantPriceForTwo
    {
        public int RestaurantPriceForTwoId { get; set; }    
        public int StoreId { get; set; }
        public double? Price { get; set; }
        public string About { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

        [JsonIgnore]
        public Store Store { get; set; }
    }
}
