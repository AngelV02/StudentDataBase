using System;

class Program
{
    static void Main(string[] args)
    {
        using (var dbContext = new StudentDbContext())
        {
            // Create a new student
            var student = new Student { Name = "John Doe" };

            // Add the student to the DbSet and save changes
            dbContext.Students.Add(student);
            dbContext.SaveChanges();

            Console.WriteLine("Student added successfully!");
        }

        Console.ReadLine();
    }
}
