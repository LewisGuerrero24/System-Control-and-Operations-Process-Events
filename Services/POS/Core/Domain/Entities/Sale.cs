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
}