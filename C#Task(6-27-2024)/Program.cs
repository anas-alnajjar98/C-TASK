using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Task_6_27_2024_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1-	Correct the syntax error:

            •	string [ ] ARR= [ 1,7  9  45, ]
            •	int arr2=["Str" "alex","moh"
            •	string arr3= 'the','fox' 'over' lazy, 'dog',  ]
                */
            int[] ARR = { 1, 7, 9, 45 };
            String []arr2 = {"Str" ,"alex", "moh"};
            string []arr3 = { "the", "fox", "over", "lazy", "dog", };

            /*2-	What the index of "Banana","Tomato"?
            String [ ]  fruits=["Tomato","Banana","Watermelon"]
            */
            String[] fruits = { "Tomato", "Banana", "Watermelon" };
            int BananaIndex = Array.IndexOf(fruits, "Banana");
            int TomatoIndex = Array.IndexOf(fruits, "Tomato");
            Console.WriteLine($"The index of Banana={BananaIndex}");
            Console.WriteLine($"The index of Tomato={TomatoIndex}");
            /*3-	Create an multiple arrays that represents your:
            •	Favorite Food (5 item)
            •	Favorite Sport (3 item)
            •	Favorite Movie (4 item)
            Then, print each array using foreach, and Loop Through an Array
            */
            string[] arr4 = { "food1", "food2", "food3", "food4", "food5" };
            foreach (string x in arr4) {
                Console.WriteLine(x);
            }
            string[] arr5 = { "spor1", "sport2", "sport3" };
            foreach (string x in arr5)
            {
                
                Console.WriteLine(x);
            }
            string[] arr6 = { "movie1", "movie2", "movie3", "movie4", "movie5" };
            foreach (string x in arr6)
            {
                Console.WriteLine(x);
            }
            /*
             4-	Write a program in C# to calculate the sum of three numbers with getting input in one line separated by a comma
                •	Expected Output:
                •	Input three numbers separated by comma: 5,10,15
                •	The sum of three numbers: 30.

             */
            Console.Write("Please inter the size of array:");
            int TheSizeOfArray=int.Parse(Console.ReadLine());
            int[]arr7=new int[TheSizeOfArray];
            int sum=0;
            for (int i = 0; i < TheSizeOfArray; i++) { 
            arr7[i]=int.Parse(Console.ReadLine());
                sum += arr7[i];
            }
            Console.WriteLine(sum);
            /*
             5-	Write a program in C# to display the n terms of odd number and their sum from [1- 100 ]. 
                    •	Test Data
                    •	The odd numbers are1 3 5 7 9 11 13 15 17 19……
                    •	The Sum of odd Numbers is: …...
             */
            int Onehundred = 0;
            int Oddsum = 0;
            while (Onehundred <= 100)
            {
                if (Onehundred % 2 != 0)
                {
                    Console.Write($"{Onehundred} ");
                    Oddsum += Onehundred;
                }
                Onehundred++;
            }
            Console.WriteLine();
            Console.WriteLine(Oddsum);
            /*
             6-	Write a program in C## to display the pattern like right angle triangle using an asterisk. Go to the editor
             */
            int row = 0;
            while (row < 10)
            {
                int j = 1;
                while (j < row)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                row++;
            }
            /*
             7- Write a program in C# to make such a pattern like right angle triangle with number increased by 1. Go to the editor
             */
            int row1 = 1;
            int num = 1;
            while (row1 <= 4)
            {
                int j1 = 1;
                while (j1 <= row1)
                {
                    Console.Write(num + " ");
                    j1++;
                    num++;
                }
                Console.WriteLine();
                row1++;
            }

        }
            
    }
}
