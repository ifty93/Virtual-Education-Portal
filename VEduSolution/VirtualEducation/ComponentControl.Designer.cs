namespace VirtualEducation
{
  partial class ComponentControl
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(314, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Object Oriented Programming-1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(36, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(152, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "Total Student: ";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Gainsboro;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.ForeColor = System.Drawing.Color.Black;
      this.button1.Location = new System.Drawing.Point(500, 25);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(165, 60);
      this.button1.TabIndex = 2;
      this.button1.Text = "VIEW";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // ComponentControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightSkyBlue;
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "ComponentControl";
      this.Size = new System.Drawing.Size(700, 110);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.Label label1;
    public System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
  }
}
