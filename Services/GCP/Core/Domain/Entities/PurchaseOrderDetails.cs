using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
        public class PurchaseOrderDetail
    {
        public long PurchaseOrderDetailID { get; set; }

        public long PurchaseOrderID { get; set; }

        public long ProductID { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public DateTime? RequiredDate { get; set; }

        public string Status { get; set; }

        public string DestinationWarehouse { get; set; }
            
        public PurchaseOrder PurchaseOrder { get; set; }
    }


}