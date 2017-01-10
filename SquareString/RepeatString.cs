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

        public int myMinimalModify(string text)
        {
            string s1a = text.Substring(0, (text.Length / 2));
            string s1b = text.Substring(text.Length / 2);
            char[] firstHalf = s1a.ToCharArray();
            char[] secondHalf = s1b.ToCharArray();

            int[,] evaluationM = new int[s1a.Length + 1, s1b.Length + 1];

            for (int i = 0; i < s1a.Length + 1; i++)
                evaluationM[i, 0] = i;
            for (int j = 0; j < s1b.Length + 1; j++)
                evaluationM[0, j] = j;

            for (int i = 1; i < s1a.Length + 1; i++)
                for (int j = 1; j < s1b.Length + 1; j++)
                {
                    if (firstHalf[i - 1] == secondHalf[j - 1])
                    {
                        evaluationM[i, j] = evaluationM[i - 1, j - 1];
                    }
                    else
                    {
                        evaluationM[i, j] = Math.Min(evaluationM[i - 1, j],
                            Math.Min(evaluationM[i, j - 1], evaluationM[i - 1, j - 1])) + 1;
                    }
                }

            return evaluationM[firstHalf.Length, secondHalf.Length];
        }
        private int modify(string a, string b)
        {
            char[] a1 = a.ToCharArray();
            char[] b1 = b.ToCharArray();
            int[,] evaluationM = new int[a.Length + 1, b.Length + 1];

            for (int i = 0; i < a.Length + 1; i++)
                evaluationM[i, 0] = i;
            for (int j = 0; j < b.Length + 1; j++)
                evaluationM[0, j] = j;

            for (int i = 1; i < a.Length + 1; i++)
                for (int j = 1; j < b.Length + 1; j++)
                {
                    if (a1[i - 1] == b1[j - 1])
                    {
                        evaluationM[i, j] = evaluationM[i - 1, j - 1];
                    }
                    else
                    {
                        evaluationM[i, j] = Math.Min(evaluationM[i - 1, j], 
                            Math.Min(evaluationM[i, j - 1], evaluationM[i - 1, j - 1])) + 1;
                    }
                }

            string rez = "";
            for (int i = 0; i < a.Length + 1; i++)
            {
                for (int j = 0; j < b.Length + 1; j++)
                {
                    rez += " " + evaluationM[i, j];
                }
                rez += "\n";
            }
            Console.WriteLine(rez);
            return evaluationM[a1.Length, b1.Length];
        }
    }
}
