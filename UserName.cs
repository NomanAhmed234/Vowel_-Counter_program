using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5q3
{
    internal class UserName
    {
        public string name;
        public void input()
        {
            Console.WriteLine("Enter your name ");
            name = Console.ReadLine();
        }
        public int vowel()
        {
            int count = 0, i = 0;
            while (name != null)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
