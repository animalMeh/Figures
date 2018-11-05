namespace Randomizer
{
    using System;
    using System.Drawing;

    public class Randomizer
    {
        enum Colors
        {
            Black,
            White,
            Yellow,
            Orange,
            Green,
            Blue,
            Maroon,
            LightSeaGreen,
            Violet,
            Pink,
            Orchid,
            Red
        };
        private static Random rand = new Random();
        public static int GetValue(int from, int to)
        {
            return rand.Next(from, to);
        }
        public static Color GetColor()
        {
            int val = rand.Next(0, 11);
            return DefineColor(val);
        }

        private static Color DefineColor(int index)
        {
            switch (index)
            {
                case 0:
                    return Color.Black;
                case 1:
                    return Color.White;
                case 2:
                    return Color.Yellow;
                case 3:
                    return Color.Orange;
                case 4:
                    return Color.Green;
                case 5:
                    return Color.Blue;
                case 6:
                    return Color.Maroon;
                case 7:
                    return Color.LightSeaGreen;
                case 8:
                    return Color.Violet;
                case 9:
                    return Color.Pink;
                case 10:
                    return Color.Orchid;
                case 11:
                    return Color.Red;
                default:
                    return Color.Tomato;
            }
        }
    }
}
