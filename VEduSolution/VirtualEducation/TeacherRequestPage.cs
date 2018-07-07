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
  public partial class TeacherRequestPage : GenPage
  {
    int pos = 0;
    public TeacherRequestPage()
    {
      InitializeComponent();

      List<KeyValuePair<string, Course>> tmp = new List<KeyValuePair<string, Course>>();
      tmp = new DataBase().getRequestedCourse(Session.tc.userName);

      this.panel1.Controls.Clear();
      pos = 0;

      for (int i = 0; i < tmp.Count; i++)
      {
        RequestControl _crs = new VirtualEducation.RequestControl(tmp[i].Value.ID, this, tmp[i].Key);
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
