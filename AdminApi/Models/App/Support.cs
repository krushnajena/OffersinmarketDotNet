using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class Support
    {
        public int SupportId { get; set; }
        public string UserType { get; set; }
        public int UserId { get; set; }
        public string SupportType { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string Message { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }

}
