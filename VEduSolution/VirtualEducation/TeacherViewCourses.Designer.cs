namespace VirtualEducation
{
  partial class TeacherViewCourses
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherViewCourses));
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.button7 = new System.Windows.Forms.Button();
      this.welcomL = new System.Windows.Forms.Label();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.AutoScroll = true;
      this.panel1.AutoScrollMargin = new System.Drawing.Size(0, 25);
      this.panel1.Location = new System.Drawing.Point(97, 141);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(769, 421);
      this.panel1.TabIndex = 6;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.DarkGray;
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.button7);
      this.panel2.Controls.Add(this.welcomL);
      this.panel2.Location = new System.Drawing.Point(1, 53);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(970, 53);
      this.panel2.TabIndex = 12;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(838, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(68, 25);
      this.label1.TabIndex = 15;
      this.label1.Text = "Home";
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
      // welcomL
      // 
      this.welcomL.AutoSize = true;
      this.welcomL.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.welcomL.ForeColor = System.Drawing.SystemColors.Desktop;
      this.welcomL.Location = new System.Drawing.Point(20, 12);
      this.welcomL.Name = "welcomL";
      this.welcomL.Size = new System.Drawing.Size(110, 29);
      this.welcomL.TabIndex = 6;
      this.welcomL.Text = "Courses";
      // 
      // Container
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(12);
      this.Name = "Container";
      this.Text = "pa";
      this.Controls.SetChildIndex(this.panel1, 0);
      this.Controls.SetChildIndex(this.panel2, 0);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Label welcomL;
  }
}