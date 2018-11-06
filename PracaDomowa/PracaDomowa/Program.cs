using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_domowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int podajCyfre1, podajCyfre2;

            Console.Write("Podaj pierwsza cyfre: ");
            podajCyfre1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj druga cyfre: ");
            podajCyfre2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Iloczyn podanych cyfr to: {podajCyfre1 * podajCyfre2}");

            if (podajCyfre1 + podajCyfre2 > 15) Console.WriteLine($"Suma cyfr to: {podajCyfre1 + podajCyfre2}");
            else
            {
                Console.WriteLine("Suma cyfr mniejsza od 15");
            }

            Console.ReadKey();

        }
    }
}

