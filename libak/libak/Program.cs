using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liba
{
    class Program
    {
        static void Kiir(int[] t, string cim)
        {
            Console.WriteLine(cim);
            foreach (int szam in t)
            {
                Console.Write($"{szam}, ");
            }
        }
        static int Osszegez(int[] t)
        {
            int osszeg = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] <= 3)
                {
                    osszeg += t[i];
                }
            }
            return osszeg;
        }
        static void Kiir_eredmenyek(int roka_liba_suly)
        {
            Console.WriteLine($"A róka libáinak súlya: {roka_liba_suly}kg.");
        }
        static void Main(string[] args)
        {
            int[] libak = { 1, 5, 2, 3, 4 };
            Kiir(libak, "libák súlyai");
            int hany_kilo_libat_ehet_meg_a_roka = Osszegez(libak);
            Kiir_eredmenyek(hany_kilo_libat_ehet_meg_a_roka);
            Console.ReadKey();
        }
    }
}
