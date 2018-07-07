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
  public partial class StudentHomePage : GenPage
  {
    public StudentHomePage()
    {
      InitializeComponent();
      this.welcomL.Text += Session.st.fullName;

      Session.st.getCourseList();
      this.courseNoL.Text = Session.st.courseList.Count.ToString();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void logOutBt_Click(object sender, EventArgs e)
    {
      LogInPage logPage = new LogInPage();
      logPage.Show(); this.Hide();
      MesBox box = new MesBox(logPage, "Log-Out Successfull.. :)", true); box.Show();
    }

    private void updateProfileBt_Click(object sender, EventArgs e)
    {
      StudentProfileUpdateForm stuFrm = new StudentProfileUpdateForm();
      stuFrm.Show(); this.Hide();
    }

    private void findCourseBt_Click(object sender, EventArgs e)
    {
      new StudentFindCourse().Show();
      this.Hide();
    }

    private void myCourseBt_Click(object sender, EventArgs e)
    {
      new StudentMyCoursesPage().Show();
      this.Hide();
    }

    private void mailBt_Click(object sender, EventArgs e)
    {
      new StudentMailPage().Show();
      this.Hide();
    }
  }
}
