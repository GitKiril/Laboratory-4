using System;

namespace _2
{
    internal class Program
    {
        //I gave an abstract idea, for example, we can put some game instead of class B: Cs go, dota, or we can put.
        //For example, a banking application where there are loans
        //class A can be a map or an application
        static void Main(string[] args)
        {
            custom1 heir1 = new custom1();
            custom2 heir2 = new custom2();
            custom3 heir3 = new custom3();
            A a = new A(heir1, heir2, heir3);
            double y = heir1.Math(1, 3);
            Console.WriteLine(y);
        }
    }
}
