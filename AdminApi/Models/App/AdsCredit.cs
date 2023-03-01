using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class AdsCredit
    {
        public int AdsCreditId { get; set; }
        public int StoreId { get; set; }
        public string TypeOfAds { get; set; }
        public string PurchaseType { get; set; }

        public int NoOfAds { get; set; }
        public DateTime? CreditedOn { get; set; }
        public DateTime? ExpOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
