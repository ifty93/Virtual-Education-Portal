namespace VirtualEducation
{
  partial class TeacherMailPage
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMailPage));
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.button7 = new System.Windows.Forms.Button();
      this.courseNameL = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.AutoScroll = true;
      this.panel2.AutoScrollMargin = new System.Drawing.Size(0, 25);
      this.panel2.Location = new System.Drawing.Point(101, 127);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(769, 424);
      this.panel2.TabIndex = 29;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkGray;
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.button7);
      this.panel1.Controls.Add(this.courseNameL);
      this.panel1.Location = new System.Drawing.Point(0, 39);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(970, 53);
      this.panel1.TabIndex = 28;
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
      // TeacherMailPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "TeacherMailPage";
      this.Text = "TeacherMailPage";
      this.Controls.SetChildIndex(this.panel1, 0);
      this.Controls.SetChildIndex(this.panel2, 0);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Label courseNameL;
  }
}