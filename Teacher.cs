using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using WestcoastEducation;

namespace WestcoastEducation;

public class Teacher : Account
{
    public required string Subject { get; set; }
    public List<Course> CourseTeacher { get; set; } = [];
    public virtual string TeacherInfo()
    {
        string courseNumber = "";

        foreach (var course in CourseTeacher)
        {
            if (courseNumber != "")
                courseNumber += ", ";

            courseNumber += course.CourseNumber;
        }

        return $"{FirstName} {LastName} ämnen: {courseNumber}";

    }
}
