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
                result = Math.Min(result, modify(text.Substring(0, i), text.Substring(i)));
            }
            return result;
        }

        private int modify(string a, string b)
        {
            char[] a1 = a.ToCharArray();
            char[] b1 = b.ToCharArray();
            int[,] transformationMatrix = new int[a.Length + 1, b.Length + 1];

            for (int i = 0; i < a.Length + 1; i++)
                transformationMatrix[i, 0] = i;
            for (int j = 0; j < b.Length + 1; j++)
                transformationMatrix[0, j] = j;

            for (int i = 1; i < a.Length + 1; i++)
                for (int j = 1; j < b.Length + 1; j++)
                {
                    if (a1[i - 1] == b1[j - 1])
                    {
                        transformationMatrix[i, j] = transformationMatrix[i - 1, j - 1];
                    }
                    else
                    {
                        transformationMatrix[i, j] = Math.Min(transformationMatrix[i - 1, j], 
                            Math.Min(transformationMatrix[i, j - 1], transformationMatrix[i - 1, j - 1])) + 1;
                    }
                }
            string rez = "";
            for (int i = 0; i < a.Length + 1; i++)
            {
                for (int j = 0; j < b.Length + 1; j++)
                {
                    rez += " " + transformationMatrix[i, j];
                }
                rez += "\n";
            }
            Console.WriteLine(rez);
            return transformationMatrix[a1.Length, b1.Length];
        }
    }
}
