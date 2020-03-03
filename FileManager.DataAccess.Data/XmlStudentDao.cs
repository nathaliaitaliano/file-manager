using FileManager.Common.Layer;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FileManager.DataAccess.Data
{
    public class XmlStudentDao : StudentDao
    {
        public XmlStudentDao()
        {
            if (!File.Exists(@"C:\Users\usuario\source\repos\FileManager\FileRepository\XMLStudantDao.xml"))
            {
                File.Create(@"C:\Users\usuario\source\repos\FileManager\FileRepository\XMLStudantDao.xml").Close();
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
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (TextWriter writer = new StreamWriter(@"C:\Users\usuario\source\repos\FileManager\FileRepository\XMLStudantDao.xml"))
            {
                serializer.Serialize(writer, studentList);
            }
        }

        private List<Student> ReadFromFile()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Student>));
            TextReader reader = new StreamReader(@"C:\Users\usuario\source\repos\FileManager\FileRepository\XMLStudantDao.xml");
            object obj = deserializer.Deserialize(reader);
            List<Student> studentList = (List<Student>)obj;
            reader.Close();

            return studentList;
        }
    }
}