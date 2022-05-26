using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var arr = Console.ReadLine().Split(' ').Select(int.Parse);
            Stack<int> stack = new Stack<int>(arr);
            while (true)
            {
                string[] comm = Console.ReadLine().Split(' ');
                if (comm[0].ToLower() == "add")
                {
                    int n = int.Parse(comm[1]);
                    int n1 = int.Parse(comm[2]);
                    stack.Push(n);
                    stack.Push(n1);
                }
                else if (comm[0].ToLower() == "remove")
                {
                    int lenght = int.Parse(comm[1]);
                    if (lenght <= stack.Count - 1)
                    {
                        for (int i = 0; i < lenght; i++)
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {

                    }

                }
                else if (comm[0].ToLower() == "end")
                {
                    break;
                }

              
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
