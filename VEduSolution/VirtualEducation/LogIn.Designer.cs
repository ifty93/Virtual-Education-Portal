namespace VirtualEducation
{
  partial class LogInPage
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
      this.nameL = new System.Windows.Forms.Label();
      this.nameTB = new System.Windows.Forms.TextBox();
      this.passTB = new System.Windows.Forms.TextBox();
      this.passL = new System.Windows.Forms.Label();
      this.logBT = new System.Windows.Forms.Button();
      this.regBT = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.unameTX = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.passTX = new System.Windows.Forms.TextBox();
      this.loginBT = new System.Windows.Forms.Button();
      this.registerBT = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // nameL
      // 
      this.nameL.AutoSize = true;
      this.nameL.ForeColor = System.Drawing.SystemColors.Highlight;
      this.nameL.Location = new System.Drawing.Point(315, 206);
      this.nameL.Name = "nameL";
      this.nameL.Size = new System.Drawing.Size(113, 25);
      this.nameL.TabIndex = 6;
      this.nameL.Text = "UserName";
      // 
      // nameTB
      // 
      this.nameTB.Location = new System.Drawing.Point(456, 203);
      this.nameTB.Name = "nameTB";
      this.nameTB.Size = new System.Drawing.Size(196, 31);
      this.nameTB.TabIndex = 7;
      // 
      // passTB
      // 
      this.passTB.Location = new System.Drawing.Point(456, 264);
      this.passTB.Name = "passTB";
      this.passTB.Size = new System.Drawing.Size(196, 31);
      this.passTB.TabIndex = 9;
      // 
      // passL
      // 
      this.passL.AutoSize = true;
      this.passL.ForeColor = System.Drawing.SystemColors.Highlight;
      this.passL.Location = new System.Drawing.Point(315, 267);
      this.passL.Name = "passL";
      this.passL.Size = new System.Drawing.Size(106, 25);
      this.passL.TabIndex = 8;
      this.passL.Text = "Password";
      // 
      // logBT
      // 
      this.logBT.Location = new System.Drawing.Point(361, 344);
      this.logBT.Name = "logBT";
      this.logBT.Size = new System.Drawing.Size(109, 36);
      this.logBT.TabIndex = 10;
      this.logBT.Text = "Log-In";
      this.logBT.UseVisualStyleBackColor = true;
      // 
      // regBT
      // 
      this.regBT.Location = new System.Drawing.Point(502, 344);
      this.regBT.Name = "regBT";
      this.regBT.Size = new System.Drawing.Size(109, 36);
      this.regBT.TabIndex = 11;
      this.regBT.Text = "Sign-Up";
      this.regBT.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
      this.label1.Location = new System.Drawing.Point(315, 206);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "Username";
      // 
      // unameTX
      // 
      this.unameTX.Location = new System.Drawing.Point(456, 203);
      this.unameTX.Name = "unameTX";
      this.unameTX.Size = new System.Drawing.Size(196, 31);
      this.unameTX.TabIndex = 8;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
      this.label2.Location = new System.Drawing.Point(315, 267);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(106, 25);
      this.label2.TabIndex = 8;
      this.label2.Text = "Password";
      // 
      // passTX
      // 
      this.passTX.Location = new System.Drawing.Point(456, 264);
      this.passTX.Name = "passTX";
      this.passTX.PasswordChar = '•';
      this.passTX.Size = new System.Drawing.Size(196, 31);
      this.passTX.TabIndex = 9;
      // 
      // loginBT
      // 
      this.loginBT.Location = new System.Drawing.Point(361, 344);
      this.loginBT.Name = "loginBT";
      this.loginBT.Size = new System.Drawing.Size(109, 36);
      this.loginBT.TabIndex = 10;
      this.loginBT.Text = "Log-In";
      this.loginBT.UseVisualStyleBackColor = true;
      this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
      // 
      // registerBT
      // 
      this.registerBT.Location = new System.Drawing.Point(502, 344);
      this.registerBT.Name = "registerBT";
      this.registerBT.Size = new System.Drawing.Size(109, 36);
      this.registerBT.TabIndex = 11;
      this.registerBT.Text = "Register";
      this.registerBT.UseVisualStyleBackColor = true;
      this.registerBT.Click += new System.EventHandler(this.registerBT_Click);
      // 
      // LogInPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.registerBT);
      this.Controls.Add(this.regBT);
      this.Controls.Add(this.loginBT);
      this.Controls.Add(this.logBT);
      this.Controls.Add(this.passTX);
      this.Controls.Add(this.passTB);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.passL);
      this.Controls.Add(this.unameTX);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nameTB);
      this.Controls.Add(this.nameL);
      this.Margin = new System.Windows.Forms.Padding(12);
      this.Name = "LogInPage";
      this.Text = "Log-In";
      this.Controls.SetChildIndex(this.nameL, 0);
      this.Controls.SetChildIndex(this.nameTB, 0);
      this.Controls.SetChildIndex(this.label1, 0);
      this.Controls.SetChildIndex(this.unameTX, 0);
      this.Controls.SetChildIndex(this.passL, 0);
      this.Controls.SetChildIndex(this.label2, 0);
      this.Controls.SetChildIndex(this.passTB, 0);
      this.Controls.SetChildIndex(this.passTX, 0);
      this.Controls.SetChildIndex(this.logBT, 0);
      this.Controls.SetChildIndex(this.loginBT, 0);
      this.Controls.SetChildIndex(this.regBT, 0);
      this.Controls.SetChildIndex(this.registerBT, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label nameL;
    private System.Windows.Forms.TextBox nameTB;
    private System.Windows.Forms.TextBox passTB;
    private System.Windows.Forms.Label passL;
    private System.Windows.Forms.Button logBT;
    private System.Windows.Forms.Button regBT;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox unameTX;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox passTX;
    private System.Windows.Forms.Button loginBT;
    private System.Windows.Forms.Button registerBT;
  }
}

