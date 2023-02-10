using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class RestaurantPriceForTwoDTO
    {
        public int StoreId { get; set; }
        public double? Price { get; set; }
        public string About { get; set; }
        public int CreatedBy { get; set; }
    }
}
