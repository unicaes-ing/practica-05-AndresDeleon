using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica5_3
    {
        static void Main(string[] args)
        {
            int num;
            bool rep = true;
            Console.WriteLine("Ingrese un número entero");
            do
            {
                if (int.TryParse(Console.ReadLine(), out num) && num >= 0)
                {
                    Console.WriteLine("Factorial: " + num + "!");
                    rep = false;
                }
                else
                {
                    Console.WriteLine("Dato Erroneo, Intentelo de nuevo");
                }
            } while (rep == true);
            Console.WriteLine("Su factorial es: " + factor(num).ToString("N2"));
            Console.ReadKey();
        }

        static int factor(int n)
        {
            int q = 1;
            for (int i = 1; i <= n; i++)
            {
                q = i * q;
            }
            return q;
        }
    }
}
