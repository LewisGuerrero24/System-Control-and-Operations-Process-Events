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

        public SalePayment? SalePayment { get; set; }

        public int typePaymentId {get; set;}
        public TypePayment typePayment {get; set;}= null!;

        public int total { get; set; }

        public ICollection<SalesDetail>? salesDetails { get; set; }
        
    }
}