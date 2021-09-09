using System;
using System.Collections.Generic;

namespace CS_Lab
{
    internal class A6
    {
        public A6()
        {
            Menu();
        }

        private void Menu()
        {
            Console.WriteLine("*** A6 ***");
            Console.Write("How many student :> ");
            string nStr = Console.ReadLine();
            int n = 0;
            if (!int.TryParse(nStr, out n))
            {
                Console.WriteLine("Please enter valid input");
                return;
            }
            if (n > 0)
            {
                int i = 0;
                Dictionary<string, int> sum = new Dictionary<string, int>();
                sum.Add("S", 0);
                sum.Add("U", 0);
                sum.Add("A", 0);
                sum.Add("B", 0);
                sum.Add("C", 0);
                sum.Add("F", 0);
                while (i < n)
                {
                    Console.Write("Type of exam\t:");
                    string examType = Console.ReadLine();
                    Console.Write("Exam score\t:");
                    string examScore = Console.ReadLine();
                    int examScoreInt;
                    if (!int.TryParse(examScore, out examScoreInt))
                    {
                        Console.WriteLine("Please enter valid input");
                    }
                    else
                    {
                        string result = getExamResult(examType.ToUpper(), examScoreInt);
                        Console.WriteLine("Exam result\t:" + result + "\n");
                        if(result != "")
                        {
                            sum[result] = sum[result] + 1;
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid input");
                        }
                    }
                }
                Console.WriteLine("Proposal {0} students",(sum["S"] + sum["U"]));
                Console.WriteLine("S = {0}, U = {1}", sum["S"], sum["U"]);
                Console.WriteLine("Project {0} students", (sum["A"])+ sum["B"]+ sum["C"]+ sum["F"]);
                Console.WriteLine("A = {0}, B = {1}, C = {2}, F = {3}", sum["A"], sum["B"], sum["C"], sum["F"]);
            }
        }

        private string getExamResult(string examType, int examScoreInt)
        {
            string result="";
            if (examType == "P")
            {
                if (examScoreInt >= 60 && examScoreInt <= 100)
                {
                    result = "S";
                }
                else if (examScoreInt < 60 && examScoreInt >= 0)
                {
                    result = "U";
                }
            }
            else if (examType == "T")
            {
                if(examScoreInt>=0 && examScoreInt <= 100)
                {
                    if (examScoreInt >= 80)
                    {
                        result = "A";
                    }
                    else if (examScoreInt >= 60)
                    {
                        result = "B";
                    }
                    else if (examScoreInt >= 50)
                    {
                        result = "C";
                    }
                    else
                    {
                        result = "F";
                    }
                }
            }
            return result;
        }
    }
}