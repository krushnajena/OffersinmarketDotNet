using System;
using System.Net.NetworkInformation;

namespace AdminApi.Models.App
{
    public class Story
    {
        public int StoryId { get; set; }
        public int StoreId { get; set; }    
        public string Text { get; set; }
        public string Image { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
