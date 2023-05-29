namespace Rubiks
{
  internal static class Program
  {

    [STAThread]
    static void Main()
    {
      ApplicationConfiguration.Initialize();

      Rubiks f1p = new Rubiks();
      Application.Run(f1p);
    }
  }
}