namespace VirtualEducation
{
  partial class WriteMailPage
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteMailPage));
      this.panel2 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.button7 = new System.Windows.Forms.Button();
      this.welcomL = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.cancelBt = new System.Windows.Forms.Button();
      this.createtBT = new System.Windows.Forms.Button();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.DarkGray;
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.button7);
      this.panel2.Controls.Add(this.welcomL);
      this.panel2.Location = new System.Drawing.Point(0, 48);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(970, 53);
      this.panel2.TabIndex = 15;
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
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.OrangeRed;
      this.label2.Location = new System.Drawing.Point(318, 145);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 25);
      this.label2.TabIndex = 16;
      this.label2.Text = "To >>";
      // 
      // label3
      // 
      this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
      this.label3.Location = new System.Drawing.Point(379, 145);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(369, 25);
      this.label3.TabIndex = 17;
      this.label3.Text = "amail@";
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(181, 215);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(620, 221);
      this.richTextBox1.TabIndex = 18;
      this.richTextBox1.Text = "";
      // 
      // cancelBt
      // 
      this.cancelBt.BackColor = System.Drawing.Color.Coral;
      this.cancelBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelBt.Location = new System.Drawing.Point(539, 487);
      this.cancelBt.Name = "cancelBt";
      this.cancelBt.Size = new System.Drawing.Size(200, 36);
      this.cancelBt.TabIndex = 45;
      this.cancelBt.Text = "Cancel";
      this.cancelBt.UseVisualStyleBackColor = false;
      this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
      // 
      // createtBT
      // 
      this.createtBT.BackColor = System.Drawing.Color.PaleGreen;
      this.createtBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createtBT.Location = new System.Drawing.Point(264, 487);
      this.createtBT.Name = "createtBT";
      this.createtBT.Size = new System.Drawing.Size(197, 36);
      this.createtBT.TabIndex = 44;
      this.createtBT.Text = "Send";
      this.createtBT.UseVisualStyleBackColor = false;
      this.createtBT.Click += new System.EventHandler(this.createtBT_Click);
      // 
      // WriteMailPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.cancelBt);
      this.Controls.Add(this.createtBT);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel2);
      this.Name = "WriteMailPage";
      this.Text = "WriteMailPage";
      this.Controls.SetChildIndex(this.panel2, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.label3, 0);
      this.Controls.SetChildIndex(this.richTextBox1, 0);
      this.Controls.SetChildIndex(this.createtBT, 0);
      this.Controls.SetChildIndex(this.cancelBt, 0);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Label welcomL;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button cancelBt;
    private System.Windows.Forms.Button createtBT;

  }
}