using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica5_2
    {
        static void Main(string[] args)
        {
            int num;
            bool rep = true;
            Console.WriteLine("Ingrese un número entero");
            do
            {
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Su numero es: " + num);
                    rep = false;
                }
                else
                {
                    Console.WriteLine("Dato Erroneo, Intentelo de nuevo");
                }
            } while (rep == true);
            Console.WriteLine("El número es " + tipo(num));
            Console.ReadKey();

        }

        static string tipo(int n)
        {
            string tipo;
            if (n > 0)
            {
                tipo = "POSITIVO";
            }
            else
            {
                if (n < 0)
                {
                    tipo = "NEGATIVO";
                }
                else
                {
                    tipo = "CERO";
                }
            }
            return tipo;
        }
    }
}
