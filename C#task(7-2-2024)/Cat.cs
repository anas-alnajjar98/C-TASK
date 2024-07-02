using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_task_7_2_2024_
{
    internal class Cat:Animal,ISound
    {
        public Cat(string name) : base(name) { }
       
        public override void Eat() { Console.WriteLine($"{Name}is eating whatever it want"); }
       public  void MakeSound() { Console.WriteLine($"{Name}blablabla"); }
    }
}
