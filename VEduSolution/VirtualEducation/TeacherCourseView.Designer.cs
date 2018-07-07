namespace VirtualEducation
{
  partial class TeacherCourseView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherCourseView));
      this.panel2 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.button7 = new System.Windows.Forms.Button();
      this.courseNameL = new System.Windows.Forms.Label();
      this.studentL = new System.Windows.Forms.Label();
      this.uploadBT = new System.Windows.Forms.Button();
      this.viewStudentBt = new System.Windows.Forms.Button();
      this.addNoticeBt = new System.Windows.Forms.Button();
      this.deleteCourseBt = new System.Windows.Forms.Button();
      this.setExamBt = new System.Windows.Forms.Button();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.DarkGray;
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.button7);
      this.panel2.Controls.Add(this.courseNameL);
      this.panel2.Location = new System.Drawing.Point(1, 52);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(970, 53);
      this.panel2.TabIndex = 13;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(838, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 25);
      this.label1.TabIndex = 15;
      this.label1.Text = "Home";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // button7
      // 
      this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
      this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
      this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button7.Location = new System.Drawing.Point(912, 0);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(58, 53);
      this.button7.TabIndex = 14;
      this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // courseNameL
      // 
      this.courseNameL.AutoSize = true;
      this.courseNameL.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.courseNameL.ForeColor = System.Drawing.SystemColors.Desktop;
      this.courseNameL.Location = new System.Drawing.Point(22, 12);
      this.courseNameL.Name = "courseNameL";
      this.courseNameL.Size = new System.Drawing.Size(174, 29);
      this.courseNameL.TabIndex = 6;
      this.courseNameL.Text = "Course Name";
      this.courseNameL.Click += new System.EventHandler(this.courseNameL_Click);
      // 
      // studentL
      // 
      this.studentL.AutoSize = true;
      this.studentL.ForeColor = System.Drawing.SystemColors.Highlight;
      this.studentL.Location = new System.Drawing.Point(376, 138);
      this.studentL.Name = "studentL";
      this.studentL.Size = new System.Drawing.Size(164, 25);
      this.studentL.TabIndex = 35;
      this.studentL.Text = " Total Student : ";
      // 
      // uploadBT
      // 
      this.uploadBT.BackColor = System.Drawing.Color.PaleGreen;
      this.uploadBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.uploadBT.Location = new System.Drawing.Point(253, 203);
      this.uploadBT.Name = "uploadBT";
      this.uploadBT.Size = new System.Drawing.Size(448, 36);
      this.uploadBT.TabIndex = 43;
      this.uploadBT.Text = "Upload Lectures";
      this.uploadBT.UseVisualStyleBackColor = false;
      this.uploadBT.Click += new System.EventHandler(this.uploadBT_Click);
      // 
      // viewStudentBt
      // 
      this.viewStudentBt.BackColor = System.Drawing.Color.PaleGreen;
      this.viewStudentBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.viewStudentBt.Location = new System.Drawing.Point(253, 267);
      this.viewStudentBt.Name = "viewStudentBt";
      this.viewStudentBt.Size = new System.Drawing.Size(448, 36);
      this.viewStudentBt.TabIndex = 44;
      this.viewStudentBt.Text = "View Students";
      this.viewStudentBt.UseVisualStyleBackColor = false;
      this.viewStudentBt.Click += new System.EventHandler(this.viewStudentBt_Click);
      // 
      // addNoticeBt
      // 
      this.addNoticeBt.BackColor = System.Drawing.Color.PaleGreen;
      this.addNoticeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addNoticeBt.Location = new System.Drawing.Point(253, 331);
      this.addNoticeBt.Name = "addNoticeBt";
      this.addNoticeBt.Size = new System.Drawing.Size(448, 36);
      this.addNoticeBt.TabIndex = 45;
      this.addNoticeBt.Text = "Add New Notice";
      this.addNoticeBt.UseVisualStyleBackColor = false;
      // 
      // deleteCourseBt
      // 
      this.deleteCourseBt.BackColor = System.Drawing.Color.Coral;
      this.deleteCourseBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.deleteCourseBt.Location = new System.Drawing.Point(372, 517);
      this.deleteCourseBt.Name = "deleteCourseBt";
      this.deleteCourseBt.Size = new System.Drawing.Size(200, 36);
      this.deleteCourseBt.TabIndex = 46;
      this.deleteCourseBt.Text = "Delete Course";
      this.deleteCourseBt.UseVisualStyleBackColor = false;
      // 
      // setExamBt
      // 
      this.setExamBt.BackColor = System.Drawing.Color.PaleGreen;
      this.setExamBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.setExamBt.Location = new System.Drawing.Point(253, 392);
      this.setExamBt.Name = "setExamBt";
      this.setExamBt.Size = new System.Drawing.Size(448, 36);
      this.setExamBt.TabIndex = 47;
      this.setExamBt.Text = "Set New Exam";
      this.setExamBt.UseVisualStyleBackColor = false;
      // 
      // TeacherCourseView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.setExamBt);
      this.Controls.Add(this.deleteCourseBt);
      this.Controls.Add(this.addNoticeBt);
      this.Controls.Add(this.viewStudentBt);
      this.Controls.Add(this.uploadBT);
      this.Controls.Add(this.studentL);
      this.Controls.Add(this.panel2);
      this.Name = "TeacherCourseView";
      this.Text = "TeacherCourseView";
      this.Controls.SetChildIndex(this.panel2, 0);
      this.Controls.SetChildIndex(this.studentL, 0);
      this.Controls.SetChildIndex(this.uploadBT, 0);
      this.Controls.SetChildIndex(this.viewStudentBt, 0);
      this.Controls.SetChildIndex(this.addNoticeBt, 0);
      this.Controls.SetChildIndex(this.deleteCourseBt, 0);
      this.Controls.SetChildIndex(this.setExamBt, 0);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Label courseNameL;
    private System.Windows.Forms.Label studentL;
    private System.Windows.Forms.Button uploadBT;
    private System.Windows.Forms.Button viewStudentBt;
    private System.Windows.Forms.Button addNoticeBt;
    private System.Windows.Forms.Button deleteCourseBt;
    private System.Windows.Forms.Button setExamBt;
  }
}