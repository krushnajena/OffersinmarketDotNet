using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class ResturentCuisineDTO
    {
        public int StoreId { get; set; }
        public int CreatedBy { get; set; }
        public List<int> resturentCus { get; set; }
    }
    public class ResturentCu
    {
        public int CusineId { get; set; }
    }
}
