using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_task_7_1_2024_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car=new Car(1999,"Nissan Versa",12500, "C11 2007 - 2009","19-2367722","black");

            //var properties = typeof(Car).GetProperties();
            //foreach (var prop in properties)
            //{
            //    Console.WriteLine($"{prop.Name}: {prop.GetValue(car)}");
            //}
            //Console.WriteLine(car.display.Item1);
            //Console.WriteLine(car.display.Item2);
            //Console.WriteLine(car.display.Item3);
            //Console.WriteLine(car.display.Item4);
            //Console.WriteLine(car.display.Item5);
            //Console.WriteLine(car.display.Item6);
            Console.WriteLine(car.display);
            Bmw bmw = new Bmw(2022, "SUV", 60000, "X5", "B1234", "blue");
            Console.WriteLine(bmw.display);

        }
    }
}
