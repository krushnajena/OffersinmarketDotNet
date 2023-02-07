using System;

namespace AdminApi.Models.App
{
    public class Banner
    {
        public int BannerId { get; set; }
        public string BannerType { get; set; }
        public string OnClickType { get; set; }
        public int OnClickId { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
