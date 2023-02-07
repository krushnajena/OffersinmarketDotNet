using System;

namespace AdminApi.Models.App
{
    public class ViewCount
    {
        public int ViewCountId { get; set; }
        public int UserId { get; set; } 
        public string ContentType { get; set; }
        public int? ContentId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
