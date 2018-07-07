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
  public partial class WriteMailPage : GenPage
  {
    bool isStudent = false;
    string toId;
    public WriteMailPage(string _toId, string _toAdd, bool flag)
    {
      InitializeComponent();

      toId = _toId;
      isStudent = flag;

      this.label3.Text = _toAdd;
    }

    private void cancelBt_Click(object sender, EventArgs e)
    {
      if(isStudent)
      {
        new StudentHomePage().Show();
        this.Hide();
      }
      else
      {
        new TeacherHomePage().Show();
        this.Hide();
      }
    }

    private void button7_Click(object sender, EventArgs e)
    {
      if (isStudent)
      {
        new StudentHomePage().Show();
        this.Hide();
      }
      else
      {
        new TeacherHomePage().Show();
        this.Hide();
      }
    }

    private void createtBT_Click(object sender, EventArgs e)
    {
      if(richTextBox1.Text.Equals(""))
      {
        new MesBox(this,"Write something.. :(",false).Show();
      }
      else
      {
        string from;
        if (isStudent) from = Session.st.userName;
        else from = Session.tc.userName;

        new DataBase().addMail(from, toId, richTextBox1.Text);
        new MesBox(this, "Successfully sent.. :)", true).Show();
      }
    }
  }
}
