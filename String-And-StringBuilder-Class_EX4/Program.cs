using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace String_And_StringBuilder_Class_EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Words words = new Words("Komeat IT - kissat");
            Console.WriteLine(words.IsAnagramIgnoreCaseNSpace("Matti, otas keksi!"));
        }
    }
}
