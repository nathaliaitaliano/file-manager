using System;

namespace FileManager.Common.Layer
{
    public class Student
    {
        public String StudentDni { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime AgeOfBirth { get; set; }

        public Student()
        {
        }
        public Student(String studentDni, String name, String surname, DateTime ageOfBirth)
        {
            this.StudentDni = studentDni;
            this.Name = name;
            this.Surname = surname;
            this.AgeOfBirth = ageOfBirth;
        }
    }
}
