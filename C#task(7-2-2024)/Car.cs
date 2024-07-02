using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_task_7_2_2024_
{
    public class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
        public string PalletNo { get; set; }
        public string Color { get; set; }

        public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNo = palletNo;
            Color = color;
        }

        public void DisplayInfo(string make, int year)
        {
            Console.WriteLine($"Make: {make}, Year: {year}");
        }

        public void DisplayInfo(string make)
        {
            Console.WriteLine($"Make: {make}");
        }

        public virtual void Display()
        {
            Console.WriteLine("Welcome Car");
            Console.WriteLine($"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}");
        }
    }
}
