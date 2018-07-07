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
  public partial class MailMessagePage : GenPage
  {
    Mails aMail;
    public MailMessagePage(int mailId)
    {
      InitializeComponent();

      aMail = new DataBase().loadMailReal(mailId);
      this.richTextBox1.Text = aMail.text;
      this.richTextBox1.ReadOnly = true;
    }

    private void button7_Click(object sender, EventArgs e)
    {
      if(Session.isTeacher)
      {
        new TeacherHomePage().Show();
        this.Hide();
      }
      else
      {
        new StudentHomePage().Show();
        this.Hide();
      }
    }

    private void submtBT_Click(object sender, EventArgs e)
    {
      if(richTextBox2.Text.Equals(""))
      {
        new MesBox(this,"Please Write Something.. :(",false).Show();
      }
      else
      {
        string from;

        if (Session.isTeacher) from = Session.tc.userName;
        else from = Session.st.userName;
        
        new DataBase().addMail(from,aMail.from,richTextBox2.Text);
        
        if(Session.isTeacher)
        {
          TeacherMailPage p1 = new TeacherMailPage();
          p1.Show(); this.Hide();
          new MesBox(p1, "Mail Successfully Sent.. :)", true).Show();
        }
        else
        {
          StudentMailPage p1 = new StudentMailPage();
          p1.Show(); this.Hide();
          new MesBox(p1, "Mail Successfully Sent.. :)", true).Show();
        }
        
      }
    }
  }
}
