using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_task_7_1_2024_
{
      public class Car
    {
        public Car(int year, string type, double price, string model, string palletNo, string color)
        {
            this.year = year;
            this.type = type;
            this.price = price;
            this.model = model;
            PalletNo = palletNo;
            this.color = color;
        }
        public int year { set; get; }
        public string type { set; get; }
        public double price { set; get; }
        public string model { set; get; }
        public string PalletNo { set; get; }
        public string color { set; get; }
        public static void Start()
        {
            Console.WriteLine("The car engine is on");
        }
        public static void Stop()
        {
            Console.WriteLine("The car engine is off");
        }
        public /*(int, string, double, string, string, string)*/ string display {
            get{
                //(int, string, double, string, string, string) t1 = (this.year, this.type, this.price, this.model, this.PalletNo, this.color);
                //return t1; 
                return $"the year is:{this.year}\n the type is:{this.type}\n the price is:{this.price}\n the model is :{this.model}\n the PalletNo:{this.PalletNo}\n the color is:{this.color} ";
            
            }
        
        
        }
    }
    
}
