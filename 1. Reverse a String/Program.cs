using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
           
            Stack<char> stack = new Stack<char>();
            foreach (char ch in str)
            {
                stack.Push(ch);

            }
            Console.Write(string.Join("", stack));

        }
    }
}
