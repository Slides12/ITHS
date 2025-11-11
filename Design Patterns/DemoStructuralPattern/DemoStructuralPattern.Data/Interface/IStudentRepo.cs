using DemoStructuralPattern.Data.Entities;

namespace DemoStructuralPattern.Data.Interface
{
    public interface IStudentRepo
    {
        List<Student> GetStudents();
    }
}
