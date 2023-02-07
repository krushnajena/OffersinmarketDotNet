using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class CusineDTO
    {
        public string CuisineName { get; set; }
        public int CreatedBy { get; set; }
    }
    public class CusineUpdateDTO
    {
        public int CuisineId { get; set; }
        public string CuisineName { get; set; }
        public int CreatedBy { get; set; }
    }
}
