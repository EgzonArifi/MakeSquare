using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareString
{
    public class RepeatString
    {
        public int minimalModify(String text)
        {
            int result = text.Length;
            for (int i = 0; i < result; i++)
            {
                result = Math.Min(result, dis(text.Substring(0, i), text.Substring(i)));
            }
            return result;
        }

        private int dis(String a, String b)
        {
            return 0;
        }
    }
}
