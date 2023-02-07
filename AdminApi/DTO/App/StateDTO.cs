using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class StateDTO
    {
        public string StateName { get; set; }
        public int CreatedBy { get; set; }
    }
    public class StateUpdateDTO
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CreatedBy { get; set; }
    }
}
