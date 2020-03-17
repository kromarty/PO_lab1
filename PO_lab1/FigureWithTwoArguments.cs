using System.Globalization;

namespace PO_lab1
{
    /// <summary>
    /// Abstract class that works with figures that need two arguments to get area value.
    /// </summary>
    public abstract class FigureWithTwoArguments
    {
        public abstract double AreaFormula(double a , double b);
        
        /// <summary>
        /// Method of parsing input parameters and serving it to calculating method.
        /// </summary>
        /// <param name="parameters">String input parameters.</param>
        /// <returns>Calculated area value.</returns>
        public double GetArea(string parameters)
        {
            if (string.IsNullOrEmpty(parameters))
                return 0;
            string[] argsArr = parameters.Split(' ');
            if (argsArr.Length != 2)
                return 0;
            bool success =  double.TryParse(argsArr[0], NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out double double1) 
                & double.TryParse(argsArr[1], NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out double double2);
            if (success)
            {
                return AreaFormula(double1,double2);
            }
            return 0;
        }
    }
}
