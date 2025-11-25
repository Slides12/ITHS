using DemoDockerComposeAPI_DB.Data.Entities;

namespace DemoDockerComposeAPI_DB.Data.Interfaces
{
    public interface IStudentRepo
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
    }
}
