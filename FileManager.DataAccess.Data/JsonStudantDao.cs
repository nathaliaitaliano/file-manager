using FileManager.Common.Layer;
using FileManager.DataAccess.Data;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace FileManager.Presentation.WinSite
{
    public class JsonStudentDao : FileStudentDao
    {
        public JsonStudentDao()
        {
            if (!File.Exists(@"C:\Users\usuario\source\repos\FileManager\FileRepository\JSONtudantDao.json"))
            {
                File.Create(@"C:\Users\usuario\source\repos\FileManager\FileRepository\JSONtudantDao.json").Close();
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
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (TextWriter writer = new StreamWriter(@"C:\Users\usuario\source\repos\FileManager\FileRepository\JSONtudantDao.json"))
            {
                writer.WriteLine(serializer.Serialize(studentList));
            }
        }

        private List<Student> ReadFromFile()
        {
            JavaScriptSerializer deserializer = new JavaScriptSerializer();
            string jsonContent = File.ReadAllText(@"C:\Users\usuario\source\repos\FileManager\FileRepository\JSONtudantDao.json");
            return (List<Student>)deserializer.Deserialize(jsonContent, typeof(List<Student>));
        }
    }
}