using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandler.Contracts;
using FileHandler.Dto;

namespace FileHandler.Services
{
    public class EmployeeService : IEmployee
    {
        private List<EmployeeDto> _employees;

        public EmployeeService(List<EmployeeDto> _employees) { 
        this._employees = _employees;   
        }

        public List<EmployeeDto> GetEmployeeList()
        {
            return _employees;
        }

        public List<EmployeeDto> GetEmployeesByDepartment(string department)
        {
            return _employees.Where(emp => emp.Department.Equals(department, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public double CalculateAverageSalary()
        {
            if (_employees==null)
                return 0;

            return _employees.Average(emp => emp.Salary);
        }

        public void DisplayAllEmployee() {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| ID   | Name            | Department   | Salary   |");
            Console.WriteLine("------------------------------------------------------------");

            foreach (var employee in _employees)
            {
                Console.WriteLine($"| {employee.Id,-4} | {employee.Name,-15} | {employee.Department,-12} | {employee.Salary,-8} |");
            }

            Console.WriteLine("------------------------------------------------------------");

        }
        public void DisplayAllEmployee(List<EmployeeDto> employees)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| ID   | Name            | Department   | Salary   |");
            Console.WriteLine("------------------------------------------------------------");

            foreach (var employee in employees)
            {
                Console.WriteLine($"| {employee.Id,-4} | {employee.Name,-15} | {employee.Department,-12} | {employee.Salary,-8} |");
            }

            Console.WriteLine("------------------------------------------------------------");

        }
    }

}
