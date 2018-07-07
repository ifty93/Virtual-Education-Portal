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
  public partial class MesBox : Form
  {
    private Form _owner;
    public MesBox(Form owner, string msg, bool st)
    {
      _owner = owner;
      InitializeComponent();
      this.ClientSize = new System.Drawing.Size(owner.ClientSize.Width, 145);
      int X = this.ClientSize.Width - 125;
      int Y = this.Location.Y + 105;
      this.button1.Location = new System.Drawing.Point(X, Y);
      
      this.label2.Text = msg;
      if (st) this.label1.Text = "Success";
      else this.label1.Text = "Error";
      if (st) this.BackColor = System.Drawing.Color.DeepSkyBlue;
      else this.BackColor = System.Drawing.Color.OrangeRed;
      
      this.Owner = owner;
      owner.Enabled = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      _owner.Enabled = true;
      this.Hide(); 
    }
  }
}
