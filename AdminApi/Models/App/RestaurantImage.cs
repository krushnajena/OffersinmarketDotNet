﻿using System;

namespace AdminApi.Models.App
{
    public class RestaurantImage
    {
        public int RestaurantImageId { get; set; }
        public int StoreId { get; set; }
        public string ImageType { get; set; }
        public string Image { get; set; }    
        public string Text { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
