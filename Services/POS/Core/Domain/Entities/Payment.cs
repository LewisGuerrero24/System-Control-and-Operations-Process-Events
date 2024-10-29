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
}