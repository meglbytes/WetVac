using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetVacClient
{
   public static class Conversions // Default Units will be Imperial
    {
       public static double convertTempurature(double value, string type)  // Default units will be °F
        {
            double convertedValue = 0;
            switch (type)
            {
                case "°F":                      // Consider using Enums
                    convertedValue = value;
                        break;
                case "°C":
                    convertedValue = value * 2 + 30;
                        break;
                case "°R":
                    convertedValue = value - 459.67;
                        break;
                case "°K":
                        convertedValue = (value - 273.15) * 1.800 + 32;
                        break;
            }
            return convertedValue  ;
        }

        public static double convertPressure(double value, string type)  // Default units will be PSI ABS
        {
            double convertedValue = 0;
            switch (type)
            {
                case "psi abs":
                case"psi":
                    convertedValue = value;
                    break;
                case "bar abs":
                case "bar":
                    convertedValue = value * 14.50377;
                    break;
                case "ft elevation":
                    convertedValue = Math.Pow(Math.E , (2.68757 - 0.000037016 * value));
                    break;
                case "m elevation":
                    convertedValue = Math.Pow(Math.E , (2.68757 - 0.000037016 * value * 3.281));
                    break;
                case "kPa abs":
                    convertedValue = value * 14.50377 / 10;
                    break;
                case "mbar abs":
                    convertedValue = value * 14.50377 / 100;
                    break;
                case "ft H20 Vac":
                    convertedValue = value * 0.43352;
                    break;
                case "in H20 Vac":
                    convertedValue = value * 0.43352 * 12;
                    break;
                case "in HG Vac":
                    convertedValue = value * 2.03602;
                    break;
                case "mm Aq Vac":
                    convertedValue = value * 0.001422295170521;
                    break;
                case "mm HG Vac":
                    convertedValue = value * 0.0193367747;
                    break;
                                                   }
            return convertedValue;
        }

        public static double convertFlow()
        {
            double convertedValue = 0;

            return convertedValue;
        }
    }
}
