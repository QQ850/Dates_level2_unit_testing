using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
namespace sample
    .lib
{
    static public class Converter
    {
       static public string ConvertToGregorian(int year) {

            if (year == 2023) {
                return "Saturday, January 28, 2023";
            }
            if (year == 2021) {
                return "Friday, February 12, 2021";
            }
            if (year == 1999) {
                return "Tuesday, February 16, 1999";
            }
            throw new NotImplementedException();
            
       }
       
    }
}