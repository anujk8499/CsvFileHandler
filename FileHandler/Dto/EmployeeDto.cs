using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public EmployeeDto() { }

        public EmployeeDto(int id, string name, double salary, string department)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Department = department;
        }
    }

}
