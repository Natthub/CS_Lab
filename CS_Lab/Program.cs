using System;

namespace CS_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Write("\nEnter NO. (eg. A1 A2 A3 A4 A5 A6) : ");
                string choose = Console.ReadLine();
                if (choose == "A1")
                {
                    A1 a = new A1();
                }
                else if(choose == "A2")
                {
                    A2 a = new A2();
                }
                else if (choose == "A3")
                {
                    A3 a = new A3();
                }
                else if (choose == "A4")
                {
                    A4 a = new A4();
                }
                else if (choose == "A5")
                {
                    A5 a = new A5();
                }
                else if (choose == "A6")
                {
                    A6 a = new A6();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
