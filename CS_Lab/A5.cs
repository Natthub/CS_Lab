using System;

namespace CS_Lab
{
    internal class A5
    {
        public A5()
        {
            Menu();
        }

        private void Menu()
        {
            Console.WriteLine("*** A5 ***");
            Console.Write("How many number :> ");
            string nStr = Console.ReadLine();
            int n = 0;
            if (!int.TryParse(nStr, out n))
            {
                Console.WriteLine("Please enter valid input");
                return;
            }
            if (n > 0)
            {
                int[] data1 = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("input data[" + (i + 1) + "] :> ");
                    string dataStr = Console.ReadLine();
                    if (!int.TryParse(dataStr, out data1[i]))
                    {
                        Console.WriteLine("Please enter valid input");
                        return;
                    }
                }

                Console.WriteLine("\n" + "----------------");

                int[] data2 = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("input data[" + (i + 1) + "] :> ");
                    string dataStr = Console.ReadLine();
                    if (!int.TryParse(dataStr, out data2[i]))
                    {
                        Console.WriteLine("Please enter valid input");
                        return;
                    }
                }

                sumDiffSqr(data1,data2);
            }
        }

        private void sumDiffSqr(int[] data1, int[] data2)
        {
            Console.WriteLine("\n");
            double sum = 0;
            for(int i = 0; i < data1.Length; i++)
            {
                double diffSquare = Math.Pow(data1[i]-data2[i],2);
                sum += diffSquare;
                Console.WriteLine("data1[" + data1[i] + "] - data2[" + data2[i] + "] = " + diffSquare);
            }
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Sum of Diff-Square is " + sum);
        }
    }
}