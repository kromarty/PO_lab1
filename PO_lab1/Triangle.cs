using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_lab1
{
    /// <summary>
    /// Class lets get a calculated area value.
    /// </summary>
    public class Triangle : FigureWithTwoArguments
    {
        /// <summary>
        /// Method that calculate area of triangle using appropriate formula.
        /// </summary>
        /// <param name="a">Argument needed to calculate area.</param>
        /// <param name="b">Argument needed to calculate area.</param>
        /// <returns>Calculated area value.</returns>
        public override double AreaFormula(double a, double b)
        {
            return a * b / 2;
        }
    }
}
