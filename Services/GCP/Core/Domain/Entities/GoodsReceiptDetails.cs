using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GoodsReceiptDetail
    {
        public long GoodsReceiptDetailID { get; set; }

        public long GoodsReceiptID { get; set; } 

        public long ProductID { get; set; }

        public int ReceivedQuantity { get; set; }

        public string Quality { get; set; }

        public string WarehouseLocation { get; set; }

        public GoodsReceipt GoodsReceipt { get; set; }
    }
}