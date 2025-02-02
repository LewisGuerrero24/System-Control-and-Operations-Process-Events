using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Ports
{
    public interface IEmployeeRepository
    {
        ICollection<Employee> getAllEmployee();

        Employee EmployeeFindById(int employee_Id);

        Employee createEmployee(Employee newEmployee);

        Employee updateEmployee(int employee_Id, Employee employee);

        bool deleteEmployee(int employee_Id);
    }
}