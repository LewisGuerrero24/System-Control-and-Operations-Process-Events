using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public record CustomerDto(string Name,string LastName,string Phone,string Email,string Address);
}