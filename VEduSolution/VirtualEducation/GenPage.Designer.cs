namespace VirtualEducation
{
  partial class GenPage
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
      this.minzButt = new System.Windows.Forms.Button();
      this.exitButt = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // minzButt
      // 
      this.minzButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.minzButt.Location = new System.Drawing.Point(892, 12);
      this.minzButt.Name = "minzButt";
      this.minzButt.Size = new System.Drawing.Size(30, 23);
      this.minzButt.TabIndex = 5;
      this.minzButt.Text = "_";
      this.minzButt.UseVisualStyleBackColor = true;
      this.minzButt.Click += new System.EventHandler(this.minzButt_Click);
      // 
      // exitButt
      // 
      this.exitButt.BackColor = System.Drawing.Color.Red;
      this.exitButt.FlatAppearance.BorderColor = System.Drawing.Color.Red;
      this.exitButt.FlatAppearance.BorderSize = 0;
      this.exitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.exitButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.exitButt.Location = new System.Drawing.Point(928, 12);
      this.exitButt.Name = "exitButt";
      this.exitButt.Size = new System.Drawing.Size(30, 23);
      this.exitButt.TabIndex = 4;
      this.exitButt.Text = "X";
      this.exitButt.UseVisualStyleBackColor = false;
      this.exitButt.Click += new System.EventHandler(this.exitButt_Click);
      // 
      // GenPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 590);
      this.Controls.Add(this.minzButt);
      this.Controls.Add(this.exitButt);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "GenPage";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "GenPagecs";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button exitButt;
    private System.Windows.Forms.Button minzButt;
  }
}