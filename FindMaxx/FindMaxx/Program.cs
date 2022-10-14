using System;
using System.IO;

namespace FindMaxx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Generics Program");
            FindMax findMax = new FindMax();
            bool check = true;


            while (check)
            {
                Console.Write("\n\nSelect The Option \n\n" +
                   "1) Find Maximum Integer Value\n" +
                   "2) Find Maximum Float Value\n" +
                   "3) Find Maximum String");

                Console.Write("\n\nEnter Your Choice : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                      

                    case 1:
                        int result = findMax.FindMaxInteger(15, 100, 5);
                        Console.WriteLine("\nGreatest number among three numbers is : " + result);
                        break;

                        case 2:
                        float result1 = findMax.FindMaxFloat(322.3f,433.7f,683.2f);
                        Console.WriteLine("\nGreatest number among three Float Numbers is : " + result1);
                        break;

                    case 3:
                        string result3 = findMax.FindMaxString("Peach", "Apple",  "Banana");
                        Console.WriteLine("\nGreatest string among three is : " + result3);
                        break;


                    default:
                        check = !check;
                        break;
                }

            }
        }
    }
}