using System;

namespace C_Task_6_25_2024_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string userString = Console.ReadLine();
            Console.WriteLine(userString);

            int nums = 10;
            double dnums = 10.5;
            string str = "anything";
            char charact = 'a';
            bool valid = true;
            const string strConst = "just for test";

            Console.WriteLine($"The nums={nums} and the double={dnums} and the string={str} and the char={charact} and the bool={valid} and the const={strConst}");

            string[] cars = { "BMW", "VOLVO", "Volkswagen" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine(cars.Length);
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter your year of birth:");
            int yearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine($" {firstName} { lastName} {yearOfBirth}");
            int[] arrayOfnumber=new int[10];
            for (int i = 0; i < arrayOfnumber.Length; i++) {
                Console.Write($"Element {i}: ");
                arrayOfnumber[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < arrayOfnumber.Length; i++) {
                Console.WriteLine(arrayOfnumber[i]);
            }
            int[] arrayTosum=new int[3];
            int sum=0;
            for (int i = 0; i<arrayTosum.Length ; i++) {
                Console.Write($"Element {i}: ");
                arrayTosum[i]=int.Parse(Console.ReadLine());
                sum += arrayTosum[i];

            }
            Console.WriteLine(sum);
        }
    }
}
