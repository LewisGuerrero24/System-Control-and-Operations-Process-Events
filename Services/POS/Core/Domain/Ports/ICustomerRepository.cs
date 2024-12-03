using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Ports
{
    public interface ICustomerRepository
    {
        ICollection<Customer> getAllPayment();

        Customer CustomerFindById(int customer_Id);

        Customer createCustomer(Customer newCustomer);

        Customer updateCustomer(int customer_Id, Customer customer);

        bool deletePayment(int customer_Id);
    }
}