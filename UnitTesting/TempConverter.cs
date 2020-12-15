using System;

namespace UnitTesting
{
    public class TempConverter
    {
        public double TempConvert(double temp, string units)
        {
            double newTemp;
            if (units.Equals("c", StringComparison.OrdinalIgnoreCase))
            {
                newTemp = (temp * 1.8) + 32;
                return newTemp;
            }
            else
            {
                newTemp = (temp - 32) * 5 / 9;
                return newTemp;
            }
            
        }
    }
}
