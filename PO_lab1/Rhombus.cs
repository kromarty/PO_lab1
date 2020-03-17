using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_lab1
{
    class Rhombus : FigureWithTwoArguments
    {
        public override double AreaFormula(double a, double b)
        {
            return a * b / 2;
        }
    }
}
