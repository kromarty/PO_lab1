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
    public class Square : FigureWithSingleArgument
    {
        /// <summary>
        /// Method that calculate area of square using appropriate formula.
        /// </summary>
        /// <param name="a">Arguments needed to calculate area. Side of square.</param>
        /// <returns>Calculated area value.</returns>
        public override double AreaFormula(double a)
        {
            return a * a;
        }
        public override double PerimeterFormula(double a)
        {
            return 4 * a;
        }
    }
}