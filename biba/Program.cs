using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biba
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] Lox(int N)
        {
            int[] result = new int[N + 1];
            for (int k = 0; k <= N; k++)
            {
                result[k] = 1;
                for (int i = 1; i <= k; i++)
                {
                    result[k] *= N - (k - i);
                    result[k] /= i;
                }
            }
            return result;
        }
    }
}
