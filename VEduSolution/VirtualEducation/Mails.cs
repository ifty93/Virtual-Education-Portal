using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualEducation
{
  class Mails
  {
    public int id;
    public string from;
    public DateTime date;

    public string text;

    public Mails(int _id, string _f, string _t, DateTime _d)
    {
      this.id = _id;
      this.from = _f;
      this.date = _d;
      this.text = _t;
    }
  }
}
