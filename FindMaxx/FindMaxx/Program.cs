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
                        int result = obj.Maxmethod();
                        Console.WriteLine("Greatest number among three numbers is :  " + result);
                        break;
                    case 2:
                        FindMax<float> objf = new FindMax<float>(22.6f,22.8f, 22.6f,65.6f,65.9f);
                        float resultf = objf.Maxmethod();
                        Console.WriteLine("Greatest number among three float number is :  " + resultf);
                        break;
                    case 3:
                        FindMax<string> objs = new FindMax<string>("Apple", "Peach", "Banana","Mango","Stewberry");
                        string results = objs.Maxmethod();
                        Console.WriteLine("Greatest string among three string is :  " + results);
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