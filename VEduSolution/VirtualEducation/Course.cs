using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualEducation
{
  class Course
  {
    string owner;

    int courseId;
    string courseName;
    int numOfStudent=0;
    public string shortdescription;

    public List<Student> studentList = new List<Student>();

    public Course(string name, string desc, string _owner)
    {
      this.courseName = name;
      this.shortdescription = desc;
      this.owner = _owner;
    }

    public Course(int _id, string _name, int _nostudent, string _dsc, string _owner)
    {
      this.courseId = _id;
      this.courseName = _name;
      this.numOfStudent = _nostudent;
      this.shortdescription = _dsc;
      this.owner = _owner;
    }

    public int ID
    {
      set { this.courseId = value; }
      get { return this.courseId; }
    }
    public string CourseName
    {
      set { this.courseName = value; }
      get { return this.courseName; }
    }

    public int NumOfStudent
    {
      set { this.numOfStudent = value; }
      get { return this.numOfStudent; }
    }
    public string getOwner()
    {
      return this.owner;
    }
    public void getStudent()
    {
      new DataBase().getStudentList(this);
    }
  }
}
