using System.Windows.Forms;
using System;

namespace Rubiks
{

    

    internal static class Program
    {

        //required for windows forms
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            CubePuzzle cube = new CubePuzzle();

            Form1 f1p = new Form1();
            f1p.SetLocCube(cube);
            Application.Run(f1p);
        }
    }
}