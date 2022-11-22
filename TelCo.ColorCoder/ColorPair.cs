﻿using System;
using System.Drawing;

namespace Assesment1
{
    /// <summary>
    /// data type defined to hold the two colors of color pair
    /// </summary>
    class ColorPair
    {
        internal Color majorColor;
        internal Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }
}