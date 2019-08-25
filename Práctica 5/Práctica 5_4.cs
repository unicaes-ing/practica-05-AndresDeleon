using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_5_4
    {
        public static string num1, num2, num3, num4;
        static void Main(string[] args)
        {
            Console.WriteLine("Participante Teléfono #1");
            num1 = Console.ReadLine();
            Console.WriteLine("Participante Teléfono #2");
            num2 = Console.ReadLine();
            Console.WriteLine("Participante Teléfono #3");
            num3 = Console.ReadLine();
            Console.WriteLine("Participante Teléfono #4");
            num4 = Console.ReadLine();
            Console.WriteLine("El número ganador es... el participante #" + aleTel(num1, num2, num3, num4));
            Console.ReadKey();
        }

        static int aleTel(string n1, string n2, string n3, string n4)
        {
            Random ale = new Random();
            int q = ale.Next(1, 5);
            return q;
        }
    }
}
