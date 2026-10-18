using System;


namespace WestcoastEducation;

public class Administrator : EducationManager
{
    public virtual string AdministratorInfo()
    {
        return $"Administratör:  {GetInfo()}";
    }

}
