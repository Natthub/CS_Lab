using System;
using System.Collections.Generic;

namespace CS_Lab
{
    internal class A4
    {
        public A4()
        {
            Menu();
        }

        private void Menu()
        {
            Console.WriteLine("*** A4 ***");
            List<int> data = new List<int>();
            int count = 1;
            while (true)
            {
                Console.Write("input data[" + count + "] :> ");
                string inputStr = Console.ReadLine();
                int inputInt;
                if (!int.TryParse(inputStr, out inputInt))
                {
                    Console.WriteLine("Please enter valid input");
                }
                else
                {
                    if(inputInt == 0)
                    {
                        break;
                    }
                    else if (inputInt < 0 || inputInt > 9)
                    {
                        Console.WriteLine("Please enter valid input");
                    }
                    else
                    {
                        data.Add(inputInt);
                        count++;
                    }
                }
            }

            showOutput(data);
        }

        private void showOutput(List<int> data)
        {
            int[] score = new int[10];
            int headScore = 0;
            int headNumber = 0;
            int assistantScore = 0;
            int assistantNumber = 0;

            Console.WriteLine("data from villager : ");
            foreach(int d in data)
            {
                Console.Write(d+" ");
                score[d] += 1;
            }

            Console.WriteLine("\nscore of each applycant : ");
            for(int i=0;i<score.Length;i++)
            {
                Console.Write(score[i] + " ");

                if(headScore < score[i])
                {
                    headScore = score[i];
                    headNumber = i;
                }
            }

            for (int i = 0; i < score.Length; i++)
            {
                if (assistantScore < score[i] && score[i] < headScore)
                {
                    assistantScore = score[i];
                    assistantNumber = i;
                }
            }

            Console.Write("\nHead is number " + headNumber + "\t");
            Console.WriteLine("vote_score is " + headScore);
            Console.Write("Assistant is number " + assistantNumber + "\t");
            Console.WriteLine("vote_score is " + assistantScore);

        }


    }
}