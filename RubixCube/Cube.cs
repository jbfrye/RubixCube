using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace RubixCube
{
    enum Side
    {
        Top, Front, Left, Back, Right, Bottom,
    }

    enum Direction
    {
        Up, Down, Left, Right,
    }
    class Cube
    {
        Color[][,] cube = new Color[6][,];

        public Cube()
        {
            // Initialize a cube to the default state
            for (int i = 0; i < 6; i++)
            {
                cube[i] = new Color[3, 3];
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        switch ((Side)i)
                        {
                            case Side.Top:
                                cube[i][j, k] = Color.White;
                                break;
                            case Side.Front:
                                cube[i][j, k] = Color.Blue;
                                break;
                            case Side.Left:
                                cube[i][j, k] = Color.Green;
                                break;
                            case Side.Back:
                                cube[i][j, k] = Color.Red;
                                break;
                            case Side.Right:
                                cube[i][j, k] = Color.Orange;
                                break;
                            case Side.Bottom:
                                cube[i][j, k] = Color.Yellow;
                                break;
                        }
                    }
                }
            }
        }

        public void Rotate(int rowOrCol, int num, Side side, Direction dir)
        {
            Side curr, from;
            Color[] temp = new Color[3];
            switch (rowOrCol)
            {
                // Row
                case 0:
                    temp[0] = cube[(int)side][num, 0];
                    temp[1] = cube[(int)side][num, 1];
                    temp[2] = cube[(int)side][num, 2];
                    curr = side;
                    for (int i = 0; i < 3; i++)
                    {
                        from = Orientation.FindSidesInvolved(curr, dir)[0];
                        cube[(int)curr][num, 0] = cube[(int)from][num, 0];
                        cube[(int)curr][num, 1] = cube[(int)from][num, 1];
                        cube[(int)curr][num, 2] = cube[(int)from][num, 2];
                        curr = from;
                    }
                    cube[(int)curr][num, 0] = temp[0];
                    cube[(int)curr][num, 1] = temp[1];
                    cube[(int)curr][num, 2] = temp[2];
                    break;
                // Col
                case 1:
                    temp[0] = cube[(int)side][0, num];
                    temp[1] = cube[(int)side][1, num];
                    temp[2] = cube[(int)side][2, num];
                    curr = side;
                    for (int i = 0; i < 3; i++)
                    {
                        from = Orientation.FindSidesInvolved(curr, dir)[0];
                        cube[(int)curr][0, num] = cube[(int)from][0, num];
                        cube[(int)curr][1, num] = cube[(int)from][1, num];
                        cube[(int)curr][2, num] = cube[(int)from][2, num];
                        curr = from;
                    }
                    cube[(int)curr][0, num] = temp[0];
                    cube[(int)curr][1, num] = temp[1];
                    cube[(int)curr][2, num] = temp[2];
                    break;
            }
        }
    }
}