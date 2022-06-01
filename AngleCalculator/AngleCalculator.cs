using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleCalculations
{
    public class AngleCalculator
    {

        static int MinutesDegrees(int minutespos)
        {
            int angle;
            if (minutespos < 0 || minutespos > 59) throw new System.ArithmeticException();
            angle = 360 * minutespos / 60;
            return angle;
        }

        static int HoursDegrees(int hourspos, int minutespos)
        {
            int angle;
            if (hourspos < 0 || hourspos > 24) throw new System.ArithmeticException();
            else if (hourspos > 12) hourspos -= 12;
            angle = 360 * hourspos / 12;
            angle += (minutespos / 2);
            return angle;
        }

        public int CalculateAngle(int hours, int minutes)
        {

            int angleminutes = MinutesDegrees(minutes);
            int anglehours = HoursDegrees(hours, minutes);

            var anglevalue = Math.Abs(anglehours - angleminutes);
            if (anglevalue > 180) anglevalue = 360 - anglevalue;

            return anglevalue;
        }
    }

}
