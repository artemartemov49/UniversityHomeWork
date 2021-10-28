using System;
using System.Drawing;
using System.Numerics;
using Task3;

namespace Task1
{
    public class RectangleTurning : RectangleMovement
    {
        public RectangleTurning(int x, int y, int sidesSize) : base(x, y, sidesSize)
        {
        }

        public override void Move()
        {
            var rectangle = GetRectangle();
            var deg = 0;
            Console.WriteLine(
                "Press arrow left or right and rotation position will be shown. Press \"Enter\" if you want to exit");
            ConsoleKeyInfo pressedKey;
            do
            {
                pressedKey = Console.ReadKey(true);
                switch (pressedKey.Key)
                {
                    case ConsoleKey.LeftArrow:
            


                        if (deg == -360)
                        {
                            deg = 0;
                        }
                        else if (deg < 0)
                        {
                            deg += 360;
                        }

                        deg += 90;
                        if (deg is > 0 and <= 90)
                        {
                            rectangle.Y = Math.Abs(rectangle.Y);
                            rectangle.X = Math.Abs(rectangle.X);
                        }
                        else if (deg is > 90 and <= 180)
                        {
                            rectangle.Y = Math.Abs(rectangle.Y);
                            rectangle.X = -Math.Abs(rectangle.X);
                        }
                        else if (deg is > 180 and <= 270)
                        {
                            rectangle.Y = -Math.Abs(rectangle.Y);
                            rectangle.X = -Math.Abs(rectangle.X);
                        }
                        else if (deg is > 270 and <= 360)
                        {
                            rectangle.Y = -Math.Abs(rectangle.Y);
                            rectangle.X = Math.Abs(rectangle.X);
                        }
                        else if (deg > 360)
                        {
                            deg = 0;
                            rectangle.Y = Math.Abs(rectangle.Y);
                            rectangle.X = Math.Abs(rectangle.X);
                        }

                        Console.WriteLine($"X position is {rectangle.X}");
                        Console.WriteLine($"Y position is {rectangle.Y}");
                        Console.WriteLine($"Deg is {deg}");
                        break;
                    case ConsoleKey.RightArrow:
                        if (deg > 0)
                        {
                            deg -= 360;
                        }

                        deg -= 90;
                        if (deg is > 0 and >= -90)
                        {
                            rectangle.Y = -Math.Abs(rectangle.Y);
                            rectangle.X = Math.Abs(rectangle.X);
                        }
                        else if (deg is > -90 and >= -180)
                        {
                            rectangle.Y = -Math.Abs(rectangle.Y);
                            rectangle.X = -Math.Abs(rectangle.X);
                        }
                        else if (deg is > -180 and >= -270)
                        {
                            rectangle.Y = Math.Abs(rectangle.Y);
                            rectangle.X = -Math.Abs(rectangle.X);
                        }
                        else if (deg is > -270 and >= -360)
                        {
                            rectangle.Y = Math.Abs(rectangle.Y);
                            rectangle.X = Math.Abs(rectangle.X);
                        }
                        else if (deg < -360)
                        {
                            deg = 0;
                            rectangle.Y = -Math.Abs(rectangle.Y);
                            rectangle.X = Math.Abs(rectangle.X);
                        }

                        Console.WriteLine($"X position is {rectangle.X}");
                        Console.WriteLine($"Y position is {rectangle.Y}");
                        Console.WriteLine($"Deg is {deg}");
                        break;
                }
            } while (pressedKey.Key != ConsoleKey.Enter);

            X = rectangle.X;
            Y = rectangle.Y;
            PrintInfo();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Location of left angle: x - {X}, y - {Y}");
            Console.WriteLine($"{GetRectangle()}");
            Console.WriteLine($"Size of sides: {SidesSize}");
        }
    }
}