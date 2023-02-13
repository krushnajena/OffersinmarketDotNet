using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class RestaurantImageDTO
    {
        public int StoreId { get; set; }
        public string ImageType { get; set; }
        public string Image { get; set; }
        public string Text { get; set; }
        public int CreatedBy { get; set; }
    }
}
