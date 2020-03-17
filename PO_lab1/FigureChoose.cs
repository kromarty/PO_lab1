namespace PO_lab1
{
    /// <summary>
    /// Class that calls certain method of calculating area value according to input parameter.
    /// </summary>
    class FigureChoose
    {
        /// <summary>
        /// Method that decides what figure area will be calculated.
        /// </summary>
        /// <param name="figureName">Name of figure wanted to get calculated.</param>
        /// <param name="args">Arguements needed to calculate figure area.</param>
        /// <returns>Value of calculated area of certain figure.</returns>
        internal static object GetArea(string figureName, string args)
        {
            switch (figureName)
            {
                case "triangle":
                    Triangle tr = new Triangle();
                    return tr.GetArea(args);
                case "square":
                    Square sq = new Square();
                    return sq.GetArea(args);
                case "rectangle":
                    Rectangle rec = new Rectangle();
                    return rec.GetArea(args);
                case "circle":
                    Circle circle = new Circle();
                    return circle.GetArea(args);
            }
            return "Enter a valid figure!";
        }
        internal static object GetPerimeter(string figureName, string args)
        {
            switch (figureName)
            {
                case "square":
                    Square sq = new Square();
                    return sq.GetPerimeter(args);
                case "circle":
                    Circle circle = new Circle();
                    return circle.GetPerimeter(args);
            }
            return "No such option for this figure!";
        }
    }
}
