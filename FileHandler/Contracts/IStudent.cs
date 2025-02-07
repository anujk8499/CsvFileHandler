using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandler.Dto;

namespace FileHandler.Contracts
{
    public  interface IStudent
    {
        public void DisplayAllStudents();
        public void DisplayStudents(List<StudentDto> students);
        public Double getAverageMarks();
        public List<StudentDto> getStudentsOfParticularClass(string className);
    }
}
