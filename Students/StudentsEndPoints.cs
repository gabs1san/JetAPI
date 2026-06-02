using DotNg.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace DotNg.Students;

public static class StudentsEndPoints
{
    public static void AddStudentsEndpoints(this WebApplication app)
    {
        
        var routesStudents = app.MapGroup("Students");

        routesStudents.MapPost("", async (AddStudentsRequest req, AppDbContext context,CancellationToken ct) =>
        {
            var exisits = await context.Students.AnyAsync(students => students.Nome == req.Nome, ct);
            if (exisits)
                return Results.Conflict("\nThis name already exists");
            
            
            var newStudent = new Students(req.Nome); 
            await context.Students.AddAsync(newStudent, ct);
            await context.SaveChangesAsync(ct);
            
            var studentsReturn = new StudentsDto(newStudent.Id, newStudent.Nome);
            return Results.Ok(newStudent);
        });

        routesStudents.MapGet("", async (AppDbContext context, CancellationToken ct) =>
        {
            var students = await context.Students
                .Where(students => students.Active ).Select(students => new StudentsDto(students.Id, students.Nome) )
                .ToListAsync(ct);
            return students;
        });

        routesStudents.MapPut("{id:guid}", async (Guid id, UpdateStudentsRequest req, AppDbContext context, CancellationToken ct) =>
        {
            var student = await context.Students.SingleOrDefaultAsync(students =>  students.Id == id, ct);
            if(student is null)
                return Results.NotFound();
            
            student.UpdateName(req.Nome);
            await context.SaveChangesAsync(ct);
            return Results.Ok(new StudentsDto(student.Id,student.Nome));
        });

        routesStudents.MapDelete("{id}", async (Guid id, AppDbContext context, CancellationToken ct) =>
        {
            var students = await context.Students
                .SingleOrDefaultAsync(students => students.Id == id, ct);
            
            if(students is null)
                return Results.NotFound();
            
            students.Desactive();
            await context.SaveChangesAsync(ct);
            return Results.Ok();
        });
    }
}