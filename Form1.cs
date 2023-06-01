namespace Rubiks
{
    public partial class Form1 : Form
    {
        // defining the size of the cube squares and borders in pixels
        private int borderSize = 5;
        private int squareSize = 50;

        //size of the square plus size of the border
        private int stbSize = 55;

        //local copy of the state of the cube puzzle, not master copy.
        private CubePuzzle locCube;

        //sets the state of the local copy of the cube puzzle
        public void SetLocCube(CubePuzzle inp)
        {
            locCube = inp;
            Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
            locCube = new CubePuzzle();
        }

        public void reInit()
        {
            InitializeComponent();
        }

        //called when the paint event is raised, recalculates the graphics on the form
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            //calculate the positions of the buttons
            SquareSizeText.Location = new System.Drawing.Point(14 * stbSize, stbSize);
            SquareSizeUp.Location = new System.Drawing.Point(14 * stbSize, 2 * stbSize);
            SquareSizeDown.Location = new System.Drawing.Point(14 * stbSize, 3 * stbSize);
            MoveChainLabel.Location = new System.Drawing.Point(stbSize, 11 * stbSize);
            MoveInputBox.Location = new System.Drawing.Point(stbSize, 12 * stbSize);
            MoveInputButton.Location = new System.Drawing.Point(3 * stbSize, 12 * stbSize);

            //initialise the graphics object
            Graphics g = e.Graphics;

            //initialise the objects necesary for painting squares of different colours
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Rectangle rect = new Rectangle(0, 0, 0, 0);

            // draw T diagram of cube puzzle anchored from top left of form window
            for (int x = 1; x <= 12; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    if (((y >= 4) && (y <= 6)) || ((x >= 4) && (x <= 6)))
                    {
                        //position on the form to paint the current square
                        rect = new Rectangle(x * stbSize, y * stbSize, squareSize, squareSize);

                        //ccox = current face being painted
                        //ccoy = current position on the face being painted
                        int ccox = 0, ccoy = 0;

                        //blue face
                        if (y < 4)
                        {
                            ccox = 0;
                        }
                        //green face
                        else if (y > 6)
                        {
                            ccox = 1;
                        }
                        //red-white faces
                        else
                        {
                            ccox = Convert.ToInt32(Math.Floor((float)(x + 5) / 3));
                        }

                        //determines the position on the face from the coordinates
                        ccoy = (((((x - 1) % 3) + (3 * ((y - 1) % 3)) + 4) % 9) + 4) % 8;

                        //determines the colour of the face
                        int thisFace;

                        //middle face is always the same colour
                        if ((((x - 1) % 3) == 1) && (((y - 1) % 3) == 1))
                        {
                            thisFace = ccox;
                        }
                        else
                        {
                            thisFace = locCube.GetFaceColour(ccox, ccoy);
                        }

                        //paint the face
                        switch (thisFace)
                        {
                            case 0:
                                e.Graphics.FillRectangle(blueBrush, rect);
                                break;
                            case 1:
                                e.Graphics.FillRectangle(greenBrush, rect);
                                break;
                            case 2:
                                e.Graphics.FillRectangle(redBrush, rect);
                                break;
                            case 3:
                                e.Graphics.FillRectangle(yellowBrush, rect);
                                break;
                            case 4:
                                e.Graphics.FillRectangle(orangeBrush, rect);
                                break;
                            case 5:
                                e.Graphics.FillRectangle(whiteBrush, rect);
                                break;
                        }
                    }
                }
            }

        }

        private void Rubiks_Load(object sender, EventArgs e)
        {

        }

        //increases the size of the squares
        private void SquareSizeUp_Click(object sender, EventArgs e)
        {
            squareSize += 10;
            stbSize += 10;

            //refresh the form
            Invalidate();
        }

        //decreases the size of the squares
        private void SquareSizeDown_Click(object sender, EventArgs e)
        {
            squareSize -= 10;
            if (squareSize < 10)
            {
                squareSize = 10;
            }
            stbSize = squareSize + borderSize;

            //refresh the form
            Invalidate();
        }

        private void MoveInputButton_Click(object sender, EventArgs e)
        {
            string moves = MoveInputBox.Text;
            MoveInputBox.Text = "";
            locCube.Move(moves);
            Invalidate();
        }
    }
}