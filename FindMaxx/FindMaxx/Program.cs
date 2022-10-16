using System;
using System.IO;

namespace FindMaxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n---- Welcome to Generics Program ----");

            bool check = true;



            while (check)
            {
                //FindMax obj = new FindMax();
                Console.WriteLine("Select Option:\n" +
                    "1) Find Integer Maximum Number\n" +
                    "2) Find Float Maximum Number\n" +
                    "3) Find Maximum String\n\n\n");
                Console.Write("\nEnter Your Choice :  ");
                
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {


                    case 1:

                        FindMax<int> obj = new FindMax<int>(22, 54, 62,87,32);
                        obj.PrintMaxValue();
                        break;
                    case 2:
                        FindMax<float> objf = new FindMax<float>(22.6f,122.8f, 22.6f,65.6f,65.9f);
                        objf.PrintMaxValue();
                        break;
                    case 3:
                        FindMax<string> objs = new FindMax<string>("zApple", "Peach", "Banana","Mango","Stewberry");
                        objs.PrintMaxValue();
                        break;


                    default:
                        check = !check;
                        break;
                }
            }

            Console.ReadKey();

        }
    }
}