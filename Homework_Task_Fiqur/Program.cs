using System;
using Homework_Task_Fiqur.Models;
namespace Homework_Task_Fiqur
{
    class Program
    {
        static void Main(string[] args)
        {
            //If user 1 writes and clicks enter, Square's CalcArea method should start.
            //If user type 2 and press enter, Rectangular's CalcArea method should start.
            //If the user writes 0 and presses enter, the program should end.
            Square quadratic = new Square(5);
            Rectangular rectangular = new Rectangular(5,4);
            int choice;
            do
            {
                Console.WriteLine("Enter");
                Console.WriteLine("---------------");
               

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("The program is quit");
                        break;
                    case 1:
                        Console.WriteLine("The area of the square" + " "+quadratic.CalcArea());
                        break;
                    case 2:
                        Console.WriteLine("The area of a rectangle" +" " + rectangular.CalcArea());
                        break;
                    default:
                        Console.WriteLine("-------------");
                        break;
                }
            } while (choice != 0);
        }
    }
}