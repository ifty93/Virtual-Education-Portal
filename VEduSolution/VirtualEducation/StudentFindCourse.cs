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
  public partial class StudentFindCourse : GenPage
  {
    int pos = 0;
    public StudentFindCourse()
    {
      InitializeComponent();
      this.comboBox1.SelectedIndex = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //Search Button

      if(this.comboBox1.SelectedItem.Equals("Course Name"))
      {
        //new MesBox(this, "Course Name ->" + textBox1.Text, true).Show();
        List<Course> tmp = new List<Course>();
        tmp = new DataBase().findCourseByCourseName(textBox1.Text);

        this.panel2.Controls.Clear();
        pos = 0;

        for (int i = 0; i < tmp.Count; i++)
        {
          ComponentControl _crs = new VirtualEducation.ComponentControl(tmp[i].ID, this);
          _crs.Location = new System.Drawing.Point(34, pos);
          this.panel2.Controls.Add(_crs);

          pos += 115;
        }
      }
      else if (this.comboBox1.SelectedItem.Equals("Teacher Name"))
      {
        //new MesBox(this, "Teacher Name -> " + textBox1.Text, true).Show();
        List<KeyValuePair<string, Course>> tmp = new List<KeyValuePair<string, Course>>();
        tmp = new DataBase().findCourseByTeacherName(textBox1.Text);

        this.panel2.Controls.Clear();
        pos = 0;

        for (int i = 0; i < tmp.Count; i++)
        {
          ComponentControl _crs = new VirtualEducation.ComponentControl(tmp[i].Value.ID, this, tmp[i].Key);
          _crs.Location = new System.Drawing.Point(34, pos);
          this.panel2.Controls.Add(_crs);

          pos += 115;
        }
      }
    }

    private void button7_Click(object sender, EventArgs e)
    {
      new StudentHomePage().Show(); this.Hide();
    }
  }
}
