using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class ViewCountDTO
    {
        public int UserId { get; set; }
        public string ContentType { get; set; }
        public int? ContentId { get; set; }
        public int CreatedBy { get; set; }
    }
}
