using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubiks
{
    //simulates puzzle cube
    internal class CubePuzzle
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
        public void Move(string input)
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

            for (int i = 0; i < thismove.Length; i += 2)
            {
                MoveFace(thismove.Substring(i, 2));
            }

            if (onemove != -1)
            {
                Move(input.Substring(onemove + 1));
            }

        }

        //performs the move logic
        //only accepts one move
        private void MoveFace(string inp)
        {
            Console.WriteLine(inp);
            if (inp == "")
            {
                return;
            }
            else
            {
                int facemoved = 0;
                switch (inp[0])
                {
                    case 'B':
                    case 'b':
                        facemoved = 0;
                        break;
                    case 'G':
                    case 'g':
                        facemoved = 1;
                        break;
                    case 'R':
                    case 'r':
                        facemoved = 2;
                        break;
                    case 'Y':
                    case 'y':
                        facemoved = 3;
                        break;
                    case 'O':
                    case 'o':
                        facemoved = 4;
                        break;
                    case 'W':
                    case 'w':
                        facemoved = 5;
                        break;
                    default:
                        return;
                }

                int t = -1;


                switch (inp[1])
                {
                    case ']':
                        t = faces[facemoved, 0];
                        faces[facemoved, 0] = faces[facemoved, 5];
                        faces[facemoved, 5] = faces[facemoved, 7];
                        faces[facemoved, 7] = faces[facemoved, 2];
                        faces[facemoved, 2] = t;
                        t = faces[facemoved, 1];
                        faces[facemoved, 1] = faces[facemoved, 3];
                        faces[facemoved, 3] = faces[facemoved, 6];
                        faces[facemoved, 6] = faces[facemoved, 4];
                        faces[facemoved, 4] = t;
                        switch (facemoved)
                        {
                            case 0:
                                t = faces[2, 0];
                                faces[2, 0] = faces[3, 0];
                                faces[3, 0] = faces[4, 0];
                                faces[4, 0] = faces[5, 0];
                                faces[5, 0] = t;
                                t = faces[2, 1];
                                faces[2, 1] = faces[3, 1];
                                faces[3, 1] = faces[4, 1];
                                faces[4, 1] = faces[5, 1];
                                faces[5, 1] = t;
                                t = faces[2, 2];
                                faces[2, 2] = faces[3, 2];
                                faces[3, 2] = faces[4, 2];
                                faces[4, 2] = faces[5, 2];
                                faces[5, 2] = t;
                                break;
                            case 1:
                                t = faces[2, 5];
                                faces[2, 5] = faces[5, 5];
                                faces[5, 5] = faces[4, 5];
                                faces[4, 5] = faces[3, 5];
                                faces[3, 5] = t;
                                t = faces[2, 6];
                                faces[2, 6] = faces[5, 6];
                                faces[5, 6] = faces[4, 6];
                                faces[4, 6] = faces[3, 6];
                                faces[3, 6] = t;
                                t = faces[2, 7];
                                faces[2, 7] = faces[5, 7];
                                faces[5, 7] = faces[4, 7];
                                faces[4, 7] = faces[3, 7];
                                faces[3, 7] = t;
                                break;
                            case 2:
                                t = faces[0, 0];
                                faces[0, 0] = faces[5, 7];
                                faces[5, 7] = faces[1, 0];
                                faces[1, 0] = faces[3, 0];
                                faces[3, 0] = t;
                                t = faces[0, 3];
                                faces[0, 3] = faces[5, 4];
                                faces[5, 4] = faces[1, 3];
                                faces[1, 3] = faces[3, 3];
                                faces[3, 3] = t;
                                t = faces[0, 5];
                                faces[0, 5] = faces[5, 2];
                                faces[5, 2] = faces[1, 5];
                                faces[1, 5] = faces[3, 5];
                                faces[3, 5] = t;
                                break;
                            case 3:
                                t = faces[0, 5];
                                faces[0, 5] = faces[2, 7];
                                faces[2, 7] = faces[1, 2];
                                faces[1, 2] = faces[4, 0];
                                faces[4, 0] = t;
                                t = faces[0, 6];
                                faces[0, 6] = faces[2, 4];
                                faces[2, 4] = faces[1, 1];
                                faces[1, 1] = faces[4, 3];
                                faces[4, 3] = t;
                                t = faces[0, 7];
                                faces[0, 7] = faces[2, 2];
                                faces[2, 2] = faces[1, 0];
                                faces[1, 0] = faces[4, 5];
                                faces[4, 5] = t;
                                break;
                            case 4:
                                t = faces[0, 7];
                                faces[0, 7] = faces[3, 7];
                                faces[3, 7] = faces[1, 7];
                                faces[1, 7] = faces[5, 0];
                                faces[5, 0] = t;
                                t = faces[0, 4];
                                faces[0, 4] = faces[3, 4];
                                faces[3, 4] = faces[1, 4];
                                faces[1, 4] = faces[5, 3];
                                faces[5, 3] = t;
                                t = faces[0, 2];
                                faces[0, 2] = faces[3, 2];
                                faces[3, 2] = faces[1, 2];
                                faces[1, 2] = faces[5, 5];
                                faces[5, 5] = t;
                                break;
                            case 5:
                                t = faces[4, 7];
                                faces[4, 7] = faces[1, 5];
                                faces[1, 5] = faces[2, 0];
                                faces[2, 0] = faces[0, 2];
                                faces[0, 2] = t;
                                t = faces[4, 4];
                                faces[4, 4] = faces[1, 6];
                                faces[1, 6] = faces[2, 3];
                                faces[2, 3] = faces[0, 1];
                                faces[0, 1] = t;
                                t = faces[4, 2];
                                faces[4, 2] = faces[1, 7];
                                faces[1, 7] = faces[2, 5];
                                faces[2, 5] = faces[0, 0];
                                faces[0, 0] = t;
                                break;
                        }
                        break;
                    case '[':
                        t = faces[facemoved, 0];
                        faces[facemoved, 0] = faces[facemoved, 2];
                        faces[facemoved, 2] = faces[facemoved, 7];
                        faces[facemoved, 7] = faces[facemoved, 5];
                        faces[facemoved, 5] = t;
                        t = faces[facemoved, 1];
                        faces[facemoved, 1] = faces[facemoved, 4];
                        faces[facemoved, 4] = faces[facemoved, 6];
                        faces[facemoved, 6] = faces[facemoved, 3];
                        faces[facemoved, 3] = t;
                        switch (facemoved)
                        {
                            case 0:
                                t = faces[2, 0];
                                faces[2, 0] = faces[5, 0];
                                faces[5, 0] = faces[4, 0];
                                faces[4, 0] = faces[3, 0];
                                faces[3, 0] = t;
                                t = faces[2, 1];
                                faces[2, 1] = faces[5, 1];
                                faces[5, 1] = faces[4, 1];
                                faces[4, 1] = faces[3, 1];
                                faces[3, 1] = t;
                                t = faces[2, 2];
                                faces[2, 2] = faces[5, 2];
                                faces[5, 2] = faces[4, 2];
                                faces[4, 2] = faces[3, 2];
                                faces[3, 2] = t;
                                break;
                            case 1:
                                t = faces[2, 5];
                                faces[2, 5] = faces[3, 5];
                                faces[3, 5] = faces[4, 5];
                                faces[4, 5] = faces[5, 5];
                                faces[5, 5] = t;
                                t = faces[2, 6];
                                faces[2, 6] = faces[3, 6];
                                faces[3, 6] = faces[4, 6];
                                faces[4, 6] = faces[5, 6];
                                faces[5, 6] = t;
                                t = faces[2, 7];
                                faces[2, 7] = faces[3, 7];
                                faces[3, 7] = faces[4, 7];
                                faces[4, 7] = faces[5, 7];
                                faces[5, 7] = t;
                                break;
                            case 2:
                                t = faces[0, 0];
                                faces[0, 0] = faces[3, 0];
                                faces[3, 0] = faces[1, 0];
                                faces[1, 0] = faces[5, 7];
                                faces[5, 7] = t;
                                t = faces[0, 3];
                                faces[0, 3] = faces[3, 3];
                                faces[3, 3] = faces[1, 3];
                                faces[1, 3] = faces[5, 4];
                                faces[5, 4] = t;
                                t = faces[0, 5];
                                faces[0, 5] = faces[3, 5];
                                faces[3, 5] = faces[1, 5];
                                faces[1, 5] = faces[5, 2];
                                faces[5, 2] = t;
                                break;
                            case 3:
                                t = faces[0, 5];
                                faces[0, 5] = faces[4, 0];
                                faces[4, 0] = faces[1, 2];
                                faces[1, 2] = faces[2, 7];
                                faces[2, 7] = t;
                                t = faces[0, 6];
                                faces[0, 6] = faces[4, 3];
                                faces[4, 3] = faces[1, 1];
                                faces[1, 1] = faces[2, 4];
                                faces[2, 4] = t;
                                t = faces[0, 7];
                                faces[0, 7] = faces[4, 5];
                                faces[4, 5] = faces[1, 0];
                                faces[1, 0] = faces[2, 2];
                                faces[2, 2] = t;
                                break;
                            case 4:
                                t = faces[0, 7];
                                faces[0, 7] = faces[5, 0];
                                faces[5, 0] = faces[1, 7];
                                faces[1, 7] = faces[3, 7];
                                faces[3, 7] = t;
                                t = faces[0, 4];
                                faces[0, 4] = faces[5, 3];
                                faces[5, 3] = faces[1, 4];
                                faces[1, 4] = faces[3, 4];
                                faces[3, 4] = t;
                                t = faces[0, 2];
                                faces[0, 2] = faces[5, 5];
                                faces[5, 5] = faces[1, 2];
                                faces[1, 2] = faces[3, 2];
                                faces[3, 2] = t;
                                break;
                            case 5:
                                t = faces[4, 7];
                                faces[4, 7] = faces[0, 2];
                                faces[0, 2] = faces[2, 0];
                                faces[2, 0] = faces[1, 5];
                                faces[1, 5] = t;
                                t = faces[4, 4];
                                faces[4, 4] = faces[0, 1];
                                faces[0, 1] = faces[2, 3];
                                faces[2, 3] = faces[1, 6];
                                faces[1, 6] = t;
                                t = faces[4, 2];
                                faces[4, 2] = faces[0, 0];
                                faces[0, 0] = faces[2, 5];
                                faces[2, 5] = faces[1, 7];
                                faces[1, 7] = t;
                                break;
                        }
                        break;
                    case '2':
                        string mv = "";
                        mv += inp[0];
                        mv += "]";
                        MoveFace(mv);
                        MoveFace(mv);
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
