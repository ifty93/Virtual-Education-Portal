using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualEducation
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      DataBase DB = new DataBase();
      //DB.executeQuery("insert into UserAuth values('ift','123','0')");

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //new DataBase().chkUser("ift_khan");
      //new DataBase().findCourseByTeacherName("A");
      Application.Run(new LogInPage());
      //Application.Run(new GenPage());
      //Application.Run(new RegPage());
      //Application.Run(new Container());
      //Application.Run(new StudentFindCourse());
    }
  }
}
