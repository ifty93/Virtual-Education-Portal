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
  public partial class TeacherHomePage : GenPage
  {
    public TeacherHomePage()
    {
      InitializeComponent();
      this.welcomL.Text += Session.tc.fullName;
      List<KeyValuePair<string, Course>> tmp = new List<KeyValuePair<string, Course>>();
      tmp = new DataBase().getRequestedCourse(Session.tc.userName);

      if (tmp.Count == 0) this.label2.Visible = false;
      else this.label2.Text = tmp.Count.ToString();
    }

    private void viewCourseBt_Click(object sender, EventArgs e)
    {
      TeacherViewCourses cntPage = new TeacherViewCourses();
      cntPage.Show(); this.Hide();
    }
    private void adCourseBt_Click(object sender, EventArgs e)
    {
      new TeacherAddCourseForm().Show();
      this.Hide();
    }

    private void logOutBt_Click(object sender, EventArgs e)
    {
      LogInPage logPage = new LogInPage();
      logPage.Show(); this.Hide();
      MesBox box = new MesBox(logPage, "Log-Out Successfull.. :)", true); box.Show();
    }

    private void updateProfileBt_Click(object sender, EventArgs e)
    {
      new TeacherProfileUpdateForm().Show();
      this.Hide();
    }

    private void viewStudentBt_Click(object sender, EventArgs e)
    {
      //CourseContainer cntPage = new CourseContainer("This is a Student Name");
      //this.Hide(); cntPage.Show();
      new MesBox(this, "Notice Board is empty.. :(", false).Show();
    }

    private void noticeBt_Click(object sender, EventArgs e)
    {
      //new MesBox(this, "No Mail yet..!", false).Show();
      new TeacherMailPage().Show();
      this.Hide();
    }

    private void viewReqBt_Click(object sender, EventArgs e)
    {
      //new DataBase().tryThis(aTeacher);
      //new MesBox(this, "No Request yet..!", false).Show();
      new TeacherRequestPage().Show(); this.Hide();
    }
  }
}
