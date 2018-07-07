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
  public partial class GenPage : Form
  {
    public GenPage()
    {
      InitializeComponent();
    }
    private void exitButt_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void minzButt_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }
  }
}
