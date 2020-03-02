using FileManager.Presentation.WinSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return null;
        }
    }
}
