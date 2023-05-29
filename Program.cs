namespace Rubiks
{

  internal class CubePuzzle { 
    private int [,] faces = new int [6,8];
  
    public CubePuzzle(){ 
      init();
    }

    public void init(){ 
      for (int i = 0; i < 6; i++){ 
        for (int j = 0; j < 8; j++){ 
          faces [i, j] = i;
        }
      }
    }
  }

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