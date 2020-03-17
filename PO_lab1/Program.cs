
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
            
            Console.WriteLine("Enter a figure: ");
            string figure = Console.ReadLine();

            Console.WriteLine("Enter what you want to count:(a-area/p-perimeter) ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "p":
                    Console.WriteLine("Enter parameters with space delimeter ");
                    string parameters = Console.ReadLine();
                    Console.WriteLine(FigureChoose.GetPerimeter(figure, parameters)); ;
                    break;
                case "a":
                    Console.WriteLine("Enter parameters with space delimeter ");
                    string aParameters = Console.ReadLine();
                    Console.WriteLine(FigureChoose.GetArea(figure, aParameters));
                    break;
            }
            Console.ReadKey();
        }
    }
}
