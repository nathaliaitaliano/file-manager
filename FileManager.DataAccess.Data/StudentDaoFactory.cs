using FileManager.Presentation.WinSite;
using System;

namespace FileManager.DataAccess.Data
{
    public class StudentDaoFactory
    {
        public static StudentDao Create(String fileFormat)
        {
            if(fileFormat == "XML")
            {
                return new XmlStudentDao();
            }
            if(fileFormat == "JSON")
            {
                return new JsonStudentDao();
            }
            if(fileFormat == "TXT")
            {
                return new TxtStudentDao();
            }
            return null;
        }
    }
}
