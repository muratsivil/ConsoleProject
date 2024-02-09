using Intro.Entities;

namespace Intro.Bussiness;

public class CourseManager
{
    readonly Course[] courses = new Course[3];
    public CourseManager()
    {
        Console.WriteLine("Loading...");
        Course course1 = new()
        {
            Id = 1,
            Name = "CSharp",
            Description = ".NET 8",
            Price = 0
        };

        Course course2 = new()
        {
            Id = 1,
            Name = "Java",
            Description = ".NET 8",
            Price = 0
        };

        Course course3 = new()
        {
            Id = 1,
            Name = "Python",
            Description = ".NET 8",
            Price = 0
        };

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
    public Course[] GetAll(){
        return courses;
    }
}
