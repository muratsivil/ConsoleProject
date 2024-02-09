// See https://aka.ms/new-console-template for more information
using Intro.Bussiness;


var courseManager = new CourseManager();
var allCourses = courseManager.GetAll();
foreach (var course in allCourses)
{
    Console.WriteLine($"{course.Name} / {course.Price}");
}
Console.WriteLine("All courses are available");
Console.WriteLine("Code is over");