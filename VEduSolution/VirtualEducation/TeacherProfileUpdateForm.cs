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
  public partial class TeacherProfileUpdateForm : GenPage
  {
    public TeacherProfileUpdateForm()
    {
      InitializeComponent();

      Teacher theTeacher = new DataBase().getTeacher(Session.tc.userName);
      this.nameBx.Text = theTeacher.fullName;
      this.mailBx.Text = theTeacher.eMail;

      string pass = new DataBase().getPass(Session.tc.userName);
      //new DataBase().getUserType(Session.tc.userName);
      this.pass1Bx.Text = pass;
      this.pass2Bx.Text = pass;

      this.dateTime.Value = theTeacher.birthDay;
      if (theTeacher.gender) this.mle.Checked = true;
      else this.fmle.Checked = true;

      this.instBx.Text = theTeacher.institution;
      this.dptBx.Text = theTeacher.dept;
    }

    bool chkForm()
    {
      if (nameBx.Text.Equals(""))
      {
        //MessageBox.Show("Please Fill-up All Fields");
        MesBox box = new MesBox(this, "Please Fill-up All Fields.. :(", false); box.Show();
        return false;
      }
      if (mailBx.Text.Equals(""))
      {
        //MessageBox.Show("Please Fill-up All Fields");
        MesBox box = new MesBox(this, "Please Fill-up All Fields.. :(", false); box.Show();
        return false;
      }
      if (dateTime.Text.Equals(DateTime.Today.ToString("MMMM dd,  yyyy")))
      {
        //MessageBox.Show("Please Select Your Dath of Birth");
        MesBox box = new MesBox(this, "Please Select Your Dath of Birth.. :(", false); box.Show();
        return false;
      }
      if (!mle.Checked && !fmle.Checked)
      {
        //MessageBox.Show("Please Select Your Gender");
        MesBox box = new MesBox(this, "Please Select Your Gender.. :(", false); box.Show();
        return false;
      }
      if (instBx.Text.Equals(""))
      {
        //MessageBox.Show("Please Fill-up All Fields");
        MesBox box = new MesBox(this, "Please Fill-up All Fields.. :(", false); box.Show();
        return false;
      }
      if (dptBx.Text.Equals(""))
      {
        //MessageBox.Show("Please Fill-up All Fields");
        MesBox box = new MesBox(this, "Please Fill-up All Fields.. :(", false); box.Show();
        return false;
      }
      
      if (!pass1Bx.Text.Equals(pass2Bx.Text) || pass1Bx.Text.Equals(""))
      {
        //MessageBox.Show("Password Did not matched..!");
        if (pass1Bx.Text.Equals(pass2Bx.Text))
        {
          MesBox box = new MesBox(this, "Sorry, Password can't be empty.. :(", false); box.Show();
        }
        else
        {
          MesBox box = new MesBox(this, "Sorry, Password Did not matched.. :(", false); box.Show();
          pass1Bx.Text = ""; pass2Bx.Text = "";
        }
        return false;
      }
      return true;
    }

    private void cancelBt_Click(object sender, EventArgs e)
    {
      new TeacherHomePage().Show();
      this.Hide();
    }

    private void submtBT_Click(object sender, EventArgs e)
    {
      if(chkForm())
      {
        bool gnd = mle.Checked;
        new DataBase().updateTeacher(nameBx.Text, mailBx.Text, gnd, dateTime.Value, instBx.Text, dptBx.Text);

        TeacherHomePage p1 = new TeacherHomePage();
        p1.Show();  this.Hide();
        new MesBox(p1,"Information Successfully Updated.. :)",true).Show();
      }
    }
  }
}
