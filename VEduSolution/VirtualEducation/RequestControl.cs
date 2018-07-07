using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualEducation
{
  public partial class RequestControl : UserControl
  {
    Course theCourse;    
    Student theStudent;
    Form toForm;
    
    public RequestControl(int _courseId, Form _f, string _stId)
    {
      InitializeComponent();

      theCourse = new DataBase().loadCourse(_courseId);
      theStudent = new DataBase().getStudent(_stId);
      toForm = _f;

      //new MesBox(new LogInPage(), _name, true).Show();

      this.label1.Text = theCourse.CourseName;
      this.label2.Text = "Req By: "+theStudent.fullName;
    }

    private void addBt_Click(object sender, EventArgs e)
    {
      new DataBase().addStudent(theCourse.ID,theStudent.userName);
      new DataBase().cancelRequest(theStudent.userName, theCourse.ID);

      new TeacherRequestPage().Show(); toForm.Hide();
    }

    private void rejectBt_Click(object sender, EventArgs e)
    {
      new DataBase().cancelRequest(theStudent.userName, theCourse.ID);

      new TeacherRequestPage().Show(); toForm.Hide();
    }
  }
}
