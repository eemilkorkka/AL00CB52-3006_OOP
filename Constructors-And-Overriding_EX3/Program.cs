using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_And_Overriding_EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window(800, 800, 600, 200);
            Console.WriteLine(window.sizeX);
            Console.WriteLine(window.sizeY);
       
        }
    }
}
