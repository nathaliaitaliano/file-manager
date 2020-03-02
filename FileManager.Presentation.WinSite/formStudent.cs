using FileManager.Common.Layer;
using FileManager.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Presentation.WinSite
{
    public partial class formStudent : Form
    {
        public formStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String studentDni = textBoxStudentDni.Text;
            String name = textBoxName.Text;
            String surname = textBoxSurname.Text;
            DateTime dateOfBirth = pickerAgeOfBirth.Value;
            String fileFormat = comboBoxFileFormat.Text;

            Student student = new Student(studentDni, name, surname, dateOfBirth);
            StudentDao studentDao = StudentDaoFactory.Create(fileFormat);

            studentDao.Add(student);
        }
          
    }
}
