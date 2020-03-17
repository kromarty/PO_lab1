
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_lab1
{
    /// <summary>
    /// Program point of entry.
    /// </summary>

    class Program
    {
        /// <summary>
        /// Program point of entry.
        /// </summary>
        /// <param name="args">Array of arguments that is transmitted after program running.</param>
        
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Enter a figure ");
            string figure = Console.ReadLine();
            Console.WriteLine("Enter parameters with space delimeter ");
            string parameters = Console.ReadLine();
            Console.WriteLine(FigureChoose.GetArea(figure, parameters));
            Console.ReadKey();
        }
    }
}
