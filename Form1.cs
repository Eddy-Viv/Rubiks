namespace Rubiks
{
  public partial class Rubiks : Form
  {
    private int borderSize = 5;
    private int squareSize = 50;

    private int stbSize()
    {
      return borderSize + squareSize;
    }



    public Rubiks()
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
      Rectangle rect = new Rectangle(stbSize(), 2 * stbSize(), squareSize, squareSize);

      // draw T diagram of cube puzzle
      for (int x = 1; x <= 12; x++)
      {
        for (int y = 1; y <= 9; y++)
        {
          if (((y >= 4) && (y <= 6)) || ((x >= 4) && (x <= 6)))
          {
            rect = new Rectangle(x * stbSize(), y * stbSize(), squareSize, squareSize);
            e.Graphics.FillRectangle(blueBrush, rect);
          }
        }
      }

    }
  }
}