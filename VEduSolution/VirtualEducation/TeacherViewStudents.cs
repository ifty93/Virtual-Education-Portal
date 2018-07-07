using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualEducation
{
  public partial class TeacherViewStudents : GenPage
  {
    Course theCourse;

    public TeacherViewStudents(){ }
    public TeacherViewStudents(int _cid)
    {
      InitializeComponent();
      theCourse = new DataBase().loadCourse(_cid);

      theCourse.getStudent();
      int pos = 0;
      for (int i = 0; i < theCourse.studentList.Count; i++)
      {
        StudentControl _std = new VirtualEducation.StudentControl(theCourse.studentList[i].userName, this);
        _std.Location = new System.Drawing.Point(34, pos);
        this.panel1.Controls.Add(_std);

        pos += 115;
      }
    }

    private void button7_Click(object sender, EventArgs e)
    {
      TeacherHomePage tecPag = new TeacherHomePage();
      tecPag.Show(); this.Hide();
    }
  }
}
