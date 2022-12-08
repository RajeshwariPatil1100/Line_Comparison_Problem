using System;
namespace Line_Comparison_Problem
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            int X1, X2, Y1, Y2;
            Console.WriteLine("Enter co-ordinate value X1");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate value Y1");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate value X2 ");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate value Y2");
            Y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("The length of the Line is : " + length);
        }
    }
}