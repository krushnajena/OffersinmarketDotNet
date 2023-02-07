using System;

namespace AdminApi.Models.App
{
    public class Cuisine
    {
        public int CuisineId { get; set; }
        public string CuisineName { get;set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
