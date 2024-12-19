using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Dtos;
using Domain.Entities;

namespace Application.useCases
{
    public interface EmployeeUseCase
    {
        Task<ICollection<Employee>> GetList();

        Task<Employee> EmployeeUnique(int Employee_Id);

        Task<Employee> CreateEmployee(EmployeeDto newEmployee);

        Task<Employee> UpdateCustomer(int employee_Id,Employee newEmployee);

        Task<Employee> DeleteEmployee(int employee_Id);
    }
}