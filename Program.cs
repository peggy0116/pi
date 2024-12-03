using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1112410016/嚴珮瑜
            Console.WriteLine("輸入圓半徑:");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("輸入圓週率的精度:( 4<=n<=15)");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("圓周率:{0:g}",CountPi(n) );
            if (n < 4) return;if (n > 15) return;
            Console.WriteLine("圓周長:{0:g}", GetCircumference(r, n));
            Console.WriteLine("園面積:{0:g}", GetCircleArea(r, n));
            Console.Read();
        }
        static double CountPi(int n)
        {
            if (n < 4) return-1;if (n > 15) return-1;
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result += Math.Pow(-1, i) / (2 * i + 1);
            }
            return result * 4;
        }
        static double GetCircumference(double r,int n)
        {
            return CountPi(n) * r;
        }
        static double GetCircleArea(double r,int n)
        {
            return CountPi(n) * r*r;
        }
    }
}
