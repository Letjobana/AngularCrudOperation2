using AngularCrud2.Data;
using AngularCrud2.Models;
using AngularCrud2.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCrud2.Repositories.Concrets
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;
        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> CreateEmployee(Employee employee)
        {
            try
            {
                _context.GetEmployees.Add(employee);
                await _context.SaveChangesAsync();
                return employee;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteEmployee(Employee employee)
        {
            try
            {
                _context.GetEmployees.Remove(employee);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            try
            {
                return await _context.GetEmployees.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            try
            {
                return await _context.GetEmployees.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateEmployee(Employee employee)
        {
            try
            {
                _context.GetEmployees.Update(employee);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}