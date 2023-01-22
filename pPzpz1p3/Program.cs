using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pPzpz1p3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n, max = 1;
            Console.WriteLine("Unesite prvi broj: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            n = n1 < n2 ? n1 : n2;
            for (int i = n; i > 1; i++) 
            { 
                if (n1 % i == 0 && n2 % i == 0)
                {
                    max = i;
                    break;
                }
            }
            Console.WriteLine("Brojevi su dljevi "+max+".");
            Console.ReadKey();
        }
    }
}
