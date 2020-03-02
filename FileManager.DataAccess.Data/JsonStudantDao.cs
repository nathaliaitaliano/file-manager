using FileManager.Common.Layer;
using FileManager.DataAccess.Data;
using System.IO;
using System.Web.Script.Serialization;

namespace FileManager.Presentation.WinSite
{
    public class JsonStudentDao : StudentDao
    {
        public override void Add(Student student)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            using (TextWriter writer = new StreamWriter(@"C:\Users\usuario\source\repos\FileManager\FileRepository\JSONtudantDao.json"))
            {
                writer.WriteLine(serializer.Serialize(student));
            }

        }
    }
}
