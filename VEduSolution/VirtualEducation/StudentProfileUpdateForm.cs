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
  public partial class StudentProfileUpdateForm : GenPage
  {
    public StudentProfileUpdateForm()
    {
      InitializeComponent();

      Student thestd = new DataBase().getStudent(Session.st.userName);
      this.nameBx.Text = thestd.fullName;
      this.mailBx.Text = thestd.eMail;

      string pass = new DataBase().getPass(Session.tc.userName);
      //new DataBase().getUserType(Session.tc.userName);
      this.pass1Bx.Text = pass;
      this.pass2Bx.Text = pass;

      this.dateTime.Value = thestd.birthDay;
      if (thestd.gender) this.mle.Checked = true;
      else this.fmle.Checked = true;
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
      new StudentHomePage().Show();
      this.Hide();
    }

    private void submtBT_Click(object sender, EventArgs e)
    {
      bool gnd = mle.Checked;
      new DataBase().updateStudent(nameBx.Text, mailBx.Text, gnd, dateTime.Value);

      StudentHomePage p1 = new StudentHomePage();
      p1.Show(); this.Hide();
      new MesBox(p1, "Information Successfully Updated.. :)", true).Show();
    }
  }
}
