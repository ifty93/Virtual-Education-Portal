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
  public partial class TeacherCourseView : GenPage
  {
    Course theCourse;
    public TeacherCourseView(int _courseId)
    {
      theCourse = new DataBase().loadCourse(_courseId);
      InitializeComponent();

      this.courseNameL.Text = theCourse.CourseName;
      this.studentL.Text += theCourse.NumOfStudent;
    }

    private void button7_Click(object sender, EventArgs e)
    {
      TeacherHomePage tecPag = new TeacherHomePage();
      tecPag.Show(); this.Hide();
    }

    private void courseNameL_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void uploadBT_Click(object sender, EventArgs e)
    {
      
    }

    private void viewStudentBt_Click(object sender, EventArgs e)
    {
      new TeacherViewStudents(theCourse.ID).Show();
      this.Hide();
    }
  }
}
