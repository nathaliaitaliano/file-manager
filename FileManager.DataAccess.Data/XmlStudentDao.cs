using FileManager.Common.Layer;
using System.IO;
using System.Xml.Serialization;

namespace FileManager.DataAccess.Data
{
    public class XmlStudentDao
    {
        public void Add(Student student)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Student));
            using (TextWriter writer = new StreamWriter(@"C:\Users\usuario\source\repos\FileManager\FileRepository\XMLStudantDao.xml"))
            {
                serializer.Serialize(writer, student);
            }
        }
    }
}
