using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
       public class Payment: AuditableEntity
    {
       

        public SalePayment? SalePayment { get; set; }

        public int typePaymentId {get; set;}

        public TypePayment typePayment {get; set;} = null!;

        public int amount {get; set;}

        public DateTime datePayment {get; set;}

    }
}