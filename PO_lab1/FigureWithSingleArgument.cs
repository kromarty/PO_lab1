namespace PO_lab1
{
    /// <summary>
    /// Abstract class that works with figures that need one argument to get area value.
    /// </summary>
    public abstract class FigureWithSingleArgument
    {
        public abstract double AreaFormula(double a);
        public abstract double PerimeterFormula(double a);
        
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
            if (argsArr.Length != 1)
                return 0;
            bool success = double.TryParse(argsArr[0], out double doublenumber);
            if (success)
            {
                return AreaFormula(doublenumber);
            }
            return 0;
        }
        public double GetPerimeter(string parameters)
        {
            if (string.IsNullOrEmpty(parameters))
                return 0;
            string[] argsArr = parameters.Split(' ');
            if (argsArr.Length != 1)
                return 0;
            bool success = double.TryParse(argsArr[0], out double doublenumber);
            if (success)
            {
                return PerimeterFormula(doublenumber);
            }
            return 0;
        }
    }
}
