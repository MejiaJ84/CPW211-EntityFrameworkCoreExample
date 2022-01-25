using EntityFrameworkCoreExample;

using StudentContext dbContext = new();

// Add with EF Core
Student s = new()
{
    FullName = "Jose Mejia",
    EmailAddress = "jurger.smurgen@blorgen.com",
    DateOfBirth = new DateTime(1999, 9, 9)
};

Student stu2 = new()
{
    FullName = "Corvus Corax",
    EmailAddress = "Death2theTraitor@killhorus.com",
    DateOfBirth = new DateTime(1969, 12, 12)
};

dbContext.Students.Add(s); // Preps the student insert statement

dbContext.SaveChanges(); // Execute any pending insert/update/delete queries

dbContext.Students.Add(stu2);
dbContext.SaveChanges();

// Retrieve from DB
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax

// allStudents = ( from stu in dbContext.Students
//                select stu).ToList(); Query syntax

foreach (Student student in allStudents)
{
    Console.WriteLine($"{student.FullName} has an email of {student.EmailAddress}");
    Console.WriteLine();
}