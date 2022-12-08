using System;
namespace Line_Comparison_Problem
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            int x1, x2, y1, y2, x3, y3, x4, y4;
            Console.WriteLine("Enter values x1  for Line 1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y1 for Line 1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x2  for Line 1");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y2 for Line 1");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x3 for Line 2");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y3 for Line 2");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values x4  for Line 2");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values y4 for Line 2");
            y4 = Convert.ToInt32(Console.ReadLine());

            double len1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("length of the line 1" + len1);
            double len2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("length of the line 2" + len2);

            if (len1.Equals(len2))
                Console.WriteLine("Lines are equal in length.");
            else
                Console.WriteLine("Lines are not equal in length.");
        }
    }
}