namespace Rubiks
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      buttonTopLeft = new Button();
      labelTopLeft = new Label();
      SuspendLayout();
      // 
      // buttonTopLeft
      // 
      buttonTopLeft.Location = new Point(37, 27);
      buttonTopLeft.Name = "buttonTopLeft";
      buttonTopLeft.Size = new Size(75, 23);
      buttonTopLeft.TabIndex = 0;
      buttonTopLeft.Text = "click over here";
      buttonTopLeft.UseVisualStyleBackColor = true;
      buttonTopLeft.Click += buttonTopLeft_Click;
      // 
      // labelTopLeft
      // 
      labelTopLeft.AutoSize = true;
      labelTopLeft.Location = new Point(31, 62);
      labelTopLeft.Name = "labelTopLeft";
      labelTopLeft.Size = new Size(44, 15);
      labelTopLeft.TabIndex = 1;
      labelTopLeft.Text = "default";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(labelTopLeft);
      Controls.Add(buttonTopLeft);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button buttonTopLeft;
    private Label labelTopLeft;
  }
}