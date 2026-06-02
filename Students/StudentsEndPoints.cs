namespace DotNg.Students;

public static class StudentsEndPoints
{
    public static void AddStudentsEndpoints(this WebApplication app)
    {
        app.MapGet("Students", () => "Hello Students!");
    }
}