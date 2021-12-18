using System;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static Decimal Tan(string w1, string w2)
        {
            int na = w1.Length;
            int nb = w2.Length;
            string max;
            string min;
            if (na > nb)
            {
                max = w1;
                min = w2;
            }
            else
            {
                max = w2;
                min = w1;

            }

            int nc = 0;
            for (int i = 0; i < Math.Max(na, nb); i++)
            {
                string sil1 = Convert.ToString(max[i]);
                for (int ii = 0; i < Math.Min(na, nb); i++)
                {
                    string sil2 = Convert.ToString(min[ii]);
                    if (sil1 == sil2)
                    {
                        nc++;
                    }
                }
            }


            Decimal bottom = na + nb - nc;
            Decimal top = nc;
            Decimal t = Decimal.Divide(top, bottom);
            
            return t;
        }        
        
        public static void Main(string[] args)
        {
            Console.WriteLine(Tan("pan","pancake"));
        }
    }
}