using FileManager.Common.Layer;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileManager.DataAccess.Data
{
    class TxtStudentDao : FileStudentDao
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
            List<Student> studentList = new List<Student>();
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
    }
}
