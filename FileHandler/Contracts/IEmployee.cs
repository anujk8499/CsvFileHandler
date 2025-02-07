using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandler.Dto;

namespace FileHandler.Contracts
{
    internal interface IEmployee
    {
        public List<EmployeeDto> GetEmployeeList();
        public List<EmployeeDto> GetEmployeesByDepartment(string department);
        public double CalculateAverageSalary();
        public void DisplayAllEmployee();
        public void DisplayAllEmployee(List<EmployeeDto> employees);
    }
}
