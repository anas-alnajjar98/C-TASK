using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_task_7_2_2024_
{
    public class BMW : Car
    {
        public BMW(string make, int year, string type, decimal price, string model, string palletNo, string color)
            : base(make, year, type, price, model, palletNo, color)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Welcome BMW");
            Console.WriteLine($"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}");
        }
    }
}
