using DemoStructuralPattern.Core.Interfaces;

namespace DemoStructuralPattern.Api.Endpoints
{
    public static class StudentEndpoints
    {
        public static WebApplication MapStudentEndpoints(this WebApplication app)
        {
            app.MapGet("/getstudents", (IStudentService service) =>
            {
                var students = service.GetStudents();

                return Results.Ok(students);
            });

            return app;
        }
    }
}
