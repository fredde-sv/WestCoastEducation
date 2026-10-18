using System;

namespace WestcoastEducation;

public class EducationManager : Teacher
{
    public DateTime EmploymentDate { get; set; }
    public virtual string EducationManagerInfo()
    {
        return $"Utbildningsledare: {GetInfo()}, Anställd: {EmploymentDate:yyyy-MM-dd}";
    }
}
