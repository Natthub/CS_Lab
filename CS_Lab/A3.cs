using System;

namespace CS_Lab
{
    internal class A3
    {
        public A3()
        {
            Menu();
        }

        private void Menu()
        {
            Console.WriteLine("*** A3 ***");
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
                float[] data = new float[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("input data[" + (i + 1) + "] :> ");
                    string dataStr = Console.ReadLine();
                    if (!float.TryParse(dataStr, out data[i]))
                    {
                        Console.WriteLine("Please enter valid input");
                        return;
                    }
                }

                difMaxMin(data);
            }
            
        }

        private void difMaxMin(float[] data)
        {
            float max=data[0];
            float min = data[0];

            for (int i=1 ; i<data.Length ; i++) {
                if (max < data[i]) max = data[i];
                if (min > data[i]) min = data[i];
            }

            Console.WriteLine("\nMax is " + max);
            Console.WriteLine("Min is " + min);
            Console.WriteLine("Diff is " + (max - min));
        }
    }
}