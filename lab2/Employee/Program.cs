using System;

namespace Employee
{
    public class Employee
    {
        private readonly string name;
        private readonly string secondname;

        public Employee(string name, string secondname)
        {
            this.name = name;
            this.secondname = secondname;
        }

        public void salary()
        {
            int position, experience;
            double salary, tax;
            Console.WriteLine("We have three positions and types of experience");
            Console.WriteLine("Choice position");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choice experience");
            experience = Convert.ToInt32(Console.ReadLine());
            if (position == 1 && experience <= 3)
            {
                Console.WriteLine("You office manager");
                salary = ((50000 + 50000) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Your salary: {salary}");
                Console.WriteLine($"Your tax: {tax}");
            }
            if (position == 2 && experience <= 3)
            {
                Console.WriteLine("You accountant");
                salary = ((60000 + 23000) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Your salary: {salary}");
                Console.WriteLine($"Your tax: {tax}");
            }
            if (position == 3 && experience >= 10)
            {
                Console.WriteLine("You head director");
                salary = ((80000 + 84000) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Your salary: {salary}");
                Console.WriteLine($"Your salary: {tax}");
            }

            Console.WriteLine($"You {name} {secondname} and your posiotion {position}.");

        }


        static void Main(string[] args)
        {
            Employee employee = new Employee("Ivan", "Kulic");
            employee.salary();
        }
    }
}
