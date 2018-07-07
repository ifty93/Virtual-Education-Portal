using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VirtualEducation
{
  class DataBase
  {
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VEduSolution\VirtualEducation\DataBases\MyDB.mdf;Integrated Security=True;Connect Timeout=30");
    public int executeQuery(string query)
    {
      //insert, Update, delete
      SqlCommand cmd = new SqlCommand(query, con);

      con.Open();
      int updatedRo = cmd.ExecuteNonQuery();
      con.Close();

      //new MesBox(new RegForm(), ro.ToString(), true).Show();
      return updatedRo;
    }

    int searchQuery(string query)
    {
      SqlCommand cmd = new SqlCommand(query, con); con.Open();
      int noRow = 0;
      try
      {
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read()) noRow++;
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

      //new MesBox(new LogInPage(), "Test >> "+noRow.ToString(), true).Show();

      /*{
        noRow++;
        for (int i = 0; i < dr.FieldCount; i++) new MesBox(new RegPage(), dr.GetName(i).ToString(), true).Show();
      }*/

      con.Close();
      return noRow;
    }

    SqlDataReader getReader(string query)
    {
      SqlCommand cmd = new SqlCommand(query, con); con.Open();
      SqlDataReader dr = cmd.ExecuteReader();

      return dr;
    }

    public string getPass(string usr)
    {
      string query = "select * from UserInfo where username='" + usr + "'";
      SqlDataReader dr = getReader(query); dr.Read();

      string pass = (string)dr[1];
      con.Close();

      new MesBox(new LogInPage(), pass, false);

      return pass;
    }

    public bool getUserType(string uName)
    {
      string query = "select * from UserInfo where username='" + uName + "'";
      SqlDataReader dr = getReader(query); dr.Read();

      bool ret = (bool)dr[2];
      con.Close();

      return ret;
    }
    public bool userAuth(string uName, string uPass)
    {
      //string query = "select * from UserInfo where username='" + uName + "' and password='" + uPass + "'";
      string query = "select * from UserInfo where CONVERT(VARBINARY(20), username) = CONVERT(VARBINARY(20), '" + uName + "') and CONVERT(VARBINARY(20), password) = CONVERT(VARBINARY(20), '" + uPass + "')";
      //CONVERT(VARBINARY(20), username) = CONVERT(VARBINARY(20), 'A');
      Console.WriteLine(query);
      if (searchQuery(query) == 1) return true;
      return false;
    }
    public bool chkUser(string uName)
    {
      string query = "select * from UserInfo where username='" + uName + "'";
      if (searchQuery(query) == 1) return true;
      return false;
    }
    public void regStudent(Student _aStudent, string pass)
    {
      bool typ = Convert.ToBoolean(GenProperty.UserType.Student);
      string query = "insert into UserInfo values('" + _aStudent.userName + "','" + pass + "','" + typ + "')";
      executeQuery(query);

      query = "insert into StudentInfo values('" + _aStudent.userName + "','" + _aStudent.fullName + "','" + _aStudent.eMail + "','" + _aStudent.gender + "','" + _aStudent.birthDay + "')";
      executeQuery(query);
    }
    public void regTeacher(Teacher _aTeacher, string pass)
    {
      bool typ = Convert.ToBoolean(GenProperty.UserType.Teacher);
      string query = "insert into UserInfo values('" + _aTeacher.userName + "','" + pass + "','" + typ + "')";
      executeQuery(query);

      query = "insert into TeacherInfo values('" + _aTeacher.userName + "','" + _aTeacher.fullName + "','" + _aTeacher.eMail + "','" + _aTeacher.gender + "','" + _aTeacher.birthDay + "','" + _aTeacher.institution + "','" + _aTeacher.dept + "')";
      executeQuery(query);
    }
    //asfkljdwsklfjklsjdgjljg
    public Course loadCourse(int _id)
    {
      string query = "select * from CourseInfo where courseid='" + _id + "'";
      SqlCommand cmd = new SqlCommand(query, con);
      con.Open();
      SqlDataReader dr = cmd.ExecuteReader();

      dr.Read();
      Course temp = new Course((int)dr[0], (string)dr[1], (int)dr[2], (string)dr[3], (string)dr[4]);
      con.Close();

      return temp;
    }
    public void createCourse(Course _aCourse)
    {
      string query = "insert into CourseInfo(coursename,description,ownerid) values('" + _aCourse.CourseName + "','" + _aCourse.shortdescription + "','" + _aCourse.getOwner() + "')";
      executeQuery(query);
    }

    public Teacher getTeacher(string _username)
    {
      string query = "select * from TeacherInfo where username='" + _username + "'";
      SqlDataReader dr = getReader(query); dr.Read();

      //new MesBox(new LogInPage(), "Chk-10", true).Show();

      Teacher aTeacher = new Teacher((string)dr[0], (string)dr[1], (string)dr[2], (DateTime)dr[4], (bool)dr[3], (string)dr[5], (string)dr[6]);
      con.Close();

      return aTeacher;
    }
    public void TeacherGetCourse(Teacher _aTeacher)
    {
      string query = "select * from CourseInfo where ownerid='" + _aTeacher.userName + "'";

      SqlCommand cmd = new SqlCommand(query, con);
      con.Open();
      SqlDataReader dr = cmd.ExecuteReader();

      _aTeacher.courseList = new List<Course>();
      //new MesBox(new LogInPage(), (string)dr[1], true).Show();
      while (dr.Read())
      {
        Course temp = new Course((int)dr[0], (string)dr[1], (int)dr[2], (string)dr[3], (string)dr[4]);
        //for (int i = 0; i < dr.FieldCount; i++) {temp = new Course((int)dr[0], (string)dr[1], (int)dr[2], (Teacher)dr[4]); }
        //new MesBox(new LogInPage(), temp.getOwner(), true).Show();

        _aTeacher.courseList.Add(temp);
        //new MesBox(new LogInPage(), (string)dr[1], true).Show();
      }

      con.Close();
    }


    public Student getStudent(string _username)
    {
      string query = "select * from StudentInfo where username='" + _username + "'";
      SqlDataReader dr = getReader(query); dr.Read();

      Student aStudent = new Student((string)dr[0], (string)dr[1], (string)dr[2], (DateTime)dr[4], (bool)dr[3]);
      con.Close();

      return aStudent;
    }


    public void tryThis(Teacher _aTeacher)
    {
      string demoX = "select TeacherInfo.username, TeacherInfo.dept, CourseInfo.ownerid, CourseInfo.coursename from TeacherInfo, CourseInfo where TeacherInfo.username = CourseInfo.ownerid and CourseInfo.ownerid='" + _aTeacher.userName + "'";
      SqlCommand cmd = new SqlCommand(demoX, con);
      con.Open();
      SqlDataReader dr = cmd.ExecuteReader();

      while (dr.Read())
      {
        string str = "";
        for (int i = 0; i < dr.FieldCount; i++) str += "/" + (dynamic)dr[i].ToString();
        new MesBox(new LogInPage(), str + "<<", true).Show();
      }
    }

    internal List<KeyValuePair<string, Course>> findCourseByTeacherName(string key)
    {
      key = key.Trim().ToLower();
      List<KeyValuePair<string, Course>> res = new List<KeyValuePair<string, Course>>();

      List<string> words = new List<string>();
      words = key.Replace(",", "").Replace(":", "").Replace(".", "").Replace("'", "").Replace("(", " ").Replace(")", " ").Split(' ').ToList();

      string query = "select TeacherInfo.fullname, CourseInfo.courseid, CourseInfo.coursename, CourseInfo.totalstudent, CourseInfo.description, CourseInfo.ownerid from TeacherInfo, CourseInfo where CourseInfo.ownerid = TeacherInfo.username";
      SqlDataReader dr = getReader(query);

      while (dr.Read())
      {
        string _Name = (string)dr["fullname"];
        string _qName = _Name;
        _qName = _qName.Trim().ToLower();

        List<string> nameList = new List<string>();
        nameList = _qName.Replace(",", "").Replace(":", "").Replace(".", "").Replace("'", "").Replace("(", " ").Replace(")", " ").Split(' ').ToList();

        for (int i = 0; i < words.Count; i++)
        {
          for (int k = 0; k < nameList.Count; k++)
          {
            if (words[i].Equals(nameList[k]))
            {
              Course temp = new Course((int)dr[1], (string)dr[2], (int)dr[3], (string)dr[4], (string)dr[5]);
              res.Add(new KeyValuePair<string, Course>(_Name, temp));
            }
          }
        }
      }

      con.Close(); return res;
    }

    internal List<Course> findCourseByCourseName(string key)
    {
      key = key.Trim().ToLower();
      List<Course> res = new List<Course>();

      List<string> words = new List<string>();
      words = key.Replace(",", "").Replace(":", "").Replace(".", "").Replace("'", "").Replace("(", " ").Replace(")", "").Split(' ').ToList();

      //string query = "select TeacherInfo.fullname, CourseInfo.courseid, CourseInfo.coursename, CourseInfo.totalstudent, CourseInfo.description, CourseInfo.ownerid from TeacherInfo, CourseInfo where CourseInfo.ownerid = TeacherInfo.username";
      string query = "Select * from CourseInfo where courseid >= '0'";
      SqlDataReader dr = getReader(query);

      while (dr.Read())
      {
        string _Name = (string)dr["coursename"];
        _Name = _Name.Trim().ToLower();

        List<string> nameList = new List<string>();
        nameList = _Name.Replace(",", "").Replace(":", "").Replace(".", "").Replace("'", "").Replace("(", " ").Replace(")", "").Split(' ').ToList();

        for (int i = 0; i < words.Count; i++)
        {
          for (int k = 0; k < nameList.Count; k++)
          {
            if (words[i].Equals(nameList[k]))
            {
              Course temp = new Course((int)dr[0], (string)dr[1], (int)dr[2], (string)dr[3], (string)dr[4]);
              res.Add(temp);
            }
          }
        }
      }

      con.Close(); return res;
    }

    internal List<KeyValuePair<string, Course>> getRequestedCourse(string _tid)
    {
      List<KeyValuePair<string, Course>> res = new List<KeyValuePair<string, Course>>();
      string query = "select StudentInfo.username, CourseInfo.courseid, CourseInfo.coursename, CourseInfo.totalstudent, CourseInfo.description, CourseInfo.ownerid, RequestInfo.requestid FROM StudentInfo, CourseInfo, RequestInfo WHERE StudentInfo.username = RequestInfo.studentid and CourseInfo.courseid = RequestInfo.courseid and RequestInfo.teacherid = '" + _tid + "'";
      SqlDataReader dr = getReader(query);

      while (dr.Read())
      {
        string _uName = (string)dr["username"];

        Course temp = new Course((int)dr[1], (string)dr[2], (int)dr[3], (string)dr[4], (string)dr[5]);
        //new MesBox(new LogInPage(),(string)dr[0]+dr[2],true).Show();
        res.Add(new KeyValuePair<string, Course>(_uName, temp));
      }

      con.Close(); return res;
    }

    public void addRequest(string _tid, string _sid, int _cid)
    {
      string query = "insert into RequestInfo(teacherid,studentid,courseid) values('" + _tid + "', '" + _sid + "', '" + _cid + "')";
      executeQuery(query);
    }

    public void cancelRequest(string _sid, int _cid)
    {
      string query = "delete from RequestInfo where studentid='" + _sid + "' and courseid='" + _cid + "'";
      executeQuery(query);
    }

    public bool chkRequest(string _sid, int _cid)
    {
      string query = "select * from RequestInfo where studentid='" + _sid + "' and courseid='" + _cid + "'";
      if (searchQuery(query) == 1) return true;
      return false;
    }


    public void addStudent(int _cid, string _sid)
    {
      string query = "insert into StudentCourseList(courseid,studentid) values('" + _cid + "', '" + _sid + "')";
      executeQuery(query);
    }

    internal void StudentGetCourse(Student _aStudent)
    {
      string query = "select CourseInfo.courseid, CourseInfo.coursename, CourseInfo.totalstudent, CourseInfo.description, CourseInfo.ownerid FROM CourseInfo, StudentCourseList WHERE CourseInfo.courseid=StudentCourseList.courseid and StudentCourseList.studentid='" + _aStudent.userName + "'";

      SqlCommand cmd = new SqlCommand(query, con);
      con.Open();
      SqlDataReader dr = cmd.ExecuteReader();

      _aStudent.courseList.Clear();
      _aStudent.courseList = new List<Course>();
      while (dr.Read())
      {
        Course temp = new Course((int)dr[0], (string)dr[1], (int)dr[2], (string)dr[3], (string)dr[4]);
        _aStudent.courseList.Add(temp);
      }

      con.Close();
    }

    internal bool chkCourse(string _sid, int _cid)
    {
      string query = "select * from StudentCourseList where studentid='" + _sid + "' and courseid='" + _cid + "'";
      if (searchQuery(query) == 1) return true;
      return false;
    }

    internal void studentGetMails(Student _ast)
    {
      string query = "select TeacherInfo.fullname, Mails.mailid, Mails.message, Mails.date from TeacherInfo, Mails  WHERE TeacherInfo.username = Mails.fromp and Mails.topr='" + _ast.userName + "'";
      SqlDataReader dr = getReader(query);

      //new MesBox(new LogInPage(), "CHK", true).Show();

      _ast.mails = new List<Mails>();
      while (dr.Read())
      {
        Mails temp = new Mails((int)dr[1], (string)dr[0], (string)dr[2], (DateTime)dr[3]);
        _ast.mails.Add(temp);
      }

      con.Close();
    }

    internal void teacherGetMails(Teacher _atc)
    {
      string query = "select Mails.mailid, StudentInfo.fullname, Mails.message, Mails.date FROM StudentInfo, Mails  WHERE StudentInfo.username = Mails.fromp and Mails.topr='" + _atc.userName + "'";
      SqlDataReader dr = getReader(query);

      _atc.mails = new List<Mails>();
      while (dr.Read())
      {
        Mails temp = new Mails((int)dr[0], (string)dr[1], (string)dr[2], (DateTime)dr[3]);
        _atc.mails.Add(temp);
      }

      con.Close();
    }
    internal Mails loadMailStudent(int id)
    {
      string query = "select Mails.mailid, TeacherInfo.fullname, Mails.message, Mails.date FROM TeacherInfo, Mails  WHERE TeacherInfo.username = Mails.fromp and Mails.mailid='" + id + "'";
      SqlDataReader dr = getReader(query); dr.Read();

      Mails aMail = new Mails((int)dr[0], (string)dr[1], (string)dr[2], (DateTime)dr[3]);
      con.Close();

      return aMail;
    }
    internal Mails loadMailTeacher(int id)
    {
      string query = "select Mails.mailid, StudentInfo.fullname, Mails.message, Mails.date FROM StudentInfo, Mails  WHERE StudentInfo.username = Mails.fromp and Mails.mailid='" + id + "'";
      SqlDataReader dr = getReader(query); dr.Read();

      Mails aMail = new Mails((int)dr[0], (string)dr[1], (string)dr[2], (DateTime)dr[3]);
      con.Close();

      return aMail;
    }
    internal Mails loadMailReal(int id)
    {
      string query = "select Mails.mailid, Mails.fromp, Mails.message, Mails.date FROM Mails  WHERE Mails.mailid='" + id + "'";
      SqlDataReader dr = getReader(query); dr.Read();

      Mails aMail = new Mails((int)dr[0], (string)dr[1], (string)dr[2], (DateTime)dr[3]);
      con.Close();

      return aMail;
    }

    public void addMail(string from, string to, string msg)
    {
      string query = "insert into Mails(fromp, topr, message, date) values('" + from + "', '" + to + "', '" + msg + "', '" + DateTime.Today + "')";
      executeQuery(query);
    }
    public void deleteMail(int id)
    {
      string query = "delete from Mails where mailid = '"+id+"'";
      executeQuery(query);
    }

    internal void getStudentList(Course _acrs)
    {
      string query = "select s.username, s.fullname, s.email, s.gender, s.dob from StudentInfo s, StudentCourseList l where s.username = l.studentid and l.courseid = '"+_acrs.ID+"'";
      SqlDataReader dr = getReader(query);

      _acrs.studentList = new List<Student>();
      while (dr.Read())
      {
        Student temp = new Student((string)dr[0], (string)dr[1], (string)dr[2], (DateTime)dr[4], (bool)dr[3]);
        _acrs.studentList.Add(temp);
      }

      con.Close();
    }

    public void updateTeacher(string fName, string email, bool gender, DateTime dob, string inst, string dpt)
    {
      string query = "update TeacherInfo set fullname='" + fName + "', email='" + email + "', gender='" + gender + "', dob='" + dob + "', inst='" + inst + "', dept='" + dpt + "' where username='"+Session.tc.userName+"'";
      executeQuery(query);
    }

    public void updateStudent(string fName, string email, bool gender, DateTime dob)
    {
      string query = "update StudentInfo set fullname='" + fName + "', email='" + email + "', gender='" + gender + "', dob='" + dob + "' where username='" + Session.st.userName + "'";
      executeQuery(query);
    }
  }
}
