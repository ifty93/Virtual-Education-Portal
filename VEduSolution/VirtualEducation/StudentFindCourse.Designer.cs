namespace VirtualEducation
{
  partial class StudentFindCourse
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFindCourse));
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.button7 = new System.Windows.Forms.Button();
      this.courseNameL = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
      this.label1.Location = new System.Drawing.Point(63, 146);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "Find By";
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Course Name",
            "Teacher Name"});
      this.comboBox1.Location = new System.Drawing.Point(154, 142);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(174, 33);
      this.comboBox1.TabIndex = 20;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
      this.label3.Location = new System.Drawing.Point(376, 145);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(118, 25);
      this.label3.TabIndex = 21;
      this.label3.Text = "Search For";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(500, 142);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(257, 31);
      this.textBox1.TabIndex = 22;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.LightGreen;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(791, 142);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(103, 33);
      this.button1.TabIndex = 23;
      this.button1.Text = "Search";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel2
      // 
      this.panel2.AutoScroll = true;
      this.panel2.AutoScrollMargin = new System.Drawing.Size(0, 25);
      this.panel2.Location = new System.Drawing.Point(98, 200);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(769, 364);
      this.panel2.TabIndex = 24;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkGray;
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.button7);
      this.panel1.Controls.Add(this.courseNameL);
      this.panel1.Location = new System.Drawing.Point(0, 47);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(970, 53);
      this.panel1.TabIndex = 25;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(838, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 25);
      this.label2.TabIndex = 15;
      this.label2.Text = "Home";
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
      this.courseNameL.Size = new System.Drawing.Size(155, 29);
      this.courseNameL.TabIndex = 6;
      this.courseNameL.Text = "Find Course";
      // 
      // StudentFindCourse
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label1);
      this.Name = "StudentFindCourse";
      this.Text = "StudentFindCourse";
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.comboBox1, 0);
      this.Controls.SetChildIndex(this.label3, 0);
      this.Controls.SetChildIndex(this.textBox1, 0);
      this.Controls.SetChildIndex(this.button1, 0);
      this.Controls.SetChildIndex(this.panel2, 0);
      this.Controls.SetChildIndex(this.panel1, 0);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Label courseNameL;
  }
}