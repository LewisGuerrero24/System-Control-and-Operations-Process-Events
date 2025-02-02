<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
       public class Payment: AuditableEntity
    {
        public string name { get; set; }
        public List<Sale> sale {get; set;}
    }
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
       public class Payment: AuditableEntity
    {
       
        public int saleId {get; set;}

        public Sale sale {get; set;} = null!;

        public int typePaymentId {get; set;}

        public typePayment typePayment {get; set;} = null!;

        public int amount {get; set;}

        public DateTime datePayment {get; set;}

    }
>>>>>>> fac42beff8ed83c38e6b30ff1e3f717f9d4ec1e3
}