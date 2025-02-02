using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PurchaseRequest
    {
        public long PurchaseRequestID { get; set; }

        public DateTime RequestDate { get; set; }

        public long RequestedBy { get; set; }

        public string Status { get; set; }

        public string Comments { get; set; }

    }
}