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
            MoveInputBox = new TextBox();
            MoveInputButton = new Button();
            MoveChainLabel = new Label();
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
            // MoveInputBox
            // 
            MoveInputBox.Location = new Point(34, 493);
            MoveInputBox.Name = "MoveInputBox";
            MoveInputBox.Size = new Size(100, 23);
            MoveInputBox.TabIndex = 3;
            // 
            // MoveInputButton
            // 
            MoveInputButton.Location = new Point(146, 502);
            MoveInputButton.Name = "MoveInputButton";
            MoveInputButton.Size = new Size(75, 23);
            MoveInputButton.TabIndex = 4;
            MoveInputButton.Text = "Enter";
            MoveInputButton.UseVisualStyleBackColor = true;
            MoveInputButton.Click += MoveInputButton_Click;
            // 
            // MoveChainLabel
            // 
            MoveChainLabel.AutoSize = true;
            MoveChainLabel.Location = new Point(43, 466);
            MoveChainLabel.Name = "MoveChainLabel";
            MoveChainLabel.Size = new Size(73, 15);
            MoveChainLabel.TabIndex = 5;
            MoveChainLabel.Text = "Input Moves";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1350, 747);
            Controls.Add(MoveChainLabel);
            Controls.Add(MoveInputButton);
            Controls.Add(MoveInputBox);
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
        private TextBox MoveInputBox;
        private Button MoveInputButton;
        private Label MoveChainLabel;
    }
}