using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class BannerDTO
    {
        public string BannerType { get; set; }
        public string OnClickType { get; set; }
        public int OnClickId { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateBannerDTO
    {
        public int BannerId { get; set; }
        public string BannerType { get; set; }
        public string OnClickType { get; set; }
        public int OnClickId { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
    }
}
