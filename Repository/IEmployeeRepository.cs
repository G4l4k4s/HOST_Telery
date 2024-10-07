using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Models;

namespace HOST_Telery.Repository
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee?> GetByEmail(string email);
        Task Add(Employee employee);
        Task Update(Employee employee);
        Task Delete(int id);
    }
}