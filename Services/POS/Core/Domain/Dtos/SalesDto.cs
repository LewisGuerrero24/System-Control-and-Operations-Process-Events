using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public record SalesDto(DateTime Date, int EmployeeId,int CustomerId,int BranchId,int TypePaymentId,int Total);    
}