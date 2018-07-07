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
  public partial class TeacherMailPage : GenPage
  {
    public TeacherMailPage()
    {
      InitializeComponent();

      Session.tc.mails.Clear();
      Session.tc.getMails();
      //new MesBox(this, Session.tc.mails.Count.ToString(), true).Show();

      int pos = 0;
      for (int i = 0; i < Session.tc.mails.Count; i++)
      {
        MailControl _ml = new VirtualEducation.MailControl(Session.tc.mails[i].id, this);
        _ml.Location = new System.Drawing.Point(34, pos);
        this.panel2.Controls.Add(_ml);

        //new MesBox(this, Session.tc.mails[i].id.ToString(), true).Show();

        pos += 115;
      }
      //new MesBox(this, Session.tc.mails.Count.ToString(), true).Show();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      new TeacherHomePage().Show();
      this.Hide();
    }
  }
}
