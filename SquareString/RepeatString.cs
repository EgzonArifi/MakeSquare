using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareString
{
    public class RepeatString
    {
        public int minimalModify(string text)
        {
            int result = text.Length;
            for (int i = 0; i < text.Length; i++)
            {
                result = Math.Min(result, dis(text.Substring(0, i), text.Substring(i)));
            }
            return result;
        }

        private int dis(string a, string b)
        {
            char[] a1 = a.ToCharArray();
            char[] b1 = b.ToCharArray();
            int[,] leven = new int[a.Length + 1, b.Length + 1];

            for (int i = 0; i < a.Length + 1; i++)
                leven[i, 0] = i;
            for (int j = 0; j < b.Length + 1; j++)
                leven[0, j] = j;

            for (int i = 1; i < a.Length + 1; i++)
                for (int j = 1; j < b.Length + 1; j++)
                {
                    if (a1[i - 1] == b1[j - 1])
                    {
                        leven[i, j] = leven[i - 1, j - 1];
                    }
                    else
                    {
                        leven[i, j] = Math.Min(leven[i - 1, j], Math.Min(leven[i, j - 1], leven[i - 1, j - 1])) + 1;
                    }
                }
            string rez = "";
            for (int i = 0; i < a.Length + 1; i++)
            {
                for (int j = 0; j < b.Length + 1; j++)
                {
                    rez += " " + leven[i, j];
                }
                rez += "\n";
            }
            Console.WriteLine(rez);
            return leven[a1.Length, b1.Length];
        }
    }
}
