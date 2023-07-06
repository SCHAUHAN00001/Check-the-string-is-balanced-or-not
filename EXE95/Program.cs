using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x  = Console.ReadLine();
            Console.WriteLine(IsBalanced(x));
            Console.ReadLine();

        }
        public static bool IsBalanced(string c)
        {
            Stack<char> Closingbr = new Stack<char>();
            Stack<char> Openingbr = new Stack<char>();

            foreach(char i in c)
            {
                if(i ==')'|| i =='}' || i==']' || i == '>')
                {
                    Closingbr.Push(i);
                }
            }
            for(int i= c.Length-1; i>=0; i--)
            {
                if (c[i] == '(' || c[i] == '{' || c[i] == '[' || c[i] == '<')
                {
                    Openingbr.Push(c[i]);
                }
            }
            if((Openingbr.Count + Closingbr.Count) %2 != 0)
            {
                return false;
            }
            while(Closingbr.Count != 0) 
            {
                char CurrentClosingbr = Closingbr.Pop();
                char CurrentOpeningbr = Openingbr.Pop();
                if (CurrentClosingbr == ')' && CurrentOpeningbr == '(' ||
                    CurrentClosingbr == '}' && CurrentOpeningbr == '{' ||
                    CurrentClosingbr == ']' && CurrentOpeningbr == '[' ||
                    CurrentClosingbr == '>' && CurrentOpeningbr == '<')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
    }
}
