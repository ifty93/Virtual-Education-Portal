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
  public partial class TeacherViewCourses : GenPage
  {

    int pos;
    public TeacherViewCourses()
    {
      InitializeComponent();

      pos = 0;
      for(int i=0;i<Session.tc.courseList.Count;i++)
      {
        ComponentControl _crs = new VirtualEducation.ComponentControl(Session.tc.courseList[i].ID, this);
        _crs.Location = new System.Drawing.Point(34, pos);
        this.panel1.Controls.Add(_crs);

        pos += 115;
      }
    }

    private void button7_Click(object sender, EventArgs e)
    {
      TeacherHomePage tecPag = new TeacherHomePage();
      tecPag.Show(); this.Hide();
    }
  }
}
