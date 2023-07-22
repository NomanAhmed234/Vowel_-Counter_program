using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5q3
{
    class Count
    {
    public int Countvowel(string name)
    {
        int vowelCount = 0;
        foreach (char ch in name)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }

    }
}
