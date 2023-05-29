namespace Rubiks
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void buttonTopLeft_Click(object sender, EventArgs e)
    {
      labelTopLeft.Text = "My button has been pressed";
    }
  }
}