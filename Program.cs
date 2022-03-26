using System;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }


        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("0) Exit");
            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");

            Console.Write("\r\nSelect an operation: ");



            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    AddTwoNumbers();
                    DisplayResult();
                    return true;
                case "2":
                    subtractNumbers();
                    DisplayResult();
                    return true;
                case "3":
                    MultiplyNumbers();
                    DisplayResult();
                    return true;
                case "4":
                    divideNumbers();
                    DisplayResult();
                    return true;


                default:
                    return true;
            }
        }

        public static void DisplayResult()
        {

            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();


        }




        public static string CaptureInput()
        {

            return Console.ReadLine();
        }





        public static void AddTwoNumbers()
        {

            int n1 = 0; int n2 = 0;

            Console.Clear();

            Console.WriteLine("Enter a number");

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");

            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 + n2);




            DisplayResult();
        }


        public static void subtractNumbers()
        {
            Console.Clear();

            int n1 = 0; int n2 = 0;

            Console.WriteLine("Enter a number");

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");

            n2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(n1 - n2);




            DisplayResult();
        }


        public static void MultiplyNumbers()
        {

            Console.Clear();



            int n1 = 0; int n2 = 0;

            Console.WriteLine("Enter a number");

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");

            n2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(n1 * n2);




            DisplayResult();
        }


        public static void divideNumbers()
        {

            Console.Clear();


            int n1 = 0; int n2 = 0;

            Console.WriteLine("Enter a number");

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");

            n2 = Convert.ToInt32(Console.ReadLine());





            if (n2 != 0)
            {

                Console.WriteLine(n1 / n2);

            }
            else Console.WriteLine("Cant divide by zero");

            DisplayResult();

        }

    }
}