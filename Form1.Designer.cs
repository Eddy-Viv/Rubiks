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
            SquareSizeUp = new Button();
            SquareSizeDown = new Button();
            SquareSizeText = new Label();
            SuspendLayout();
            // 
            // SquareSizeUp
            // 
            SquareSizeUp.Location = new Point(741, 21);
            SquareSizeUp.Name = "SquareSizeUp";
            SquareSizeUp.Size = new Size(75, 23);
            SquareSizeUp.TabIndex = 0;
            SquareSizeUp.Text = "Larger";
            SquareSizeUp.UseVisualStyleBackColor = true;
            SquareSizeUp.Click += SquareSizeUp_Click;
            SquareSizeUp.Paint += Form1_Paint;
            // 
            // SquareSizeDown
            // 
            SquareSizeDown.Location = new Point(767, 138);
            SquareSizeDown.Name = "SquareSizeDown";
            SquareSizeDown.Size = new Size(75, 23);
            SquareSizeDown.TabIndex = 1;
            SquareSizeDown.Text = "Smaller";
            SquareSizeDown.UseVisualStyleBackColor = true;
            SquareSizeDown.Click += SquareSizeDown_Click;
            // 
            // SquareSizeText
            // 
            SquareSizeText.AutoSize = true;
            SquareSizeText.Location = new Point(751, 96);
            SquareSizeText.Name = "SquareSizeText";
            SquareSizeText.Size = new Size(66, 15);
            SquareSizeText.TabIndex = 2;
            SquareSizeText.Text = "Square Size";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1350, 747);
            Controls.Add(SquareSizeText);
            Controls.Add(SquareSizeDown);
            Controls.Add(SquareSizeUp);
            Name = "Form1";
            Text = "Rubiks";
            Load += Rubiks_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SquareSizeUp;
        private Button SquareSizeDown;
        private Label SquareSizeText;
    }
}