using System;
using WestcoastEducation;

namespace WestcoastEducation;

public class SchoolSystem
{
    public List<Course> Courses { get; set; } = [];
    public List<Student> Students { get; set; } = [];
    public List<Teacher> Teachers { get; set; } = [];
    public List<EducationManager> EducationManagers { get; set; } = [];
    public List<Administrator> Administrators { get; set; } = [];

    public void AddCourse(Course course)
    {
        if (string.IsNullOrWhiteSpace(course.CourseNumber))
        {
            throw new Exception("Kursnummer saknas.");
        }

        if (string.IsNullOrWhiteSpace(course.Title))
        {
            throw new Exception("Kurstitel saknas.");
        }

        Courses.Add(course);
    }


    public void AddStudent(Student student)
    {
        if (string.IsNullOrWhiteSpace(student.FirstName))
        {
            throw new Exception("Studentens förnamn saknas.");
        }

        if (string.IsNullOrWhiteSpace(student.LastName))
        {
            throw new Exception("Studentens efternamn saknas.");
        }

        Students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        if (string.IsNullOrWhiteSpace(teacher.FirstName))
        {
            throw new Exception("Lärarens förnamn saknas.");
        }

        if (string.IsNullOrWhiteSpace(teacher.LastName))
        {
            throw new Exception("Lärarens efternamn saknas.");
        }

        Teachers.Add(teacher);
    }

    public void AddEducationManager(EducationManager educationManager)
    {
        EducationManagers.Add(educationManager);
    }

    public void AddAdministrator(Administrator administrator)
    {
        Administrators.Add(administrator);
    }

    public void ListCourses()
    {
        foreach (var course in Courses)
        {
            Console.WriteLine(course.GetInfo());
            Console.WriteLine();
        }
    }

    public void ListStudents()
    {
        foreach (var student in Students)
        {
            Console.WriteLine(student.StudentInfo());
        }
    }
}
