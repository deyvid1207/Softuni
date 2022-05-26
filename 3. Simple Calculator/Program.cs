using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int sum = 0;
            int num  = 0;

            Stack<string> stack = new Stack<string>(arr.Reverse());
            string expr = string.Empty;
            num = int.Parse(stack.Pop());
            sum += num;
            while (true)
            {
                if (stack.Count == 0)
                {
                    break;
                }
                expr = stack.Pop();

                num = int.Parse(stack.Pop());
                
               
                
 
                
                
              
                if (expr == "-")
                {
                    sum-= num;
                   
                }
                else if (expr == "+")
                {

                    sum += num;
                   
                }

                if (stack.Count == 0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);

        }
    }
}

