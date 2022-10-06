using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugOne
{
    internal class Task1<T>
    {
        public void GetInDebugMethod(T first, T second)
        {
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Type for first parameter is : {first.GetType()} and value :  ");
            Console.WriteLine(first);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"Type for second parameter is : {second.GetType()} and value :  ");
            Console.WriteLine(second);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
