using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HOST_Telery.Data;
using HOST_Telery.Models;
using HOST_Telery.Repository;
using Microsoft.EntityFrameworkCore;

namespace HOST_Telery.Services
{
    public class EmployeeServices : IEmployeeRepository
    {

        private readonly MyDbContext _context;

        public EmployeeServices(MyDbContext context)
        {
            _context = context;
        }

        public async Task Add(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var ToDelete = await GetEmployeeById(id);
            if (ToDelete != null)
            {
                _context.Employees.Remove(ToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Set<Employee>().FindAsync(id);
        }

        public async Task<Employee?> GetByEmail(string email)
        {
            return await _context.Employees.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}