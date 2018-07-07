using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VirtualEducation
{
  class Teacher : Persion
  {
    public string institution;
    public string dept;

    public List<Course> courseList;
    public List<Mails> mails = new List<Mails>();

    public Teacher(){}
    public Teacher(string _userName, string _fullName, string _eMail, DateTime _dob, bool _gender, string _inst, string _dept)
    {
      this.userName = _userName;
      this.fullName = _fullName;
      this.eMail = _eMail;

      this.birthDay = _dob;
      this.gender = _gender;

      this.institution = _inst;
      this.dept = _dept;
    }
    public void getReg(string _pass)
    {
      new DataBase().regTeacher(this, _pass);
    }
    public void getCourseList()
    {
      new DataBase().TeacherGetCourse(this);
    }

    public void getMails()
    {
      new DataBase().teacherGetMails(this);
    }
  }
}
