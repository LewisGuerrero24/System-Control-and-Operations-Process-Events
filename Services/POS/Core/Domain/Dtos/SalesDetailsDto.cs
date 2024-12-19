using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public record SalesDetailsDto(  int sales ,int product, int quantity ,int unitPrice, int subtotal);
    
}