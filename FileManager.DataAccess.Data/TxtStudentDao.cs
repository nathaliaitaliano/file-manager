using FileManager.Common.Layer;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileManager.DataAccess.Data
{
    class TxtStudentDao : StudentDao
    {
        public TxtStudentDao()
        {
            if (!File.Exists(@"C:\Users\usuario\source\repos\FileManager\FileRepository\TXTStudentDao.txt"))
            {
                File.Create(@"C:\Users\usuario\source\repos\FileManager\FileRepository\TXTStudentDao.txt").Close();
                WriteToFile(new List<Student>());
            }
        }

        public override void Add(Student student)
        {
            List<Student> studentList = ReadFromFile();
            studentList.Add(student);
            WriteToFile(studentList);
        }

        private void WriteToFile(List<Student> studentList)
        {
            using (StreamWriter serializer = new StreamWriter(@"C:\Users\usuario\source\repos\FileManager\FileRepository\TXTStudentDao.txt"))
            {
                foreach (Student student in studentList)
                {
                    serializer.WriteLine(
                        student.StudentDni + ", " +
                        student.Name + ", " +
                        student.Surname + ", " +
                        student.DateOfBirth);
                }
            }
        }

        private List<Student> ReadFromFile()
        {
            List<Student> studentList = new List<Student>();
            string listLine;

            using (StreamReader deserializer = new StreamReader(@"C:\Users\usuario\source\repos\FileManager\FileRepository\TXTStudentDao.txt"))
            {
                while ((listLine = deserializer.ReadLine()) != null)
                {
                    string[] studentData = listLine.Split(',');
                    string studentDni = studentData[0];
                    string name = studentData[1];
                    string surname = studentData[2];
                    DateTime dateOfBirth = DateTime.Parse(studentData[3]);

                    Student student = new Student(studentDni, name, surname, dateOfBirth);
                    studentList.Add(student);
                }
                return studentList;
            }
        }
    }
}
