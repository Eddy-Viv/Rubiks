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
            BlueClockwise = new Button();
            BlueAnti = new Button();
            BlueHalf = new Button();
            GreenClockwise = new Button();
            GreenAnti = new Button();
            GreenHalf = new Button();
            RedClockwise = new Button();
            RedAnti = new Button();
            RedHalf = new Button();
            YellowClockwise = new Button();
            YellowAnti = new Button();
            YellowHalf = new Button();
            OrangeClockwise = new Button();
            OrangeAnti = new Button();
            OrangeHalf = new Button();
            WhiteClockwise = new Button();
            WhiteAnti = new Button();
            WhiteHalf = new Button();
            MoveButtonLabel = new Label();
            ClockwiseLabel = new Label();
            AnticlockwiseLabel = new Label();
            HalfTurnLabel = new Label();
            ShuffleMoves = new NumericUpDown();
            ShuffleButton = new Button();
            Train = new Button();
            BatchSize = new NumericUpDown();
            NoMoves = new NumericUpDown();
            BatchSizeLabel = new Label();
            NoMovesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ShuffleMoves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BatchSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NoMoves).BeginInit();
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
            // BlueClockwise
            // 
            BlueClockwise.Location = new Point(416, 462);
            BlueClockwise.Name = "BlueClockwise";
            BlueClockwise.Size = new Size(75, 23);
            BlueClockwise.TabIndex = 6;
            BlueClockwise.Text = "B]";
            BlueClockwise.UseVisualStyleBackColor = true;
            BlueClockwise.Click += BlueClockwise_Click;
            // 
            // BlueAnti
            // 
            BlueAnti.Location = new Point(425, 497);
            BlueAnti.Name = "BlueAnti";
            BlueAnti.Size = new Size(75, 23);
            BlueAnti.TabIndex = 7;
            BlueAnti.Text = "B[";
            BlueAnti.UseVisualStyleBackColor = true;
            BlueAnti.Click += BlueAnti_Click;
            // 
            // BlueHalf
            // 
            BlueHalf.Location = new Point(417, 560);
            BlueHalf.Name = "BlueHalf";
            BlueHalf.Size = new Size(75, 23);
            BlueHalf.TabIndex = 8;
            BlueHalf.Text = "B2";
            BlueHalf.UseVisualStyleBackColor = true;
            BlueHalf.Click += BlueHalf_Click;
            // 
            // GreenClockwise
            // 
            GreenClockwise.Location = new Point(514, 467);
            GreenClockwise.Name = "GreenClockwise";
            GreenClockwise.Size = new Size(75, 23);
            GreenClockwise.TabIndex = 9;
            GreenClockwise.Text = "G]";
            GreenClockwise.UseVisualStyleBackColor = true;
            GreenClockwise.Click += GreenClockwise_Click;
            // 
            // GreenAnti
            // 
            GreenAnti.Location = new Point(529, 499);
            GreenAnti.Name = "GreenAnti";
            GreenAnti.Size = new Size(75, 23);
            GreenAnti.TabIndex = 10;
            GreenAnti.Text = "G[";
            GreenAnti.UseVisualStyleBackColor = true;
            GreenAnti.Click += GreenAnti_Click;
            // 
            // GreenHalf
            // 
            GreenHalf.Location = new Point(529, 563);
            GreenHalf.Name = "GreenHalf";
            GreenHalf.Size = new Size(75, 23);
            GreenHalf.TabIndex = 11;
            GreenHalf.Text = "G2";
            GreenHalf.UseVisualStyleBackColor = true;
            GreenHalf.Click += GreenHalf_Click;
            // 
            // RedClockwise
            // 
            RedClockwise.Location = new Point(626, 473);
            RedClockwise.Name = "RedClockwise";
            RedClockwise.Size = new Size(75, 23);
            RedClockwise.TabIndex = 12;
            RedClockwise.Text = "R]";
            RedClockwise.UseVisualStyleBackColor = true;
            RedClockwise.Click += RedClockwise_Click;
            // 
            // RedAnti
            // 
            RedAnti.Location = new Point(638, 507);
            RedAnti.Name = "RedAnti";
            RedAnti.Size = new Size(75, 23);
            RedAnti.TabIndex = 13;
            RedAnti.Text = "R[";
            RedAnti.UseVisualStyleBackColor = true;
            RedAnti.Click += RedAnti_Click;
            // 
            // RedHalf
            // 
            RedHalf.Location = new Point(647, 575);
            RedHalf.Name = "RedHalf";
            RedHalf.Size = new Size(75, 23);
            RedHalf.TabIndex = 14;
            RedHalf.Text = "R2";
            RedHalf.UseVisualStyleBackColor = true;
            RedHalf.Click += RedHalf_Click;
            // 
            // YellowClockwise
            // 
            YellowClockwise.Location = new Point(724, 467);
            YellowClockwise.Name = "YellowClockwise";
            YellowClockwise.Size = new Size(75, 23);
            YellowClockwise.TabIndex = 15;
            YellowClockwise.Text = "Y]";
            YellowClockwise.UseVisualStyleBackColor = true;
            YellowClockwise.Click += YellowClockwise_Click;
            // 
            // YellowAnti
            // 
            YellowAnti.Location = new Point(733, 503);
            YellowAnti.Name = "YellowAnti";
            YellowAnti.Size = new Size(75, 23);
            YellowAnti.TabIndex = 16;
            YellowAnti.Text = "Y[";
            YellowAnti.UseVisualStyleBackColor = true;
            YellowAnti.Click += YellowAnti_Click;
            // 
            // YellowHalf
            // 
            YellowHalf.Location = new Point(744, 571);
            YellowHalf.Name = "YellowHalf";
            YellowHalf.Size = new Size(75, 23);
            YellowHalf.TabIndex = 17;
            YellowHalf.Text = "Y2";
            YellowHalf.UseVisualStyleBackColor = true;
            YellowHalf.Click += YellowHalf_Click;
            // 
            // OrangeClockwise
            // 
            OrangeClockwise.Location = new Point(823, 469);
            OrangeClockwise.Name = "OrangeClockwise";
            OrangeClockwise.Size = new Size(75, 23);
            OrangeClockwise.TabIndex = 18;
            OrangeClockwise.Text = "O]";
            OrangeClockwise.UseVisualStyleBackColor = true;
            OrangeClockwise.Click += OrangeClockwise_Click;
            // 
            // OrangeAnti
            // 
            OrangeAnti.Location = new Point(811, 497);
            OrangeAnti.Name = "OrangeAnti";
            OrangeAnti.Size = new Size(75, 23);
            OrangeAnti.TabIndex = 19;
            OrangeAnti.Text = "O[";
            OrangeAnti.UseVisualStyleBackColor = true;
            OrangeAnti.Click += OrangeAnti_Click;
            // 
            // OrangeHalf
            // 
            OrangeHalf.Location = new Point(838, 559);
            OrangeHalf.Name = "OrangeHalf";
            OrangeHalf.Size = new Size(75, 23);
            OrangeHalf.TabIndex = 20;
            OrangeHalf.Text = "O2";
            OrangeHalf.UseVisualStyleBackColor = true;
            OrangeHalf.Click += OrangeHalf_Click;
            // 
            // WhiteClockwise
            // 
            WhiteClockwise.Location = new Point(926, 467);
            WhiteClockwise.Name = "WhiteClockwise";
            WhiteClockwise.Size = new Size(75, 23);
            WhiteClockwise.TabIndex = 21;
            WhiteClockwise.Text = "W]";
            WhiteClockwise.UseVisualStyleBackColor = true;
            WhiteClockwise.Click += WhiteClockwise_Click;
            // 
            // WhiteAnti
            // 
            WhiteAnti.Location = new Point(924, 497);
            WhiteAnti.Name = "WhiteAnti";
            WhiteAnti.Size = new Size(75, 23);
            WhiteAnti.TabIndex = 22;
            WhiteAnti.Text = "W[";
            WhiteAnti.UseVisualStyleBackColor = true;
            WhiteAnti.Click += WhiteAnti_Click;
            // 
            // WhiteHalf
            // 
            WhiteHalf.Location = new Point(925, 556);
            WhiteHalf.Name = "WhiteHalf";
            WhiteHalf.Size = new Size(75, 23);
            WhiteHalf.TabIndex = 23;
            WhiteHalf.Text = "W2";
            WhiteHalf.UseVisualStyleBackColor = true;
            WhiteHalf.Click += WhiteHalf_Click;
            // 
            // MoveButtonLabel
            // 
            MoveButtonLabel.AutoSize = true;
            MoveButtonLabel.Location = new Point(581, 416);
            MoveButtonLabel.Name = "MoveButtonLabel";
            MoveButtonLabel.Size = new Size(42, 15);
            MoveButtonLabel.TabIndex = 24;
            MoveButtonLabel.Text = "Moves";
            // 
            // ClockwiseLabel
            // 
            ClockwiseLabel.AutoSize = true;
            ClockwiseLabel.Location = new Point(350, 462);
            ClockwiseLabel.Name = "ClockwiseLabel";
            ClockwiseLabel.Size = new Size(60, 15);
            ClockwiseLabel.TabIndex = 25;
            ClockwiseLabel.Text = "Clockwise";
            // 
            // AnticlockwiseLabel
            // 
            AnticlockwiseLabel.AutoSize = true;
            AnticlockwiseLabel.Location = new Point(330, 505);
            AnticlockwiseLabel.Name = "AnticlockwiseLabel";
            AnticlockwiseLabel.Size = new Size(80, 15);
            AnticlockwiseLabel.TabIndex = 26;
            AnticlockwiseLabel.Text = "Anticlockwise";
            // 
            // HalfTurnLabel
            // 
            HalfTurnLabel.AutoSize = true;
            HalfTurnLabel.Location = new Point(350, 559);
            HalfTurnLabel.Name = "HalfTurnLabel";
            HalfTurnLabel.Size = new Size(56, 15);
            HalfTurnLabel.TabIndex = 27;
            HalfTurnLabel.Text = "Half Turn";
            // 
            // ShuffleMoves
            // 
            ShuffleMoves.Location = new Point(220, 531);
            ShuffleMoves.Name = "ShuffleMoves";
            ShuffleMoves.Size = new Size(75, 23);
            ShuffleMoves.TabIndex = 28;
            ShuffleMoves.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // ShuffleButton
            // 
            ShuffleButton.Location = new Point(249, 482);
            ShuffleButton.Name = "ShuffleButton";
            ShuffleButton.Size = new Size(75, 23);
            ShuffleButton.TabIndex = 29;
            ShuffleButton.Text = "Shuffle";
            ShuffleButton.UseVisualStyleBackColor = true;
            ShuffleButton.Click += ShuffleButton_Click;
            // 
            // Train
            // 
            Train.Location = new Point(943, 154);
            Train.Name = "Train";
            Train.Size = new Size(75, 23);
            Train.TabIndex = 30;
            Train.Text = "Train";
            Train.UseVisualStyleBackColor = true;
            Train.Click += Train_Click;
            // 
            // BatchSize
            // 
            BatchSize.Location = new Point(961, 21);
            BatchSize.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            BatchSize.Name = "BatchSize";
            BatchSize.Size = new Size(75, 23);
            BatchSize.TabIndex = 31;
            BatchSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // NoMoves
            // 
            NoMoves.Location = new Point(950, 97);
            NoMoves.Name = "NoMoves";
            NoMoves.Size = new Size(75, 23);
            NoMoves.TabIndex = 32;
            NoMoves.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BatchSizeLabel
            // 
            BatchSizeLabel.AutoSize = true;
            BatchSizeLabel.Location = new Point(891, 24);
            BatchSizeLabel.Name = "BatchSizeLabel";
            BatchSizeLabel.Size = new Size(60, 15);
            BatchSizeLabel.TabIndex = 33;
            BatchSizeLabel.Text = "Batch Size";
            // 
            // NoMovesLabel
            // 
            NoMovesLabel.AutoSize = true;
            NoMovesLabel.Location = new Point(886, 83);
            NoMovesLabel.MaximumSize = new Size(80, 0);
            NoMovesLabel.Name = "NoMovesLabel";
            NoMovesLabel.Size = new Size(68, 30);
            NoMovesLabel.TabIndex = 34;
            NoMovesLabel.Text = "Number of moves";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1784, 961);
            Controls.Add(NoMovesLabel);
            Controls.Add(BatchSizeLabel);
            Controls.Add(NoMoves);
            Controls.Add(BatchSize);
            Controls.Add(Train);
            Controls.Add(ShuffleButton);
            Controls.Add(ShuffleMoves);
            Controls.Add(HalfTurnLabel);
            Controls.Add(AnticlockwiseLabel);
            Controls.Add(ClockwiseLabel);
            Controls.Add(MoveButtonLabel);
            Controls.Add(WhiteHalf);
            Controls.Add(WhiteAnti);
            Controls.Add(WhiteClockwise);
            Controls.Add(OrangeHalf);
            Controls.Add(OrangeAnti);
            Controls.Add(OrangeClockwise);
            Controls.Add(YellowHalf);
            Controls.Add(YellowAnti);
            Controls.Add(YellowClockwise);
            Controls.Add(RedHalf);
            Controls.Add(RedAnti);
            Controls.Add(RedClockwise);
            Controls.Add(GreenHalf);
            Controls.Add(GreenAnti);
            Controls.Add(GreenClockwise);
            Controls.Add(BlueHalf);
            Controls.Add(BlueAnti);
            Controls.Add(BlueClockwise);
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
            ((System.ComponentModel.ISupportInitialize)ShuffleMoves).EndInit();
            ((System.ComponentModel.ISupportInitialize)BatchSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)NoMoves).EndInit();
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
        private Button BlueClockwise;
        private Button BlueAnti;
        private Button BlueHalf;
        private Button GreenClockwise;
        private Button GreenAnti;
        private Button GreenHalf;
        private Button RedClockwise;
        private Button RedAnti;
        private Button RedHalf;
        private Button YellowClockwise;
        private Button YellowAnti;
        private Button YellowHalf;
        private Button OrangeClockwise;
        private Button OrangeAnti;
        private Button OrangeHalf;
        private Button WhiteClockwise;
        private Button WhiteAnti;
        private Button WhiteHalf;
        private Label MoveButtonLabel;
        private Label ClockwiseLabel;
        private Label AnticlockwiseLabel;
        private Label HalfTurnLabel;
        private NumericUpDown ShuffleMoves;
        private Button ShuffleButton;
        private Button Train;
        private NumericUpDown BatchSize;
        private NumericUpDown NoMoves;
        private Label BatchSizeLabel;
        private Label NoMovesLabel;
    }
}