using System;

namespace WestcoastEducation

{
    public enum CourseType
    {
        Classroom,
        Distance
    }

    public class Course
    {
        required public string CourseNumber { get; set; }
        required public string Title { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CourseType CourseType { get; set; }
        required public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = [];
        public virtual string GetInfo()
        {
            return $"Kursnummer: {CourseNumber}\n" +
                   $"Titel: {Title}\n" +
                   $"Längd: {Duration} dagar\n" +
                   $"Typ: {CourseType}\n" +
                   $"Startdatum: {StartDate:d}\n" +
                   $"Slutdatum: {EndDate:d}\n" +
                   $"Lärare: {Teacher.FirstName} {Teacher.LastName}";
        }

        public void AddStudent(Student student)
        {
            if (student != null)
            {
                Students.Add(student);
            }
        }
        public void ListStudents()
        {
            Console.WriteLine($"Studenter på kursen {Title}:");

            foreach (var student in Students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }

    }
}
