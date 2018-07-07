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
  public partial class StudentControl : UserControl
  {
    Student theStudent;
    Form toForm;
    public StudentControl(string _sid, Form _f)
    {
      InitializeComponent();
      theStudent = new DataBase().getStudent(_sid);
      toForm = _f;

      this.label1.Text += theStudent.fullName;
      this.label2.Text += theStudent.eMail;
    }

    private void addBt_Click(object sender, EventArgs e)
    {
      //mail Button
      if (Object.ReferenceEquals(toForm.GetType(), new TeacherViewStudents().GetType()))
      {
        new WriteMailPage(theStudent.userName, theStudent.eMail, false).Show();
        toForm.Hide();
      }
      else
      {
        new MesBox(toForm,"XX",false).Show();
      }
      
    }
  }
}
