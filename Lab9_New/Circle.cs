using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_New
{
   public class Circle
    {
        public double radius = 0;
        public static int numberOfCircle = 0;

        public Circle(double radius)
        {
            this.radius = radius;
            numberOfCircle++;
        }
        public static int getObjectCount()
        {

            return numberOfCircle;
        }

        public double getArea()
        {
            double areaOfACircle = Math.PI * radius * radius;
            return areaOfACircle;
        }

        public double getCircumference()
        {
            double circumferenceOfACircle = 2 * Math.PI * radius;
            return circumferenceOfACircle;

        }

        private String formatNumber(double valueToFormat)
        {
            string formattedValue = Math.Round(valueToFormat, 2).ToString();

            return formattedValue;
        }

        public string getFormattedCircumference()
        {
            double formattedCircumference = this.getCircumference();
            String valueToBeDisplayed = this.formatNumber(formattedCircumference);

            return valueToBeDisplayed;
        }

        public String getFormattedArea()
        {
            double formattedArea = this.getArea();
            String valueToBeDisplayed = this.formatNumber(formattedArea);
            return valueToBeDisplayed;
        }

    }
}
