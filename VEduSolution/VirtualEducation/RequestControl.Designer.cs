namespace VirtualEducation
{
  partial class RequestControl
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
      this.rejectBt = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.addBt = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // rejectBt
      // 
      this.rejectBt.BackColor = System.Drawing.Color.Coral;
      this.rejectBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.rejectBt.ForeColor = System.Drawing.Color.Black;
      this.rejectBt.Location = new System.Drawing.Point(582, 25);
      this.rejectBt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.rejectBt.Name = "rejectBt";
      this.rejectBt.Size = new System.Drawing.Size(100, 60);
      this.rejectBt.TabIndex = 5;
      this.rejectBt.Text = "Reject";
      this.rejectBt.UseVisualStyleBackColor = false;
      this.rejectBt.Click += new System.EventHandler(this.rejectBt_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(32, 60);
      this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(152, 25);
      this.label2.TabIndex = 4;
      this.label2.Text = "Total Student: ";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 25);
      this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(314, 25);
      this.label1.TabIndex = 3;
      this.label1.Text = "Object Oriented Programming-1";
      // 
      // addBt
      // 
      this.addBt.BackColor = System.Drawing.Color.LightGreen;
      this.addBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addBt.ForeColor = System.Drawing.Color.Black;
      this.addBt.Location = new System.Drawing.Point(478, 25);
      this.addBt.Margin = new System.Windows.Forms.Padding(6);
      this.addBt.Name = "addBt";
      this.addBt.Size = new System.Drawing.Size(100, 60);
      this.addBt.TabIndex = 6;
      this.addBt.Text = "Add";
      this.addBt.UseVisualStyleBackColor = false;
      this.addBt.Click += new System.EventHandler(this.addBt_Click);
      // 
      // RequestControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSkyBlue;
      this.Controls.Add(this.addBt);
      this.Controls.Add(this.rejectBt);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "RequestControl";
      this.Size = new System.Drawing.Size(700, 110);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button rejectBt;
    public System.Windows.Forms.Label label2;
    public System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button addBt;
  }
}
