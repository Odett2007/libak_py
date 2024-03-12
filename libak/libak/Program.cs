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

        static double Atlagolas(int[] l)
        {
            int atlag = 0;
            int db = 0;
            for (int i = 0; i < l.Length; i++)
            {
                if (l[i] <= 3)
                {
                    atlag += l[i];
                    db++;
                }
            }
            double osszeg = (double)atlag / db;
            return osszeg;
        }
        static void Kiir_atlag(double i)
        {
            Console.WriteLine($"A róka libáinak súlyának átlaga: {i}kg.");
        }

        static bool Elofordult_e(int[] l)
        {
            bool elofordult = false;
            foreach (int liba in l)
            {
                if (liba >= 3)
                {
                    elofordult = true;
                    break;
                }
            }
            return elofordult;
        }
        static void Kiir_Elofordult_e(bool e)
        {
            if (e==true)
            {
                Console.WriteLine("Előfordult hogy a róka legalább három kilós libát lopott");
            }
            else
            {
                Console.WriteLine("Nem fordult elő hogy a róka legalább három kilós libát lopott");
            }
        }
        static void Main(string[] args)
        {

            /*
             * A róka libát lop a faluból. A libák súlyát – pontosabban tömegét – listában adjuk meg. A farkas a dűlőútnál várja a rókát, és a három kilónál nagyobb libákat elveszi – a piciket nagylel�kűen otthagyja a rókának.
                libak = [1,5,2,3,4]

                a. Hány kiló libát ehet meg a róka?
                b. Átlagosan hány kilósak a rókának maradt libák?
                c1. Előfordult-e olyan, hogy a róka legalább háromkilós libát lopott?
                c2. Előfordult-e olyan, hogy a róka kisebb libát hozott, mint az előző napon?
                d. Hányadik napon sikerült a rókának először legalább háromkilós libát lopnia?
                e. Melyik a róka első legalább háromkilós libája?
                f. Hány libát tarthat meg a róka?
                g. Mekkora a legkisebb liba, amit a farkas elvesz a rókától?
             */


            int[] libak = { 1, 5, 2, 3, 4};
            Kiir(libak, "libák súlyai: ");


            // a. Hány kiló libát ehet meg a róka?
            int hany_kilo_libat_ehet_meg_a_roka = Osszegez(libak);
            Console.WriteLine("");
            Kiir_eredmenyek(hany_kilo_libat_ehet_meg_a_roka);

            //b. Átlagosan hány kilósak a rókának maradt libák?
            double atlag_roka_libainak_kiloi = Atlagolas(libak);
            Console.WriteLine("");
            Kiir_atlag(atlag_roka_libainak_kiloi);

            // c1. Előfordult-e olyan, hogy a róka legalább háromkilós libát lopott?
            bool elofordult_e_haromnal_tobb_kilos_liba = Elofordult_e(libak);
            Console.WriteLine("");
            Kiir_Elofordult_e(elofordult_e_haromnal_tobb_kilos_liba);


            Console.ReadKey();
        }
    }
}
