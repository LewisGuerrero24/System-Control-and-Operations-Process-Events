using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GoodsReceipt
    {
        public long GoodsReceiptID { get; set; }

        public long PurchaseOrderID { get; set; } 

        public DateTime ReceiptDate { get; set; }

        public long ReceivedBy { get; set; }

        public string ReceiptStatus { get; set; }

        public string Notes { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
    }

}