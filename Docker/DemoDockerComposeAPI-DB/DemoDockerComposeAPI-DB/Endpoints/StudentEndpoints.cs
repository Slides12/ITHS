using DemoDockerComposeAPI_DB.Data.Entities;
using DemoDockerComposeAPI_DB.Data.Interfaces;

namespace DemoDockerComposeAPI_DB.Endpoints
{
    public static class StudentEndpoints
    {
        public static WebApplication MapStudentEndpoints(this WebApplication app)
        {

            app.MapGet("/api/getstudents", (IStudentRepo repo) =>
            {
                var students = repo.GetAllStudents();
                return Results.Ok(students);
            });

            app.MapPost("/api/addstudent", (IStudentRepo repo, Student student) =>
            {
                repo.AddStudent(student);
                return Results.Created();
            });


            return app;
        }
    }
}
