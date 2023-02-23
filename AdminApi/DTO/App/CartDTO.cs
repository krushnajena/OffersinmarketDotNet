using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class CartDTO
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public int StoreId { get; set; }
        public int CreatedBy { get; set; }
    }
}
