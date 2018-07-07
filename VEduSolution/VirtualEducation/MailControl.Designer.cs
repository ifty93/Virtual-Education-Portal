namespace VirtualEducation
{
  partial class MailControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.addBt = new System.Windows.Forms.Button();
      this.rejectBt = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // addBt
      // 
      this.addBt.BackColor = System.Drawing.Color.LightGreen;
      this.addBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addBt.ForeColor = System.Drawing.Color.Black;
      this.addBt.Location = new System.Drawing.Point(471, 25);
      this.addBt.Margin = new System.Windows.Forms.Padding(6);
      this.addBt.Name = "addBt";
      this.addBt.Size = new System.Drawing.Size(100, 60);
      this.addBt.TabIndex = 10;
      this.addBt.Text = "View";
      this.addBt.UseVisualStyleBackColor = false;
      this.addBt.Click += new System.EventHandler(this.addBt_Click);
      // 
      // rejectBt
      // 
      this.rejectBt.BackColor = System.Drawing.Color.Coral;
      this.rejectBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.rejectBt.ForeColor = System.Drawing.Color.Black;
      this.rejectBt.Location = new System.Drawing.Point(575, 25);
      this.rejectBt.Margin = new System.Windows.Forms.Padding(6);
      this.rejectBt.Name = "rejectBt";
      this.rejectBt.Size = new System.Drawing.Size(100, 60);
      this.rejectBt.TabIndex = 9;
      this.rejectBt.Text = "Delete";
      this.rejectBt.UseVisualStyleBackColor = false;
      this.rejectBt.Click += new System.EventHandler(this.rejectBt_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(25, 60);
      this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 25);
      this.label2.TabIndex = 8;
      this.label2.Text = "Date: ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(25, 25);
      this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 25);
      this.label1.TabIndex = 7;
      this.label1.Text = "From: ";
      // 
      // MailControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSkyBlue;
      this.Controls.Add(this.addBt);
      this.Controls.Add(this.rejectBt);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "MailControl";
      this.Size = new System.Drawing.Size(700, 110);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button addBt;
    private System.Windows.Forms.Button rejectBt;
    public System.Windows.Forms.Label label2;
    public System.Windows.Forms.Label label1;
  }
}
