using System;
using System.Runtime.InteropServices;

namespace WestcoastEducation;

public class Student : Account
{
    public List<Course> CourseHistory { get; set; } = [];
    public virtual string StudentInfo()
    {
        string courseNumber = "";

        foreach (var course in CourseHistory)
        {
            if (courseNumber != "")
                courseNumber += ", ";

            courseNumber += course.CourseNumber;
        }

        return $"{FirstName} {LastName} är inskriven på {courseNumber}";

    }
}



