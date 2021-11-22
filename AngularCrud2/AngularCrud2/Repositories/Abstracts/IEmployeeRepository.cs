using AngularCrud2.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCrud2.Repositories.Abstracts
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployee();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> CreateEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(Employee employee);
    }
}
