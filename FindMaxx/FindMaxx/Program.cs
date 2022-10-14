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
                   "2) Find Maximum Float Value");

                Console.Write("\n\nEnter Your Choice : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {


                    case 1:
                        int result = findMax.FindMaxInteger(15, 100, 5);
                        Console.WriteLine("\nGreatest number among three numbers is :" + result);
                        break;

                        case 2:
                        float result1 = findMax.FindMaxFloat(322.3f,133.7f,183.2f);
                        Console.WriteLine("\nGreatest number among three Float Numbers is :" + result1);
                        break;



                    default:
                        check = !check;
                        break;
                }

            }
        }
    }
}