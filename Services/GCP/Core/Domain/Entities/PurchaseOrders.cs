using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PurchaseOrder 
    {

        public int PurchaseOrderID { get; set; }
        
        public int SupplierID { get; set; }

        public DateTime OrderDate { get; set; }
        
        public DateTime? EstimatedDeliveryDate { get; set; }
        
        public DateTime? ActualDeliveryDate { get; set; }
        
        public string PaymentTerms { get; set; }
        
        public string Currency { get; set; }
        
        public decimal Discount { get; set; }
        
        public string Notes { get; set; }
        
        public string Status { get; set; }

    }
}