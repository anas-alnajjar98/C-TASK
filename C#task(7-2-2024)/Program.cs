using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_task_7_2_2024_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW bMW = new BMW("blablabal",1999, "Nissan Versa", 12500, "C11 2007 - 2009", "19-2367722", "black");
            bMW.Display();
            Car car = new BMW("blablabal", 1999, "Nissan Versa", 12500, "C11 2007 - 2009", "19-2367722", "black");
            car.Display();
            Cat cat=new Cat("Rakon");
            Dog dog = new Dog("klb");
            cat.Eat();
            cat.Sleep();
            dog.Eat();
            dog.Sleep();


        }
    }
}
