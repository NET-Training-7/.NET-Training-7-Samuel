using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentPortal.Pages
{
    public class StudentListModel : PageModel
    {
        public List<Student> Students;
        public void OnGet()
        {
            var s1 = new Student { Name = "Samuel Sherpa", RollNo = 1234, Contact = "9867877654", Semester = "6", Major = "Computer Science" };
            var s2 = new Student { Name = "Roshan Twayana", RollNo = 124, Contact = "9867877432", Semester = "3", Major = "Art Science" };
            var s3 = new Student { Name = "Suzu Nepal", RollNo = 14, Contact = "9866547654", Semester = "2", Major = "Astronomy Science" };
            var s4 = new Student { Name = "Ashok Dahal", RollNo = 134, Contact = "9456877654", Semester = "8", Major = "Biological Science" };
            
            Students = new List<Student> { s1, s2, s3, s4 };
        }
    }
    public class Student
    {

      public int RollNo { get; set; }
        public string Name { get; set; }    
        public string Major { get; set; }
        public string Contact { get; set; }
        public string Semester { get; set; }

    }
}
