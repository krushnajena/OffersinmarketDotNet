using System;
using System.IO;

namespace AdminApi.Models.App
{
    public class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
