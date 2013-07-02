using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenerator.Common
{
    public static class DoubleExtensions
    {
        private readonly static DoubleExtensionLogic doubleExtensionLogic = new DoubleExtensionLogic();

        public static double Clamp(this double d, double d1, double d2)
        {
            return doubleExtensionLogic.Clamp(d, d1, d2);
        }

        public class DoubleExtensionLogic
        {
            public double Clamp(double d, double d1, double d2)
            {
                double min = Math.Min(d1, d2);
                double max = Math.Max(d1, d2);
                if (d < min)
                    d = min;
                if (d > max)
                    d = max;
                return d;
            }
        }
    }
}
