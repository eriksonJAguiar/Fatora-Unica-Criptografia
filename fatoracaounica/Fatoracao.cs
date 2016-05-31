using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fatoracaounica
{
    class Fatoracao
    {
        public static List<int> fatorar(int n)
        {
            int f = 2;

            List<int> fatores = new List<int>();

            while(n > 1 && n >= (int)Math.Sqrt(n))
            {
                while((n%f)== 0)
                {
                    fatores.Add(f);
                    n = n / f;
                }
                f++;
            }

            return fatores;
        }
    }
}
