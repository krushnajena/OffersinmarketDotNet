using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class SupportDTO
    {
        public int UserId { get; set; }
        public string UserType { get; set; }
        public string SupportType { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string EmailId { get; set; }
        public string Message { get; set; }
        public int CreatedBy { get; set; }
    }
}
