using FileHandler.Contracts;
using FileHandler.Dto;
using FileHandler.Services;

namespace FileHandler {


    class Program
    {

        static void Main(string[] args)
        {
            EmployeeManage();
            StudentManage();
        }

        public static void EmployeeManage()
        {
            var EmployeeReader = new CsvFileHandlerService<EmployeeDto>();
            string studentFilePath = "C:/Users/DELL/Documents/employee.csv";
            List<EmployeeDto> EmployeeList = EmployeeReader.ParseCsvGeneric<EmployeeDto>(studentFilePath);
            EmployeeService employeeService = new EmployeeService(EmployeeList);
            List<EmployeeDto> ItEmployee = employeeService.GetEmployeesByDepartment("MARKETING");
            Console.WriteLine("Displaying all Employee");
            employeeService.DisplayAllEmployee();
            Console.WriteLine("Displaying IT Employee");
            employeeService.DisplayAllEmployee(ItEmployee);
            Console.WriteLine("AverageSalary : " + employeeService.CalculateAverageSalary());
        }

        public static void StudentManage()
        {
            var StudentReader = new CsvFileHandlerService<StudentDto>();
            List<StudentDto> StudentList = StudentReader.ParseCsvGeneric<StudentDto>("C:/Users/DELL/Documents/Student.csv");
            StudentService studentService = new StudentService(StudentList);
            Console.WriteLine("Displaying all students : ");
            studentService.DisplayAllStudents();
            Console.WriteLine("Average marks : " + studentService.getAverageMarks());
            List<StudentDto> studentIn10 = studentService.getStudentsOfParticularClass("10");
            Console.WriteLine("Student in class 10th : ");
            studentService.DisplayStudents(studentIn10);

        }
    }

}

