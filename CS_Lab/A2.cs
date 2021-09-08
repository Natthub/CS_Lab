using System;

namespace CS_Lab
{
    internal class A2
    {
        public A2()
        {
            Menu();
        }
        private void Menu()
        {
            Console.WriteLine("*** A2 ***");
            Console.Write("How many number :> ");
            string nStr = Console.ReadLine();
            int n;
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

                Console.Write("input data to search :> ");
                string searchStr = Console.ReadLine();
                float search;
                if (!float.TryParse(searchStr, out search))
                {
                    Console.WriteLine("Please enter valid input");
                    return;
                }

                sumSearch(data, search);
            
            }
            

        }

        private void sumSearch(float[] data, float search)
        {
            Console.WriteLine("index");
            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine("\n");
            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + "\t");
            }
            
            float sum = 0.0f;
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i] == search)
                {
                    sum += search;
                }
            }

            Console.WriteLine("\n\ndata\tsum");
            Console.WriteLine(search + "\t" + sum);
        }
    }
}