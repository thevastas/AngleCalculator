using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AngleCalculator
    {
        public int PosToDegrees(int arrowpos, bool IsHour)
        {
            int angle;

            if (IsHour)
            {
                if (arrowpos < 0 || arrowpos > 24) throw new System.ArithmeticException();
                else if (arrowpos > 12) arrowpos -= 12;
                angle = 360 * arrowpos / 12;
            }
            else angle = 360 * arrowpos / 60;

            return angle;
        }

        public int CalculateAngle(int number1, int number2)
        {
            int anglehours = PosToDegrees(number1, true);
            int angleminutes = PosToDegrees(number2, false);
            
            var anglevalue = Math.Abs(anglehours - angleminutes);
        if (anglevalue > 180) anglevalue = 360 - anglevalue;

            return anglevalue;
        }
    }
