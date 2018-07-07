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
  public partial class StudentCourseView : GenPage
  {
    Course theCourse;

    public StudentCourseView(int _cid)
    {
      InitializeComponent();

      theCourse = new DataBase().loadCourse(_cid);
      this.courseNameL.Text = theCourse.CourseName;
    }

    private void deleteCourseBt_Click(object sender, EventArgs e)
    {

    }

    private void button7_Click(object sender, EventArgs e)
    {
      new StudentHomePage().Show(); this.Hide();
    }

    private void uploadBT_Click(object sender, EventArgs e)
    {
      new MesBox(this,"No Lecture Added yet.. :(",false).Show();
    }

    private void viewStudentBt_Click(object sender, EventArgs e)
    {
      new MesBox(this, "No Notice Added yet.. :(", false).Show();
    }
  }
}
