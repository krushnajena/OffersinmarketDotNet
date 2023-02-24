using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class StoreRatttingDTO
    {
        public int StoreId { get; set; }
        public int UserId { get; set; }
        public double AppliedRatting { get; set; }
        public int CreatedBy { get; set; }
    }
}
