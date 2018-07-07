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
  public partial class RegForm : GenPage
  {
    public RegForm()
    {
      InitializeComponent();
      insL.Visible = false;
      instBx.Visible = false;
      dptL.Visible = false;
      dptBx.Visible = false;
      //dateTime.Text = DateTime.Today.ToString("MMMM dd,  yyyy");
      dateTime.Value = DateTime.Today;
    }

    bool chkForm()
    {
      if (!stdnt.Checked && !techr.Checked)
      {
        //MessageBox.Show("Please Select Regester Type");
        MesBox box = new MesBox(this, "Please Select Register Type.. :(", false); box.Show();
        return false;
      }
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
      if (IdBx.Text.Equals(""))
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
      if (techr.Checked)
      {
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
      }
      if (new DataBase().chkUser(IdBx.Text))
      {
        //MessageBox.Show("Username Already Exist :(");
        MesBox box = new MesBox(this, "Sorry, Username Already Exist.. :(", false); box.Show();
        IdBx.Text = ""; return false;
      }
      if(!pass1Bx.Text.Equals(pass2Bx.Text) || pass1Bx.Text.Equals(""))
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
    private void submtBT_Click(object sender, EventArgs e)
    {
      if(chkForm())
      {
        if (techr.Checked)
        {
          bool gen = mle.Checked;
          Teacher aTeacher = new Teacher(IdBx.Text, nameBx.Text, mailBx.Text, dateTime.Value, gen, instBx.Text, dptBx.Text);
          aTeacher.getReg(pass1Bx.Text);
        }
        else
        {
          bool gen = mle.Checked;
          Student aStudent = new Student(IdBx.Text, nameBx.Text, mailBx.Text, dateTime.Value, gen);
          aStudent.getReg(pass1Bx.Text);
        }
        LogInPage logPage = new LogInPage(); logPage.Show(); this.Hide();
        MesBox box = new MesBox(logPage, "Registation Successfull.. :)", true); box.Show();
      }
    }

    private void stdnt_CheckedChanged(object sender, EventArgs e)
    {
      insL.Visible = false;
      instBx.Visible = false;
      dptL.Visible = false;
      dptBx.Visible = false;
    }

    private void techr_CheckedChanged(object sender, EventArgs e)
    {
      insL.Visible = true;
      instBx.Visible = true;
      dptL.Visible = true;
      dptBx.Visible = true;
    }

    private void cncBT_Click(object sender, EventArgs e)
    {
      LogInPage logPage = new LogInPage();
      logPage.Show(); this.Hide();
    }
  }
}
