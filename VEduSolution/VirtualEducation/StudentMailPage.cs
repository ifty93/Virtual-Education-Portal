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
  public partial class StudentMailPage : GenPage
  {
    public StudentMailPage()
    {
      InitializeComponent();

      Session.st.mails.Clear();
      Session.st.getMails();
      //new MesBox(this, Session.st.mails.Count.ToString(), true).Show();

      int pos = 0;
      for (int i = 0; i < Session.st.mails.Count; i++)
      {
        MailControl _ml = new VirtualEducation.MailControl(Session.st.mails[i].id, this);
        _ml.Location = new System.Drawing.Point(34, pos);
        this.panel2.Controls.Add(_ml);
        pos += 115;
      }
    }

    private void button7_Click(object sender, EventArgs e)
    {
      new StudentHomePage().Show();
      this.Hide();
    }
  }
}
