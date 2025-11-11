using DemoStructuralPattern.Data.Entities;
using DemoStructuralPattern.Data.Interface;

namespace DemoStructuralPattern.Data.Repos
{
    public class StudentRepo : IStudentRepo
    {
        public List<Student> GetStudents()
        {
            var students = new List<Student>()
            {
             new Student(1, "Lisa"),
             new Student(2, "Kalle"),
            };

            return students;
        }
    }
}
