using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubiks
{
    internal class PNFeeder
    {

        internal double[] ConvertCubeFaces(CubePuzzle inp) { 
            double[] t = new double [289];
            for (int i = 0; i < 288; i++)
            {
                t[i] = 0;
            }
            t[288] = 1;
            for (int i = 0; i < 48; i++)
            {
                t[(i * 6) + inp.GetFaceColour(i / 8, i % 8)] = 1;
            }
            return t;
        }

        internal bool[] ConvertMoveSetToLabel(string inp) {
            bool[] moves = new bool[18];
            for (int i = 0; i < 18; i++)
            {
                moves[i] = false;
            }
            int facemoved = 0, movement = -1;
            bool invalid = false;

            for (int i = inp.Length - 2; (i >= 0) && !invalid; i -= 2) {
                switch (inp[i]) {
                    case 'B':
                    case 'b':
                        facemoved = 0;
                        break;
                    case 'G':
                    case 'g':
                        facemoved = 3;
                        break;
                    case 'R':
                    case 'r':
                        facemoved = 6;
                        break;
                    case 'Y':
                    case 'y':
                        facemoved = 9;
                        break;
                    case 'O':
                    case 'o':
                        facemoved = 12;
                        break;
                    case 'W':
                    case 'w':
                        facemoved = 15;
                        break;
                    default:
                        Application.Exit();
                        break;
                }

                if (movement != -1) { 
                    switch (movement - facemoved) { 
                        case 0:
                        case 1:
                        case 2:
                            break;
                        case -1:
                        case -2:
                        case -3:
                            if (facemoved != 3) { 
                                invalid = true;
                            }
                            break;
                        case -4:
                        case -5:
                        case -6:
                            if (facemoved < 12) { 
                                invalid = true;
                            }
                            break;
                        case 3:
                        case 4:
                        case 5:
                            if (facemoved != 0)
                            {
                                invalid = true;
                            }
                            break;
                        case 6:
                        case 7:
                        case 8:
                            if ((facemoved > 9) || (facemoved < 6))
                            {
                                invalid = true;
                            }
                            break;
                        default:
                            invalid = true;
                            break;

                    }
                }

                if (!invalid) {

                    switch (inp[i + 1]) {
                        case ']':
                            if (moves[facemoved]) { 
                                movement = facemoved + 2;
                                moves[movement] = true;
                                moves[facemoved] = false;
                            } else if (moves[facemoved + 1]) {
                                movement = -1;
                                moves[facemoved + 1] = false;
                            } else if (moves[facemoved + 2]) { 
                                movement = facemoved + 1;
                                moves[movement] = true;
                                moves[facemoved + 2] = false;
                            } else { 
                                movement = facemoved;
                                moves[movement] = true;
                            }
                            break;
                        case '[':
                            if (moves[facemoved])
                            {
                                movement = -1;
                                moves[facemoved] = false;
                            }
                            else if (moves[facemoved + 1])
                            {
                                movement = facemoved + 2;
                                moves[movement] = true;
                                moves[facemoved + 1] = false;
                            }
                            else if (moves[facemoved + 2])
                            {
                                movement = facemoved;
                                moves[movement] = true;
                                moves[facemoved + 2] = false;
                            }
                            else
                            {
                                movement = facemoved;
                                moves[movement] = true;
                            }
                            break;
                        case '2':
                            if (moves[facemoved])
                            {
                                movement = facemoved + 1;
                                moves[movement] = true;
                                moves[facemoved] = false;
                            }
                            else if (moves[facemoved + 1])
                            {
                                movement = facemoved;
                                moves[movement] = true;
                                moves[facemoved + 1] = false;
                            }
                            else if (moves[facemoved + 2])
                            {
                                movement = -1;
                                moves[facemoved + 2] = false;
                            }
                            else
                            {
                                movement = facemoved;
                                moves[movement] = true;
                            }
                            break;
                        default:
                            Application.Exit();
                            break;
                    }
                }
            }
            return moves;
        }















    }
}
