using System.Runtime.CompilerServices;

namespace lab_5q3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Count c = new Count();
            c.Countvowel(name);
           
            Console.WriteLine("Your name contains {0} vowels.",c.Countvowel(name));
        }
    }
 }
