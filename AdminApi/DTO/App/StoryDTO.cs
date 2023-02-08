using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class StoryDTO
    {
        public int StoreId { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
    }
}
