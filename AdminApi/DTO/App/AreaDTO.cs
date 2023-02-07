using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class AreaDTO
    {
        public int CityId { get; set; }
        public string AreaName { get; set; }
        public int CreatedBy { get; set; }
    }

    public class AreaUpdateDTO
    {
        public int AreaId { get; set; }
        public int CityId { get; set; }
        public string AreaName { get; set; }
        public int CreatedBy { get; set; }
    }
}
