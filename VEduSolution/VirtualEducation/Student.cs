using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualEducation
{
  class Student : Persion
  {
    public List<Course> courseList = new List<Course>();
    public List<Mails> mails = new List<Mails>();

    public Student(){}
    public Student(string _userName, string _fullName, string _eMail, DateTime _dob, bool _gender)
    {
      this.userName = _userName;
      this.fullName = _fullName;
      this.eMail = _eMail;

      this.birthDay = _dob;
      this.gender = _gender;
    }
    public void getReg(string _pass)
    {
      new DataBase().regStudent(this, _pass);
    }
    public void getCourseList()
    {
      new DataBase().StudentGetCourse(this);
    }
    public void getMails()
    {
      new DataBase().studentGetMails(this);
    }
  }
}
