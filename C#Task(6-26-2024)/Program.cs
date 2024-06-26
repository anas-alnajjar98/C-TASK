using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task_6_26_2024_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 < num1)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num1);
            }
            Console.Write("Please enter a number to determine its sign: ");
            int signNumber = int.Parse(Console.ReadLine());
            string sign = (signNumber < 0) ? "-" : "+";
            Console.WriteLine(sign);
            int[] arr = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number {i + 1} to put in the array: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.Write("Sorted array in descending order: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int[] arr2 = { -5, -2, -6, 0, -1 };
            int largestNumber = arr2[0];
            for (int i = 1; i < arr2.Length; i++)
            {
                if (arr2[i] > largestNumber)
                {
                    largestNumber = arr2[i];
                }
            }
            Console.WriteLine("Largest number is: " + largestNumber);
            Console.Write("Enter speed in kilometers: ");
            double kilometer = double.Parse(Console.ReadLine());
            Console.WriteLine($"{kilometer * 0.62137119} miles per hour");
            Console.Write("Enter hours: ");
            int hourInput = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes: ");
            int minutesInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"Total: {(hourInput * 60) + minutesInput} minutes");
            Console.Write("Enter the total number of minutes: ");
            int totalMinutes = int.Parse(Console.ReadLine());
            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;
            Console.WriteLine($"{hours} hours, {minutes} minutes");
            string[] arrayOfstring = { "blablabla", "anything", "so easy", "Orange", "anything number2" };
            int fixLength = 4;
            foreach (string s in arrayOfstring) {
                if (s.Length < fixLength)
                {
                    Console.WriteLine(s);
                    
                }
                else {
                    Console.WriteLine(s.Substring(0, fixLength));
                }
            }
        }
        
    }
}
