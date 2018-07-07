namespace VirtualEducation
{
  partial class TeacherAddCourseForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.welcomL = new System.Windows.Forms.Label();
      this.mxstudentBx = new System.Windows.Forms.TextBox();
      this.nameBx = new System.Windows.Forms.TextBox();
      this.unameL = new System.Windows.Forms.Label();
      this.mailL = new System.Windows.Forms.Label();
      this.nameL = new System.Windows.Forms.Label();
      this.descTexBx = new System.Windows.Forms.RichTextBox();
      this.cancelBt = new System.Windows.Forms.Button();
      this.createtBT = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkGray;
      this.panel1.Controls.Add(this.welcomL);
      this.panel1.Location = new System.Drawing.Point(1, 41);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(970, 53);
      this.panel1.TabIndex = 40;
      // 
      // welcomL
      // 
      this.welcomL.AutoSize = true;
      this.welcomL.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.welcomL.ForeColor = System.Drawing.SystemColors.Desktop;
      this.welcomL.Location = new System.Drawing.Point(251, 12);
      this.welcomL.Name = "welcomL";
      this.welcomL.Size = new System.Drawing.Size(211, 29);
      this.welcomL.TabIndex = 6;
      this.welcomL.Text = "Add New Course";
      // 
      // mxstudentBx
      // 
      this.mxstudentBx.Location = new System.Drawing.Point(435, 219);
      this.mxstudentBx.Name = "mxstudentBx";
      this.mxstudentBx.Size = new System.Drawing.Size(297, 31);
      this.mxstudentBx.TabIndex = 38;
      // 
      // nameBx
      // 
      this.nameBx.Location = new System.Drawing.Point(435, 170);
      this.nameBx.Name = "nameBx";
      this.nameBx.Size = new System.Drawing.Size(297, 31);
      this.nameBx.TabIndex = 37;
      // 
      // unameL
      // 
      this.unameL.AutoSize = true;
      this.unameL.Location = new System.Drawing.Point(252, 293);
      this.unameL.Name = "unameL";
      this.unameL.Size = new System.Drawing.Size(177, 25);
      this.unameL.TabIndex = 36;
      this.unameL.Text = "Short Description";
      // 
      // mailL
      // 
      this.mailL.AutoSize = true;
      this.mailL.Location = new System.Drawing.Point(252, 222);
      this.mailL.Name = "mailL";
      this.mailL.Size = new System.Drawing.Size(133, 25);
      this.mailL.TabIndex = 35;
      this.mailL.Text = "Max Student";
      // 
      // nameL
      // 
      this.nameL.AutoSize = true;
      this.nameL.Location = new System.Drawing.Point(252, 173);
      this.nameL.Name = "nameL";
      this.nameL.Size = new System.Drawing.Size(143, 25);
      this.nameL.TabIndex = 34;
      this.nameL.Text = "Course Name";
      // 
      // descTexBx
      // 
      this.descTexBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.descTexBx.Location = new System.Drawing.Point(435, 290);
      this.descTexBx.Name = "descTexBx";
      this.descTexBx.Size = new System.Drawing.Size(297, 96);
      this.descTexBx.TabIndex = 41;
      this.descTexBx.Text = "";
      // 
      // cancelBt
      // 
      this.cancelBt.BackColor = System.Drawing.Color.Coral;
      this.cancelBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelBt.Location = new System.Drawing.Point(532, 467);
      this.cancelBt.Name = "cancelBt";
      this.cancelBt.Size = new System.Drawing.Size(200, 36);
      this.cancelBt.TabIndex = 43;
      this.cancelBt.Text = "Cancel";
      this.cancelBt.UseVisualStyleBackColor = false;
      this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
      // 
      // createtBT
      // 
      this.createtBT.BackColor = System.Drawing.Color.PaleGreen;
      this.createtBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createtBT.Location = new System.Drawing.Point(257, 467);
      this.createtBT.Name = "createtBT";
      this.createtBT.Size = new System.Drawing.Size(197, 36);
      this.createtBT.TabIndex = 42;
      this.createtBT.Text = "Create";
      this.createtBT.UseVisualStyleBackColor = false;
      this.createtBT.Click += new System.EventHandler(this.createtBT_Click);
      // 
      // AddCourseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.cancelBt);
      this.Controls.Add(this.createtBT);
      this.Controls.Add(this.descTexBx);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.mxstudentBx);
      this.Controls.Add(this.nameBx);
      this.Controls.Add(this.unameL);
      this.Controls.Add(this.mailL);
      this.Controls.Add(this.nameL);
      this.Name = "AddCourseForm";
      this.Text = "AddCourseForm";
      this.Controls.SetChildIndex(this.nameL, 0);
      this.Controls.SetChildIndex(this.mailL, 0);
      this.Controls.SetChildIndex(this.unameL, 0);
      this.Controls.SetChildIndex(this.nameBx, 0);
      this.Controls.SetChildIndex(this.mxstudentBx, 0);
      this.Controls.SetChildIndex(this.panel1, 0);
      this.Controls.SetChildIndex(this.descTexBx, 0);
      this.Controls.SetChildIndex(this.createtBT, 0);
      this.Controls.SetChildIndex(this.cancelBt, 0);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label welcomL;
    private System.Windows.Forms.TextBox mxstudentBx;
    private System.Windows.Forms.TextBox nameBx;
    private System.Windows.Forms.Label unameL;
    private System.Windows.Forms.Label mailL;
    private System.Windows.Forms.Label nameL;
    private System.Windows.Forms.RichTextBox descTexBx;
    private System.Windows.Forms.Button cancelBt;
    private System.Windows.Forms.Button createtBT;
  }
}