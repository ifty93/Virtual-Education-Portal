namespace VirtualEducation
{
  partial class StudentHomePage
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentHomePage));
      this.welcomL = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.logOutBt = new System.Windows.Forms.Button();
      this.findCourseBt = new System.Windows.Forms.Button();
      this.myCourseBt = new System.Windows.Forms.Button();
      this.updateProfileBt = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.avgL = new System.Windows.Forms.Label();
      this.courseNoL = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.mailBt = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
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
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkGray;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.logOutBt);
      this.panel1.Controls.Add(this.welcomL);
      this.panel1.Location = new System.Drawing.Point(1, 51);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(970, 53);
      this.panel1.TabIndex = 18;
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
      // findCourseBt
      // 
      this.findCourseBt.BackColor = System.Drawing.Color.SkyBlue;
      this.findCourseBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findCourseBt.BackgroundImage")));
      this.findCourseBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.findCourseBt.FlatAppearance.BorderSize = 0;
      this.findCourseBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.findCourseBt.Location = new System.Drawing.Point(265, 230);
      this.findCourseBt.Name = "findCourseBt";
      this.findCourseBt.Size = new System.Drawing.Size(187, 109);
      this.findCourseBt.TabIndex = 15;
      this.findCourseBt.Text = "Find Courses";
      this.findCourseBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.findCourseBt.UseVisualStyleBackColor = false;
      this.findCourseBt.Click += new System.EventHandler(this.findCourseBt_Click);
      // 
      // myCourseBt
      // 
      this.myCourseBt.BackColor = System.Drawing.Color.DarkOrange;
      this.myCourseBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myCourseBt.BackgroundImage")));
      this.myCourseBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.myCourseBt.FlatAppearance.BorderSize = 0;
      this.myCourseBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.myCourseBt.Location = new System.Drawing.Point(61, 230);
      this.myCourseBt.Name = "myCourseBt";
      this.myCourseBt.Size = new System.Drawing.Size(187, 109);
      this.myCourseBt.TabIndex = 14;
      this.myCourseBt.Text = "My Courses";
      this.myCourseBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.myCourseBt.UseVisualStyleBackColor = false;
      this.myCourseBt.Click += new System.EventHandler(this.myCourseBt_Click);
      // 
      // updateProfileBt
      // 
      this.updateProfileBt.BackColor = System.Drawing.Color.MediumTurquoise;
      this.updateProfileBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateProfileBt.BackgroundImage")));
      this.updateProfileBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.updateProfileBt.FlatAppearance.BorderSize = 0;
      this.updateProfileBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.updateProfileBt.Location = new System.Drawing.Point(265, 362);
      this.updateProfileBt.Name = "updateProfileBt";
      this.updateProfileBt.Size = new System.Drawing.Size(187, 148);
      this.updateProfileBt.TabIndex = 19;
      this.updateProfileBt.Text = "Update Profile";
      this.updateProfileBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.updateProfileBt.UseVisualStyleBackColor = false;
      this.updateProfileBt.Click += new System.EventHandler(this.updateProfileBt_Click);
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.White;
      this.panel2.Controls.Add(this.avgL);
      this.panel2.Controls.Add(this.courseNoL);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.panel3);
      this.panel2.Location = new System.Drawing.Point(548, 230);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(359, 279);
      this.panel2.TabIndex = 20;
      // 
      // avgL
      // 
      this.avgL.AutoSize = true;
      this.avgL.ForeColor = System.Drawing.Color.OrangeRed;
      this.avgL.Location = new System.Drawing.Point(215, 168);
      this.avgL.Name = "avgL";
      this.avgL.Size = new System.Drawing.Size(85, 25);
      this.avgL.TabIndex = 5;
      this.avgL.Text = " 87.3 %";
      // 
      // courseNoL
      // 
      this.courseNoL.AutoSize = true;
      this.courseNoL.ForeColor = System.Drawing.Color.OrangeRed;
      this.courseNoL.Location = new System.Drawing.Point(221, 132);
      this.courseNoL.Name = "courseNoL";
      this.courseNoL.Size = new System.Drawing.Size(42, 25);
      this.courseNoL.TabIndex = 4;
      this.courseNoL.Text = " 13";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(29, 168);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(197, 25);
      this.label4.TabIndex = 3;
      this.label4.Text = "Average Grades :";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(29, 131);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(200, 25);
      this.label3.TabIndex = 2;
      this.label3.Text = "Total Courses     :";
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
      this.panel3.Controls.Add(this.label2);
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(359, 67);
      this.panel3.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
      this.label2.Location = new System.Drawing.Point(110, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(134, 36);
      this.label2.TabIndex = 0;
      this.label2.Text = "Statistics";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // mailBt
      // 
      this.mailBt.BackColor = System.Drawing.Color.LightGreen;
      this.mailBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mailBt.BackgroundImage")));
      this.mailBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.mailBt.FlatAppearance.BorderSize = 0;
      this.mailBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.mailBt.Location = new System.Drawing.Point(61, 361);
      this.mailBt.Name = "mailBt";
      this.mailBt.Size = new System.Drawing.Size(187, 148);
      this.mailBt.TabIndex = 21;
      this.mailBt.Text = "View Mails";
      this.mailBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.mailBt.UseVisualStyleBackColor = false;
      this.mailBt.Click += new System.EventHandler(this.mailBt_Click);
      // 
      // StudentHomePage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.mailBt);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.findCourseBt);
      this.Controls.Add(this.myCourseBt);
      this.Controls.Add(this.updateProfileBt);
      this.Name = "StudentHomePage";
      this.Text = "StudentHomePage";
      this.Controls.SetChildIndex(this.updateProfileBt, 0);
      this.Controls.SetChildIndex(this.myCourseBt, 0);
      this.Controls.SetChildIndex(this.findCourseBt, 0);
      this.Controls.SetChildIndex(this.panel1, 0);
      this.Controls.SetChildIndex(this.panel2, 0);
      this.Controls.SetChildIndex(this.mailBt, 0);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label welcomL;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button logOutBt;
    private System.Windows.Forms.Button findCourseBt;
    private System.Windows.Forms.Button myCourseBt;
    private System.Windows.Forms.Button updateProfileBt;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label courseNoL;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label avgL;
    private System.Windows.Forms.Button mailBt;
  }
}