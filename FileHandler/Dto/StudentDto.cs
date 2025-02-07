using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler.Dto
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public double Marks { get; set; }

        public StudentDto() { }

        public StudentDto(int id, string name, string studentClass, double marks)
        {
            Id = id;
            Name = name;
            Class = studentClass;
            Marks = marks;
        }
    }
}
