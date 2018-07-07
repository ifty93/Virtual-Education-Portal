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
  public partial class TeacherAddCourseForm : GenPage
  {
    public TeacherAddCourseForm()
    {
      InitializeComponent();
    }

    private void cancelBt_Click(object sender, EventArgs e)
    {
      new TeacherHomePage().Show();
      this.Hide();
    }

    bool chkForm()
    {
      if (nameBx.Text.Equals(""))
      {
        MesBox box = new MesBox(this, "Please enter the Course Name.. :(", false); box.Show();
        return false;
      }
      if (mxstudentBx.Text.Equals(""))
      {
        MesBox box = new MesBox(this, "Please set the maximum student limit.. :(", false); box.Show();
        return false;
      }
      if (descTexBx.Text.Equals(""))
      {
        MesBox box = new MesBox(this, "Please write some short description.. :(", false); box.Show();
        return false;
      }
      return true;
    }
    private void createtBT_Click(object sender, EventArgs e)
    {
      if(chkForm())
      {
        Course aCourse = new Course(nameBx.Text,descTexBx.Text,Session.tc.userName);
        new DataBase().createCourse(aCourse);

        Session.tc.courseList.Clear();
        Session.tc.getCourseList();
        
        TeacherHomePage p1 = new TeacherHomePage();
        p1.Show(); this.Hide();

        new MesBox(p1, "Course successfully created.. :)", true).Show();
      }
    }
  }
}
