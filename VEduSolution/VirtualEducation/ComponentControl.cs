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
  public partial class ComponentControl : UserControl
  {
    Course theCourse;
    int pos,std;
    Form toForm;

    /*public ComponentControll(string name, int _std, Form _f)
    {
      this.pos = std;
      this.std = _std;
      toForm = _f;

      InitializeComponent();
      this.label1.Text = name;
      this.label2.Text += std;
      //this.pos = pos;
    }*/
    /*public ComponentControll(int _courseId, Form _f)
    {
      theCourse = new DataBase().loadCourse(_courseId);
      this.std = theCourse.NumOfStudent;
      toForm = _f;

      InitializeComponent();
      this.label1.Text = theCourse.CourseName;
      this.label2.Text += theCourse.NumOfStudent;
      //this.pos = pos;
    }*/
    public ComponentControl(int _courseId, Form _f)
    {
      theCourse = new DataBase().loadCourse(_courseId);
      this.std = theCourse.NumOfStudent;
      toForm = _f;

      InitializeComponent();
      this.label1.Text = theCourse.CourseName;
      this.label2.Text += theCourse.NumOfStudent;

      if (Object.ReferenceEquals(toForm.GetType(), new StudentFindCourse().GetType()))
      {
        // if not sent request
        bool hasReq = new DataBase().chkRequest(Session.st.userName, theCourse.ID);
        bool hasCrs = new DataBase().chkCourse(Session.st.userName, theCourse.ID);

        if (hasReq)
        {
          this.button1.Text = "Cancel";
          //this.button1.ForeColor = System.Drawing.Color.OrangeRed;
          this.button1.BackColor = System.Drawing.Color.Coral;
        }
        else if (hasCrs)
        {
          this.button1.Text = "ADDED";
          this.button1.ForeColor = System.Drawing.Color.OrangeRed;
          this.button1.Enabled = false;
        }
        else
        {
          this.button1.Text = "ADD";
          //this.button1.ForeColor = System.Drawing.Color.Black;
          this.button1.BackColor = System.Drawing.Color.LightGreen;
        }
      }
    }

    public ComponentControl(int _courseId, Form _f, string _name)
    {
      theCourse = new DataBase().loadCourse(_courseId);
      this.std = theCourse.NumOfStudent;
      toForm = _f;

      InitializeComponent();
      this.label1.Text = theCourse.CourseName;
      this.button1.Text = "ADD";
      this.label2.Text += theCourse.NumOfStudent;
      this.label2.Text = "By: " + _name;

      // if not sent request
      bool hasReq = new DataBase().chkRequest(Session.st.userName, theCourse.ID);
      bool hasCrs = new DataBase().chkCourse(Session.st.userName, theCourse.ID);

      if (hasReq)
      {
        this.button1.Text = "CANCEL";
        //this.button1.ForeColor = System.Drawing.Color.OrangeRed;
        this.button1.BackColor = System.Drawing.Color.Coral;
      }
      else if (hasCrs)
      {
        this.button1.Text = "ADDED";
        this.button1.ForeColor = System.Drawing.Color.OrangeRed;
        this.button1.Enabled = false;
      }
      else
      {
        this.button1.Text = "ADD";
        //this.button1.ForeColor = System.Drawing.Color.Black;
        this.button1.BackColor = System.Drawing.Color.LightGreen;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (Object.ReferenceEquals(toForm.GetType(), new StudentFindCourse().GetType()))
      {
        if (button1.Text.Equals("CANCEL"))
        {
          new DataBase().cancelRequest(Session.st.userName, theCourse.ID);

          this.button1.Text = "ADD";
          //this.button1.ForeColor = System.Drawing.Color.Black;
          this.button1.BackColor = System.Drawing.Color.LightGreen;
        }
        else
        {
          new DataBase().addRequest(theCourse.getOwner(), Session.st.userName, theCourse.ID);

          this.button1.Text = "CANCEL";
          //this.button1.ForeColor = System.Drawing.Color.OrangeRed;
          this.button1.BackColor = System.Drawing.Color.Coral;
        }
        //ase theCourse,student
      }
      /*else if (Object.ReferenceEquals(toForm.GetType(), new TeacherViewCourses().GetType()))
      {
        new MesBox(toForm, "HELL", true).Show();

        new TeacherCourseView(theCourse.ID).Show();
        toForm.Hide();
      }*/
      else if (Object.ReferenceEquals(toForm.GetType(), new StudentMyCoursesPage().GetType()))
      {
        //new MesBox(toForm,"CHECK",true).Show();
        new StudentCourseView(theCourse.ID).Show();
        toForm.Hide();
      }
      else
      {
        new TeacherCourseView(theCourse.ID).Show();
        toForm.Hide();
      }
    }
  }
}
