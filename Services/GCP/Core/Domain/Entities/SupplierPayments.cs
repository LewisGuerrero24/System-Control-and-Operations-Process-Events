using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SupplierPayment
    {
        public long SupplierPaymentID { get; set; }

        public long PurchaseOrderID { get; set; } 

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
    }
}