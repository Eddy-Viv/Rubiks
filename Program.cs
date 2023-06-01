namespace Rubiks
{

    //simulates puzzle cube
    public class CubePuzzle
    {

        //stores the colour value of each face
        private int[,] faces = new int[6, 8];

        //returns the face colour
        public int GetFaceColour(int x, int y = -1)
        {
            if ((x < 6) && (x >= 0) && (y < 8) && (y >= 0))
            {
                return faces[x, y];
            }
            else if (y == -1)
            {
                return x;
            }
            return -1;
        }

        /*
        T diagram face layout:
              [][][]
              []0B[]
              [][][]
        [][][][][][][][][][][][]
        []2R[][]3Y[][]4O[][]5W[]
        [][][][][][][][][][][][]
              [][][]
              []1G[]
              [][][]
        0,B = Blue
        1,G = Green
        2,R = Red
        3,Y = Yellow
        4,O = Orange
        5,W = White

        face coordinates diagram
        [0][1][2]
        [3][F][4]
        [5][6][7]


        */

        public CubePuzzle()
        {
            init();
        }

        //initial solved state of the cube
        public void init()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    faces[i, j] = i;
                }
            }
        }


        /*
        moves are of the form:
        X*
        where X is the face to be moved:
        B = Blue
        G = Green
        R = Red
        Y = Yellow
        O = Orange
        W = White

        and * is the type of movement:
        ] = 90 deg clockwise
        [ = 90 deg anticlockwise
        2 = 180 degrees
        */

        //takes a string of potentially many moves, delimited by commas.
        public void move(string input)
        {
            if (input == "")
            {
                return;
            }
            //check if input string is more than one move
            int onemove = -1;
            for (int i = 0; (onemove == -1) && (i < input.Length); i++)
            {
                if (input[i] == ',')
                {
                    onemove = i;
                }
            }
            string thismove;
            if (onemove == -1)
            {
                thismove = input;
            }
            else
            {
                thismove = input.Substring(0, onemove);
            }

            // implement move logic here

            if (onemove != -1)
            {
                move(input.Substring(onemove + 1));
            }

        }
    }

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