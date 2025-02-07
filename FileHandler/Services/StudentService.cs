using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandler.Contracts;
using FileHandler.Dto;

namespace FileHandler.Services
{
    public class StudentService : IStudent
    {
        List<StudentDto> students;
        public StudentService() { }
        public StudentService(List<StudentDto> _students) { 
        this.students = _students;
        }

        public void DisplayAllStudents() {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| Id   | Name            | Class       | Marks   |");
            Console.WriteLine("------------------------------------------------------------");

            foreach (var student in students)
            {
                Console.WriteLine($"| {student.Id,-4} | {student.Name,-15} | {student.Class,-11} | {student.Marks,8:F2} |");
            }

            Console.WriteLine("------------------------------------------------------------");

        }

        public void DisplayStudents(List<StudentDto> students)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("| Id   | Name            | Class       | Marks   |");
            Console.WriteLine("------------------------------------------------------------");

            foreach (var student in students)
            {
                Console.WriteLine($"| {student.Id,-4} | {student.Name,-15} | {student.Class,-11} | {student.Marks,8:F2} |");
            }

            Console.WriteLine("------------------------------------------------------------");

        }

        public Double getAverageMarks() { 
            double sum = 0;
            foreach (var student in students) {
                sum += student.Marks;
            }    
            return sum / students.Count;
        
        }

        public List<StudentDto> getStudentsOfParticularClass(string className) {
            return students.Where(student => student.Class.Equals(className, StringComparison.OrdinalIgnoreCase)).ToList();
        }


    }
}
