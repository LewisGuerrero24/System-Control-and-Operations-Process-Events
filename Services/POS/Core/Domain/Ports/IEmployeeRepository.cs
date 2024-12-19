using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Ports
{
    public interface IEmployeeRepository
    {
        Task<ICollection<Employee>> GetAllEmployee();

        Task<Employee> EmployeeFindById(int Employee_Id);

        Task<Employee> CreateEmployee(Employee newEmployee);

        Task<Employee> UpdateEmployee(Employee employeeUpdate, Employee newEmployee);

        Task<Employee> DeleteEmployee(Employee employee);
    }
}