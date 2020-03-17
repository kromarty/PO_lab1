using System;
using System.Collections.ObjectModel;
namespace PO_lab1
{
    /// <summary>
    /// Class lets get a calculated area value.
    /// </summary>
    public class Circle : FigureWithSingleArgument
    {
        /// <summary>
        /// Method that calculate area of circle using appropriate formula.
        /// </summary>
        /// <param name="a">Arguments needed to calculate area. Radius of circle.</param>
        /// <returns>Calculated area value.</returns>
        public override double AreaFormula(double a)
        {
            return a * a * Math.PI;
        }
        public override double PerimeterFormula(double a)
        {
            return 2 * Math.PI * a;
        }
    }
}
