namespace Rubiks
{
  public partial class Form1 : Form
  {
    private int borderSize = 5;
    private int squareSize = 50;

    private int stbSize()
    {
      return borderSize + squareSize;
    }

    private CubePuzzleRef cubep;
    

    public void SetCubePuzzleRef(CubePuzzleRef input){ 
      cubep = input;
    }



    public Form1()
    {
      InitializeComponent();
    }

    private void buttonTopLeft_Click(object sender, EventArgs e)
    {
      labelTopLeft.Text = "My button has been pressed";
    }

    public void reInit()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;


      SolidBrush blueBrush = new SolidBrush(Color.Blue);
      SolidBrush greenBrush = new SolidBrush(Color.Green);
      SolidBrush redBrush = new SolidBrush(Color.Red);
      SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
      SolidBrush orangeBrush = new SolidBrush(Color.Orange);
      SolidBrush whiteBrush = new SolidBrush(Color.White);
      Rectangle rect = new Rectangle(0, 0, 0, 0);

      // draw T diagram of cube puzzle
      for (int x = 1; x <= 12; x++)
      {
        for (int y = 1; y <= 9; y++)
        {
          if (((y >= 4) && (y <= 6)) || ((x >= 4) && (x <= 6)))
          {
            rect = new Rectangle(x * stbSize(), y * stbSize(), squareSize, squareSize);
            int ccox = 0, ccoy = 0;
            if (y < 4){ 
              ccox = 0;
            } else if (y > 6){ 
              ccox = 1;
            } else { 
              ccox = Convert.ToInt32(Math.Floor((float)(x + 5) / 3));
            }
            ccoy = (((((x - 1) % 3) + (3 * ((y - 1) % 3)) + 4) % 9) + 4) % 8;
            int thisFace;
            if ((((x - 1) % 3) == 1) && (((y - 1) % 3) == 1)) { 
                thisFace = ccox;      
            } else { 
                thisFace = cubep.GetCubeFace(ccox, ccoy);
                        }
            switch (thisFace){ 
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
  }
}