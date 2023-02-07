using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class CityDTO
    {
        public string CityName { get; set; }
        public int StateId { get; set; }
        public int CreatedBy { get; set; }
    }

    public class CityUpdateDTO
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
        public int CreatedBy { get; set; }
    }
}
