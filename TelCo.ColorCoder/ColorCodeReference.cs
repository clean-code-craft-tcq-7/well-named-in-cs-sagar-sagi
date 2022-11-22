using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding
    /// </summary>
    class ColorCodeReference
    {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        public static Color[] colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet};
        /// <summary>
        /// Array of minor colors
        /// </summary>
        public static Color[] colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };

        /// <summary>
        /// Print the complete code code map
        /// </summary>
        public static void PrintColorCodeMap()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------- Color Code map ----------------------");
            for (int pairNumber = 1; pairNumber <= (colorMapMajor.Length * colorMapMinor.Length); pairNumber++)
            {
                ColorPair colorPair = ColorFromPairNumber.GetColorFromPairNumber(pairNumber);
                Console.WriteLine("Pair Number: {0}, Colors: {1}\n", pairNumber, colorPair);
            }
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
