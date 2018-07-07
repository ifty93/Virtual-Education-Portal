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
  public partial class LogInPage : GenPage
  {
    public LogInPage()
    {
      InitializeComponent();
    }

    private void loginBT_Click(object sender, EventArgs e)
    {
      DataBase DB = new DataBase();
      if (DB.userAuth(unameTX.Text, passTX.Text))
      {
        if(DB.getUserType(unameTX.Text)==Convert.ToBoolean(GenProperty.UserType.Teacher))
        {
          Session.setTeacher(unameTX.Text);
          new TeacherHomePage().Show(); this.Hide();
          Session.isTeacher = true;
        }
        else
        {
          Session.isTeacher = false;
          Session.setStudent(unameTX.Text);
          new StudentHomePage().Show(); this.Hide();
        }
      }
      else
      {
        //MessageBox.Show("Wrong Username or Password..");
        MesBox box = new MesBox(this, "Wrong Username or Password.. :(",false);
        box.Show();
      }
    }

    private void registerBT_Click(object sender, EventArgs e)
    {
      RegForm regPage = new RegForm();
      regPage.Show(); this.Hide();
    }
  }
}
