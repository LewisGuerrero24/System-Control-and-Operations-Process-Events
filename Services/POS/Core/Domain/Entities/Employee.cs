<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : AuditableEntity
    {
        public string name { get; set; }

        public string lastName { get; set; }

        public string position {get; set;}

        public string phone { get; set; }

        public string email { get; set; }

        public DateTime hiring_Date { get; set; }

        public List<Sale> sales {get; set;}




    }
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : AuditableEntity
    {
        public string name { get; set; }

        public string lastName { get; set; }

        public string position {get; set;}

        public string phone { get; set; }

        public string email { get; set; }

        public DateTime hiring_Date { get; set; }

        public ICollection<Sale> sales {get; set;}




    }
>>>>>>> fac42beff8ed83c38e6b30ff1e3f717f9d4ec1e3
}