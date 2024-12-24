<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sale: AuditableEntity
    {
        public DateTime date { get; set; }

        public Employee employee {get; set;}

        public Customer customer {get; set;}

        public Branch branch {get; set;}

        public Payment payment {get; set;} 

        public int total { get; set; }
        
    }
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sale: AuditableEntity
    {
        public DateTime date { get; set; }

        public int employeeId {get; set;}

        public Employee employee {get; set;} = null!;   

        public int customerId;

        public Customer customer {get; set;} = null!;


        public int branchId {get; set;}
        public Branch branch {get; set;} = null!;


        public int typePaymentId {get; set;}
        public typePayment typePayment {get; set;}= null!;

        public int total { get; set; }

        public ICollection<SalesDetail> salesDetails { get; set; }
        
    }
>>>>>>> fac42beff8ed83c38e6b30ff1e3f717f9d4ec1e3
}