using System;

namespace AdminApi.Models.App
{
    public class PopularStore
    {
        public int PopularStoreId { get; set; } 
        public int StoreId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
