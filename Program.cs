using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Fjodora", "Markova", 15);

            employee1.BookWorkDay(6.33);
            employee1.BookWorkDay(6);
            employee1.BookWorkDay(8.5);

            employee1.PrintMonthSalary();

            Trainee trainee1 = new Trainee("Rasmus", "Winther",12);

            trainee1.BookWorkDay(8.17);
            trainee1.BookWorkDay(7);
            trainee1.BookWorkDay(4.5);
            trainee1.BookWorkDay();
            trainee1.BookWorkDay();

            trainee1.PrintMonthSalary();


            Console.ReadKey();

        }
    }
}
