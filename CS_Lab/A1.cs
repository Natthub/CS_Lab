using System;

namespace CS_Lab
{
    internal class A1
    {
        public A1()
        {
            Menu();
        }
        private void Menu()
        {
            Console.WriteLine("*** A1 ***");
            while (true)
            {
                Console.WriteLine("\n\tMenu");
                Console.WriteLine("1-Line\n2-Rectangle\n3-Triangle\n4.Exit prg");
                Console.WriteLine("----------");
                Console.Write("Menu :> ");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    line();
                }
                else if (choose == "2")
                {
                    rectangle();
                }
                else if (choose == "3")
                {
                    triangle();
                }
                else
                {
                    Console.WriteLine("\n\nExit Program.....");
                    break;
                }
            }
        }
        private void line()
        {
            // Input
            Console.Write("\ninput length of line :> ");
            int length;
            string lengthStr = Console.ReadLine();
            if (!int.TryParse(lengthStr, out length))
            {
                Console.WriteLine("Please enter valid input for length ! ");
                return;
            }
            // Output
            Console.WriteLine();
            for (int i = length-1 ; i >= 0; i--)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        private void rectangle()
        {
            // Input
            Console.Write("\ninput length of line :> ");
            int length;
            string lengthStr = Console.ReadLine();
            if (!int.TryParse(lengthStr, out length))
            {
                Console.WriteLine("Please enter valid input! ");
                return;
            }
            Console.Write("amount : ");
            int amount;
            string amountStr = Console.ReadLine();
            if (!int.TryParse(amountStr, out amount))
            {
                Console.WriteLine("Please enter valid input! ");
                return;
            }
            // Output
            Console.WriteLine();
            for (int i = 1; i <= amount; i++)
            {
                for(int j = 1; j <= length; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private void triangle()
        {
            // Input
            Console.Write("\ninput width of line :> ");
            int width;
            string widthStr = Console.ReadLine();
            if (!int.TryParse(widthStr, out width))
            {
                Console.WriteLine("Please enter valid input! ");
                return;
            }

            // Output
            Console.WriteLine();

            for (int i = width; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}