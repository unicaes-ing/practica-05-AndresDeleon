using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_5_5
    {
        static void Main(string[] args)
        {
            decimal precio, por = 0;
            bool rep = false;
            Console.Write("Precio del Producto: $");
            do
            {
                if (decimal.TryParse(Console.ReadLine(), out precio) && precio >= 0)
                {
                    Console.Write("Descuento del Producto (%): ");
                    do
                    {
                        rep = false;
                        if (decimal.TryParse(Console.ReadLine(), out por) && por >= 0 && por <= 100)
                        {
                            Console.WriteLine("Precio a Pagar: " + descuento(precio, por).ToString("C2"));
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("El valor tenía que ser un entero entre 0 y 100 :(");
                            rep = true;
                        }
                    } while (rep == true);
                }
                else
                {
                    Console.WriteLine("El valor tenía que ser un decimal positivo :(");
                    rep = true;
                }

            } while (rep == true);
        }


        static decimal descuento(decimal p, decimal pc)
        {
            decimal desc = 0;
            pc = pc / 100;
            desc = p * pc;
            p = p - desc;
            return p;
        }
    }
}
