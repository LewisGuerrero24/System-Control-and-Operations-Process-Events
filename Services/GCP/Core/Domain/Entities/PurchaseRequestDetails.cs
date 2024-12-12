using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PurchaseRequestDetail
    {
        public long PurchaseRequestDetailID { get; set; }

        public long PurchaseRequestID { get; set; } 

        public long ProductID { get; set; }

        public int Quantity { get; set; }

        public DateTime? NeededByDate { get; set; }

        public PurchaseRequest PurchaseRequest { get; set; }
    }
}