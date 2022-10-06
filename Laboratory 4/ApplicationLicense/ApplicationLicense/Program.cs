using System;

namespace ApplicationLicense
{
    class Program
    {
        internal class ApplicationLicense
        {
            static void Main(string[] args)
            {
                int code;
                Console.WriteLine("Enter your code to determine access to the program");
                code = Convert.ToInt32(Console.ReadLine());
                Application application = new Application(code);
                Console.WriteLine($"Your code : {code}");
                application.DoWork();
            }
        }
    }
}
