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
  public partial class MailControl : UserControl
  {
    int id;
    Form toForm;
    Mails aMail;
    public MailControl(int _no, Form _f)
    {
      InitializeComponent();

      id = _no;
      toForm = _f;

      if (Session.isTeacher) aMail = new DataBase().loadMailTeacher(id);
      else aMail = new DataBase().loadMailStudent(id);
      this.label1.Text += aMail.from;
      this.label2.Text += aMail.date.ToString(GenProperty.dateFormate);
    }

    private void addBt_Click(object sender, EventArgs e)
    {
      //view
      new MailMessagePage(aMail.id).Show();
      toForm.Hide();
    }

    private void rejectBt_Click(object sender, EventArgs e)
    {
      //del
      new DataBase().deleteMail(aMail.id);
      if(Session.isTeacher)
      {
        new TeacherMailPage().Show();
        toForm.Hide();
      }
      else
      {
        new StudentMailPage().Show();
        toForm.Hide();
      }
    }
  }
}
