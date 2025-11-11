using DemoStructuralPattern.Core.Interfaces;
using DemoStructuralPattern.Data.Entities;
using DemoStructuralPattern.Data.Interface;

namespace DemoStructuralPattern.Core.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepo _repo;

        public StudentService(IStudentRepo repo)
        {
            _repo = repo;
        }

        public List<Student> GetStudents()
        {
            return _repo.GetStudents();
        }
    }
}
