using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualEducation
{
  class Session
  {
    public static Student st = new Student();
    public static Teacher tc = new Teacher();
    public static bool isTeacher = false;

    public static void setStudent(string _username)
    { 
      Session.st = new DataBase().getStudent(_username);
      //Session.st.getCourseList();
    }

    public static void setTeacher(string _username)
    {
      Session.tc = new DataBase().getTeacher(_username);
      Session.tc.getCourseList();
    }

  }
}
