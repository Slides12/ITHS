using DemoDockerComposeAPI_DB.Data.Entities;
using DemoDockerComposeAPI_DB.Data.Interfaces;

namespace DemoDockerComposeAPI_DB.Data.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentContext _context;

        public StudentRepo(StudentContext context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }
    }
}
