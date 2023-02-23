using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public int StoreId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
