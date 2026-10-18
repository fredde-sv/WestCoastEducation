
using System.Security.Cryptography.X509Certificates;
using WestcoastEducation;

namespace WestcoastEducation;

class Program
{
    static void Main()
    {
        SchoolSystem school = new();

        try
        {

            Teacher teacher1 = new()
            {
                FirstName = "Stefan",
                LastName = "Svensson",
                PhoneNumber = "0751659526",
                SocialNumber = "920923-0213",
                Address = "gågatan1 ",
                ZipCode = "91423",
                City = "Malmö",
                Email = "Stefan.Svensson@hej.se",
                Subject = "Samhällkunskap",
            };

            Teacher teacher2 = new()
            {
                FirstName = "Per",
                LastName = "Persson",
                PhoneNumber = "07685758949",
                SocialNumber = "880927-3113",
                Address = "Springatan 1",
                ZipCode = "98738",
                City = "Rönnbäck",
                Email = "Per.Persson@persson.se",
                Subject = "Naturkunskap 1",
            };

            teacher1.Validate();
            teacher2.Validate();
            school.AddTeacher(teacher1);
            school.AddTeacher(teacher2);

            Course course1 = new()
            {
                CourseNumber = "SO1",
                Title = "Samhällskunskap 1",
                Duration = 90,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(90),
                CourseType = CourseType.Classroom,
                Teacher = teacher1,

            };

            Course course2 = new()
            {
                CourseNumber = "NO1",
                Title = "Naturkunskap 1",
                Duration = 90,
                StartDate = DateTime.Today,
                EndDate = DateTime.Today.AddDays(180),
                CourseType = CourseType.Distance,
                Teacher = teacher2,
            };

            school.AddCourse(course1);
            teacher1.CourseTeacher.Add(course1);
            school.AddCourse(course2);
            teacher2.CourseTeacher.Add(course2);

            Student student1 = new()
            {
                FirstName = "Fredrik",
                LastName = "Alm",
                PhoneNumber = "123141",
                SocialNumber = "112332-421",
                Address = "Hbg gata 1",
                ZipCode = "12345",
                Email = "fredik.alm@hej.se",
                City = "Helsingborg",

            };

            Student student2 = new()
            {
                FirstName = "Håkan",
                LastName = "Alm",
                PhoneNumber = "1323141",
                SocialNumber = "1112332-421",
                Address = "Hbg gata 2",
                ZipCode = "13345",
                Email = "hhaaakan@hej.se",
                City = "Malmö",

            };

            student1.Validate();
            student2.Validate();
            school.AddStudent(student1);
            school.AddStudent(student2);
            student1.CourseHistory.Add(course1);
            student1.CourseHistory.Add(course2);
            student2.CourseHistory.Add(course2);

            Console.WriteLine("WestCoast Education");
            Console.WriteLine($"Antal Kurser: {school.Courses.Count}");
            Console.WriteLine($"Antal Lärare: {school.Teachers.Count}");
            Console.WriteLine($"Antal studenter: {school.Students.Count}");

            Console.WriteLine($"\nKurser:");

            foreach (var course in school.Courses)
            {
                Console.WriteLine($"{course.Title}");
            }

            Console.WriteLine("\nLärare:");


            foreach (var teacher in school.Teachers)
            {

                Console.WriteLine($"{teacher.TeacherInfo()}");
            }


            Console.WriteLine("\nStudenter:");

            foreach (var student in school.Students)
            {
                Console.WriteLine(student.StudentInfo());

            }
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Fel: {ex.Message}");
        }

        Console.WriteLine("\nTryck valfri tangent för o avsluta.");
        Console.ReadKey();
    }
}
