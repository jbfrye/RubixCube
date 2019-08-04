using System;
using System.Collections.Generic;
using System.Text;

namespace RubixCube
{
    class Orientation
    {
        // result[0] = from, result[1] = too
        public static Side[] FindSidesInvolved(Side side, Direction dir)
        {
            Side[] result = new Side[2];
            switch (side)
            {
                case Side.Top:
                    switch (dir)
                    {
                        case Direction.Up:
                            result[0] = Side.Front;
                            result[1] = Side.Back;
                            break;
                        case Direction.Down:
                            result[0] = Side.Back;
                            result[1] = Side.Front;
                            break;
                        case Direction.Left:
                            result[0] = Side.Right;
                            result[1] = Side.Left;
                            break;
                        case Direction.Right:
                            result[0] = Side.Left;
                            result[1] = Side.Right;
                            break;
                    }
                    break;
                case Side.Front:
                    switch (dir)
                    {
                        case Direction.Up:
                            result[0] = Side.Bottom;
                            result[1] = Side.Top;
                            break;
                        case Direction.Down:
                            result[0] = Side.Top;
                            result[1] = Side.Bottom;
                            break;
                        case Direction.Left:
                            result[0] = Side.Right;
                            result[1] = Side.Left;
                            break;
                        case Direction.Right:
                            result[0] = Side.Left;
                            result[1] = Side.Right;
                            break;
                    }
                    break;
                case Side.Left:
                    switch (dir)
                    {
                        case Direction.Up:
                            result[0] = Side.Bottom;
                            result[1] = Side.Top;
                            break;
                        case Direction.Down:
                            result[0] = Side.Top;
                            result[1] = Side.Bottom;
                            break;
                        case Direction.Left:
                            result[0] = Side.Front;
                            result[1] = Side.Back;
                            break;
                        case Direction.Right:
                            result[0] = Side.Back;
                            result[1] = Side.Front;
                            break;
                    }
                    break;
                case Side.Back:
                    switch (dir)
                    {
                        case Direction.Up:
                            result[0] = Side.Bottom;
                            result[1] = Side.Top;
                            break;
                        case Direction.Down:
                            result[0] = Side.Top;
                            result[1] = Side.Bottom;
                            break;
                        case Direction.Left:
                            result[0] = Side.Left;
                            result[1] = Side.Right;
                            break;
                        case Direction.Right:
                            result[0] = Side.Right;
                            result[1] = Side.Left;
                            break;
                    }
                    break;
                case Side.Right:
                    switch (dir)
                    {
                        case Direction.Up:
                            result[0] = Side.Bottom;
                            result[1] = Side.Top;
                            break;
                        case Direction.Down:
                            result[0] = Side.Top;
                            result[1] = Side.Bottom;
                            break;
                        case Direction.Left:
                            result[0] = Side.Back;
                            result[1] = Side.Front;
                            break;
                        case Direction.Right:
                            result[0] = Side.Front;
                            result[1] = Side.Back;
                            break;
                    }
                    break;
                case Side.Bottom:
                    switch (dir)
                    {
                        case Direction.Up:
                            result[0] = Side.Back;
                            result[1] = Side.Front;
                            break;
                        case Direction.Down:
                            result[0] = Side.Front;
                            result[1] = Side.Back;
                            break;
                        case Direction.Left:
                            result[0] = Side.Right;
                            result[1] = Side.Left;
                            break;
                        case Direction.Right:
                            result[0] = Side.Left;
                            result[1] = Side.Right;
                            break;
                    }
                    break;
            }

            return result;
        }
    }
}