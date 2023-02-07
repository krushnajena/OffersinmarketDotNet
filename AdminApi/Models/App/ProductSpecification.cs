using System;

namespace AdminApi.Models.App
{
    public class ProductSpecification
    {
        public int ProductSpecificationId {
            get; set;
        }
        public int ProductId { get; set; }  
        public string Key { get; set; }
        public string Value { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
