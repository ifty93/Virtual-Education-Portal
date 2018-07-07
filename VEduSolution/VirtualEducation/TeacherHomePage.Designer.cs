namespace VirtualEducation
{
  partial class TeacherHomePage
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherHomePage));
      this.welcomL = new System.Windows.Forms.Label();
      this.viewCourseBt = new System.Windows.Forms.Button();
      this.adCourseBt = new System.Windows.Forms.Button();
      this.viewStudentBt = new System.Windows.Forms.Button();
      this.noticeBt = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.logOutBt = new System.Windows.Forms.Button();
      this.updateProfileBt = new System.Windows.Forms.Button();
      this.viewReqBt = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // welcomL
      // 
      this.welcomL.AutoSize = true;
      this.welcomL.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.welcomL.ForeColor = System.Drawing.SystemColors.Desktop;
      this.welcomL.Location = new System.Drawing.Point(55, 13);
      this.welcomL.Name = "welcomL";
      this.welcomL.Size = new System.Drawing.Size(129, 29);
      this.welcomL.TabIndex = 6;
      this.welcomL.Text = "Welcome ";
      // 
      // viewCourseBt
      // 
      this.viewCourseBt.BackColor = System.Drawing.Color.Gold;
      this.viewCourseBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewCourseBt.BackgroundImage")));
      this.viewCourseBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.viewCourseBt.FlatAppearance.BorderSize = 0;
      this.viewCourseBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.viewCourseBt.Location = new System.Drawing.Point(61, 230);
      this.viewCourseBt.Name = "viewCourseBt";
      this.viewCourseBt.Size = new System.Drawing.Size(187, 109);
      this.viewCourseBt.TabIndex = 7;
      this.viewCourseBt.Text = "View Courses";
      this.viewCourseBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.viewCourseBt.UseVisualStyleBackColor = false;
      this.viewCourseBt.Click += new System.EventHandler(this.viewCourseBt_Click);
      // 
      // adCourseBt
      // 
      this.adCourseBt.BackColor = System.Drawing.Color.ForestGreen;
      this.adCourseBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adCourseBt.BackgroundImage")));
      this.adCourseBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.adCourseBt.FlatAppearance.BorderSize = 0;
      this.adCourseBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.adCourseBt.Location = new System.Drawing.Point(265, 230);
      this.adCourseBt.Name = "adCourseBt";
      this.adCourseBt.Size = new System.Drawing.Size(187, 109);
      this.adCourseBt.TabIndex = 8;
      this.adCourseBt.Text = "Add Courses";
      this.adCourseBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.adCourseBt.UseVisualStyleBackColor = false;
      this.adCourseBt.Click += new System.EventHandler(this.adCourseBt_Click);
      // 
      // viewStudentBt
      // 
      this.viewStudentBt.BackColor = System.Drawing.Color.MediumTurquoise;
      this.viewStudentBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewStudentBt.BackgroundImage")));
      this.viewStudentBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.viewStudentBt.FlatAppearance.BorderSize = 0;
      this.viewStudentBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.viewStudentBt.Location = new System.Drawing.Point(61, 365);
      this.viewStudentBt.Name = "viewStudentBt";
      this.viewStudentBt.Size = new System.Drawing.Size(187, 166);
      this.viewStudentBt.TabIndex = 9;
      this.viewStudentBt.Text = "View Notice";
      this.viewStudentBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.viewStudentBt.UseVisualStyleBackColor = false;
      this.viewStudentBt.Click += new System.EventHandler(this.viewStudentBt_Click);
      // 
      // noticeBt
      // 
      this.noticeBt.BackColor = System.Drawing.Color.DarkOrange;
      this.noticeBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("noticeBt.BackgroundImage")));
      this.noticeBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.noticeBt.FlatAppearance.BorderSize = 0;
      this.noticeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.noticeBt.Location = new System.Drawing.Point(265, 365);
      this.noticeBt.Name = "noticeBt";
      this.noticeBt.Size = new System.Drawing.Size(187, 166);
      this.noticeBt.TabIndex = 10;
      this.noticeBt.Text = "View Mails";
      this.noticeBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.noticeBt.UseVisualStyleBackColor = false;
      this.noticeBt.Click += new System.EventHandler(this.noticeBt_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkGray;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.logOutBt);
      this.panel1.Controls.Add(this.welcomL);
      this.panel1.Location = new System.Drawing.Point(1, 51);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(970, 53);
      this.panel1.TabIndex = 11;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(817, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 25);
      this.label1.TabIndex = 15;
      this.label1.Text = "Log-Out";
      // 
      // logOutBt
      // 
      this.logOutBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
      this.logOutBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOutBt.BackgroundImage")));
      this.logOutBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.logOutBt.FlatAppearance.BorderSize = 0;
      this.logOutBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.logOutBt.Location = new System.Drawing.Point(912, 0);
      this.logOutBt.Name = "logOutBt";
      this.logOutBt.Size = new System.Drawing.Size(58, 53);
      this.logOutBt.TabIndex = 14;
      this.logOutBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.logOutBt.UseVisualStyleBackColor = false;
      this.logOutBt.Click += new System.EventHandler(this.logOutBt_Click);
      // 
      // updateProfileBt
      // 
      this.updateProfileBt.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.updateProfileBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateProfileBt.BackgroundImage")));
      this.updateProfileBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.updateProfileBt.FlatAppearance.BorderSize = 0;
      this.updateProfileBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.updateProfileBt.Location = new System.Drawing.Point(564, 365);
      this.updateProfileBt.Name = "updateProfileBt";
      this.updateProfileBt.Size = new System.Drawing.Size(343, 166);
      this.updateProfileBt.TabIndex = 12;
      this.updateProfileBt.Text = "Update Profile";
      this.updateProfileBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.updateProfileBt.UseVisualStyleBackColor = false;
      this.updateProfileBt.Click += new System.EventHandler(this.updateProfileBt_Click);
      // 
      // viewReqBt
      // 
      this.viewReqBt.BackColor = System.Drawing.Color.Tomato;
      this.viewReqBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewReqBt.BackgroundImage")));
      this.viewReqBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.viewReqBt.FlatAppearance.BorderSize = 0;
      this.viewReqBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.viewReqBt.Location = new System.Drawing.Point(564, 230);
      this.viewReqBt.Name = "viewReqBt";
      this.viewReqBt.Size = new System.Drawing.Size(343, 109);
      this.viewReqBt.TabIndex = 13;
      this.viewReqBt.Text = "View Requests";
      this.viewReqBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.viewReqBt.UseVisualStyleBackColor = false;
      this.viewReqBt.Click += new System.EventHandler(this.viewReqBt_Click);
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.Black;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.label2.Location = new System.Drawing.Point(836, 244);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 60);
      this.label2.TabIndex = 14;
      this.label2.Text = "13";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // TeacherHomePage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.viewReqBt);
      this.Controls.Add(this.updateProfileBt);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.noticeBt);
      this.Controls.Add(this.viewStudentBt);
      this.Controls.Add(this.adCourseBt);
      this.Controls.Add(this.viewCourseBt);
      this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
      this.Name = "TeacherHomePage";
      this.Text = "TeacherHomePage";
      this.Controls.SetChildIndex(this.viewCourseBt, 0);
      this.Controls.SetChildIndex(this.adCourseBt, 0);
      this.Controls.SetChildIndex(this.viewStudentBt, 0);
      this.Controls.SetChildIndex(this.noticeBt, 0);
      this.Controls.SetChildIndex(this.panel1, 0);
      this.Controls.SetChildIndex(this.updateProfileBt, 0);
      this.Controls.SetChildIndex(this.viewReqBt, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label welcomL;
    private System.Windows.Forms.Button viewCourseBt;
    private System.Windows.Forms.Button adCourseBt;
    private System.Windows.Forms.Button viewStudentBt;
    private System.Windows.Forms.Button noticeBt;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button logOutBt;
    private System.Windows.Forms.Button updateProfileBt;
    private System.Windows.Forms.Button viewReqBt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}