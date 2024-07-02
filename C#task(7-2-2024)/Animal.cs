using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_task_7_2_2024_
{
    internal abstract class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }
       public string Name { get; set; }
       public abstract void Eat();
        public void Sleep() {
            Console.WriteLine($"{this.Name} is sleeping");
        }
    }
}
