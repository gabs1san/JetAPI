using DotNg.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNg.Students;

public static class StudentsEndPoints
{
    public static void AddStudentsEndpoints(this WebApplication app)
    {
        
        var routesStudents = app.MapGroup("Students");

        routesStudents.MapPost("", async (AddStudentsRequest req, AppDbContext context) =>
        {
            var exisits = await context.Students.AnyAsync(students => students.Nome == req.Nome);
            if (exisits)
                return Results.Conflict("\nThis name already exists");
            
            
            var newStudent = new Students(req.Nome); 
            await context.Students.AddAsync(newStudent);
            await context.SaveChangesAsync();
            
            return Results.Ok(newStudent);
        });
    }
}