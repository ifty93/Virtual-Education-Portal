namespace VirtualEducation
{
  partial class TeacherProfileUpdateForm
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.welcomL = new System.Windows.Forms.Label();
      this.cancelBt = new System.Windows.Forms.Button();
      this.submtBT = new System.Windows.Forms.Button();
      this.dptBx = new System.Windows.Forms.TextBox();
      this.instBx = new System.Windows.Forms.TextBox();
      this.dptL = new System.Windows.Forms.Label();
      this.insL = new System.Windows.Forms.Label();
      this.fmle = new System.Windows.Forms.RadioButton();
      this.mle = new System.Windows.Forms.RadioButton();
      this.label6 = new System.Windows.Forms.Label();
      this.dateTime = new System.Windows.Forms.DateTimePicker();
      this.label5 = new System.Windows.Forms.Label();
      this.pass2Bx = new System.Windows.Forms.TextBox();
      this.pass1Bx = new System.Windows.Forms.TextBox();
      this.mailBx = new System.Windows.Forms.TextBox();
      this.nameBx = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.passL = new System.Windows.Forms.Label();
      this.mailL = new System.Windows.Forms.Label();
      this.nameL = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.DarkGray;
      this.panel1.Controls.Add(this.welcomL);
      this.panel1.Location = new System.Drawing.Point(0, 41);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(970, 53);
      this.panel1.TabIndex = 55;
      // 
      // welcomL
      // 
      this.welcomL.AutoSize = true;
      this.welcomL.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.welcomL.ForeColor = System.Drawing.SystemColors.Desktop;
      this.welcomL.Location = new System.Drawing.Point(251, 10);
      this.welcomL.Name = "welcomL";
      this.welcomL.Size = new System.Drawing.Size(179, 29);
      this.welcomL.TabIndex = 6;
      this.welcomL.Text = "Update Profile";
      // 
      // cancelBt
      // 
      this.cancelBt.BackColor = System.Drawing.Color.Coral;
      this.cancelBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelBt.Location = new System.Drawing.Point(511, 596);
      this.cancelBt.Name = "cancelBt";
      this.cancelBt.Size = new System.Drawing.Size(200, 36);
      this.cancelBt.TabIndex = 54;
      this.cancelBt.Text = "Cancel";
      this.cancelBt.UseVisualStyleBackColor = false;
      this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
      // 
      // submtBT
      // 
      this.submtBT.BackColor = System.Drawing.Color.PaleGreen;
      this.submtBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.submtBT.Location = new System.Drawing.Point(256, 596);
      this.submtBT.Name = "submtBT";
      this.submtBT.Size = new System.Drawing.Size(197, 36);
      this.submtBT.TabIndex = 53;
      this.submtBT.Text = "Update";
      this.submtBT.UseVisualStyleBackColor = false;
      this.submtBT.Click += new System.EventHandler(this.submtBT_Click);
      // 
      // dptBx
      // 
      this.dptBx.Location = new System.Drawing.Point(414, 517);
      this.dptBx.Name = "dptBx";
      this.dptBx.Size = new System.Drawing.Size(297, 31);
      this.dptBx.TabIndex = 52;
      // 
      // instBx
      // 
      this.instBx.Location = new System.Drawing.Point(414, 468);
      this.instBx.Name = "instBx";
      this.instBx.Size = new System.Drawing.Size(297, 31);
      this.instBx.TabIndex = 51;
      // 
      // dptL
      // 
      this.dptL.AutoSize = true;
      this.dptL.Location = new System.Drawing.Point(251, 520);
      this.dptL.Name = "dptL";
      this.dptL.Size = new System.Drawing.Size(123, 25);
      this.dptL.TabIndex = 50;
      this.dptL.Text = "Department";
      // 
      // insL
      // 
      this.insL.AutoSize = true;
      this.insL.Location = new System.Drawing.Point(251, 471);
      this.insL.Name = "insL";
      this.insL.Size = new System.Drawing.Size(104, 25);
      this.insL.TabIndex = 49;
      this.insL.Text = "Institution";
      // 
      // fmle
      // 
      this.fmle.AutoSize = true;
      this.fmle.FlatAppearance.BorderSize = 2;
      this.fmle.Location = new System.Drawing.Point(610, 394);
      this.fmle.Name = "fmle";
      this.fmle.Size = new System.Drawing.Size(101, 29);
      this.fmle.TabIndex = 48;
      this.fmle.TabStop = true;
      this.fmle.Text = "Female";
      this.fmle.UseVisualStyleBackColor = true;
      // 
      // mle
      // 
      this.mle.AutoSize = true;
      this.mle.Location = new System.Drawing.Point(414, 396);
      this.mle.Name = "mle";
      this.mle.Size = new System.Drawing.Size(77, 29);
      this.mle.TabIndex = 47;
      this.mle.TabStop = true;
      this.mle.Text = "Male";
      this.mle.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(251, 396);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(83, 25);
      this.label6.TabIndex = 46;
      this.label6.Text = "Gender";
      // 
      // dateTime
      // 
      this.dateTime.CustomFormat = "MMMM dd,  yyyy";
      this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTime.Location = new System.Drawing.Point(414, 348);
      this.dateTime.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
      this.dateTime.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
      this.dateTime.Name = "dateTime";
      this.dateTime.Size = new System.Drawing.Size(297, 31);
      this.dateTime.TabIndex = 45;
      this.dateTime.Value = new System.DateTime(2016, 12, 12, 18, 46, 14, 0);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(251, 353);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(131, 25);
      this.label5.TabIndex = 44;
      this.label5.Text = "Date of Birth";
      // 
      // pass2Bx
      // 
      this.pass2Bx.Location = new System.Drawing.Point(414, 265);
      this.pass2Bx.Name = "pass2Bx";
      this.pass2Bx.PasswordChar = '•';
      this.pass2Bx.Size = new System.Drawing.Size(297, 31);
      this.pass2Bx.TabIndex = 43;
      // 
      // pass1Bx
      // 
      this.pass1Bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pass1Bx.Location = new System.Drawing.Point(414, 216);
      this.pass1Bx.Name = "pass1Bx";
      this.pass1Bx.PasswordChar = '•';
      this.pass1Bx.Size = new System.Drawing.Size(297, 31);
      this.pass1Bx.TabIndex = 42;
      // 
      // mailBx
      // 
      this.mailBx.Location = new System.Drawing.Point(414, 163);
      this.mailBx.Name = "mailBx";
      this.mailBx.Size = new System.Drawing.Size(297, 31);
      this.mailBx.TabIndex = 40;
      // 
      // nameBx
      // 
      this.nameBx.Location = new System.Drawing.Point(414, 114);
      this.nameBx.Name = "nameBx";
      this.nameBx.Size = new System.Drawing.Size(297, 31);
      this.nameBx.TabIndex = 39;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(251, 268);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(140, 25);
      this.label4.TabIndex = 38;
      this.label4.Text = "Confirm Pass";
      // 
      // passL
      // 
      this.passL.AutoSize = true;
      this.passL.Location = new System.Drawing.Point(251, 219);
      this.passL.Name = "passL";
      this.passL.Size = new System.Drawing.Size(141, 25);
      this.passL.TabIndex = 37;
      this.passL.Text = "Change Pass";
      // 
      // mailL
      // 
      this.mailL.AutoSize = true;
      this.mailL.Location = new System.Drawing.Point(251, 166);
      this.mailL.Name = "mailL";
      this.mailL.Size = new System.Drawing.Size(72, 25);
      this.mailL.TabIndex = 35;
      this.mailL.Text = "E-mail";
      // 
      // nameL
      // 
      this.nameL.AutoSize = true;
      this.nameL.Location = new System.Drawing.Point(251, 117);
      this.nameL.Name = "nameL";
      this.nameL.Size = new System.Drawing.Size(109, 25);
      this.nameL.TabIndex = 34;
      this.nameL.Text = "Full Name";
      // 
      // TeacherProfileUpdateForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 661);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.cancelBt);
      this.Controls.Add(this.submtBT);
      this.Controls.Add(this.dptBx);
      this.Controls.Add(this.instBx);
      this.Controls.Add(this.dptL);
      this.Controls.Add(this.insL);
      this.Controls.Add(this.fmle);
      this.Controls.Add(this.mle);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.dateTime);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.pass2Bx);
      this.Controls.Add(this.pass1Bx);
      this.Controls.Add(this.mailBx);
      this.Controls.Add(this.nameBx);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.passL);
      this.Controls.Add(this.mailL);
      this.Controls.Add(this.nameL);
      this.Name = "TeacherProfileUpdateForm";
      this.Text = "TeacherProfileUpdateForm";
      this.Controls.SetChildIndex(this.nameL, 0);
      this.Controls.SetChildIndex(this.mailL, 0);
      this.Controls.SetChildIndex(this.passL, 0);
      this.Controls.SetChildIndex(this.label4, 0);
      this.Controls.SetChildIndex(this.nameBx, 0);
      this.Controls.SetChildIndex(this.mailBx, 0);
      this.Controls.SetChildIndex(this.pass1Bx, 0);
      this.Controls.SetChildIndex(this.pass2Bx, 0);
      this.Controls.SetChildIndex(this.label5, 0);
      this.Controls.SetChildIndex(this.dateTime, 0);
      this.Controls.SetChildIndex(this.label6, 0);
      this.Controls.SetChildIndex(this.mle, 0);
      this.Controls.SetChildIndex(this.fmle, 0);
      this.Controls.SetChildIndex(this.insL, 0);
      this.Controls.SetChildIndex(this.dptL, 0);
      this.Controls.SetChildIndex(this.instBx, 0);
      this.Controls.SetChildIndex(this.dptBx, 0);
      this.Controls.SetChildIndex(this.submtBT, 0);
      this.Controls.SetChildIndex(this.cancelBt, 0);
      this.Controls.SetChildIndex(this.panel1, 0);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label welcomL;
    private System.Windows.Forms.Button cancelBt;
    private System.Windows.Forms.Button submtBT;
    private System.Windows.Forms.TextBox dptBx;
    private System.Windows.Forms.TextBox instBx;
    private System.Windows.Forms.Label dptL;
    private System.Windows.Forms.Label insL;
    private System.Windows.Forms.RadioButton fmle;
    private System.Windows.Forms.RadioButton mle;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DateTimePicker dateTime;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox pass2Bx;
    private System.Windows.Forms.TextBox pass1Bx;
    private System.Windows.Forms.TextBox mailBx;
    private System.Windows.Forms.TextBox nameBx;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label passL;
    private System.Windows.Forms.Label mailL;
    private System.Windows.Forms.Label nameL;
  }
}