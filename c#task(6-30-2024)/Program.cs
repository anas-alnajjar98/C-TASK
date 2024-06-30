using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_task_6_30_2024_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumAndAvg mark = new SumAndAvg();
            Console.Write("enter the cab of array:");
            int arraycab = int.Parse(Console.ReadLine());
            double[] marks = new double[arraycab];
            for (int i = 0; i < arraycab; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"the sum ={mark.avgandsum(marks).Item1}");
            Console.WriteLine($"the AVG ={mark.avgandsum(marks).Item2}");
            Console.Write("enter the n term to cube");
            int x = int.Parse(Console.ReadLine());
            Cube cube = new Cube();
            while (x > 0) {
                cube.cubeNUMBER(x);
                x--;
            }
            int[] years = {1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020};
            years yr=new years();
            int[] newYear = yr.graterYear(years);
            for (int i = 0; i < newYear.Length; i++) {
                if (newYear[i] != 0) {
                    Console.Write($",{newYear[i]} ");
                }
               
            }
            Console.WriteLine();
            Console.Write("pleas senter your age in years:");
            double yearIndays=double.Parse(Console.ReadLine());
            yersIndays indays=new yersIndays();
            indays.YearsDays(yearIndays);
            info anas = new info();
            anas.age = 20;
            anas.Phone = "0791234567";
            anas.Email = "ashouiahec";
            anas.Gender = "M";
            anas.id = "asihcoiahscli";
            anas.Name = "hbkjbasc";
            Console.WriteLine(anas.Name); ;

        }
    }
}
