using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Dtos
{
    public class PaymentDTo
    {
        public int typePaymentId {get; set;}

        public  TypePayment typePayment {get; set;} = null!;

        public int amount {get; set;}

        public DateTime datePayment {get; set;}

    }
}