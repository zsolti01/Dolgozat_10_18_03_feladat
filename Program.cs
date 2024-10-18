using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_10_18_03_feladat
{
    internal class Program
    {
        static void diakpontszam()
        {
            // 3. feladat

            var diak = new List<string>(5);
            var pont = new List<int>(5);

            string nev = "";
            int pontok = 0;

            int szamlalo = 1;
            int osszeg = 0;

            bool elegtelen = false;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Add meg a(z) {0}. diák nevét: ", szamlalo);
                szamlalo++;
                nev = Console.ReadLine();
                Console.WriteLine("Add meg a diák pontszámát: ");
                pontok = Convert.ToInt32(Console.ReadLine());
                diak.Add(nev);
                pont.Add(pontok);
                osszeg = osszeg + pontok;
                if (pontok < 50) elegtelen = true;
            }
            float atlag = osszeg / 5;
            int nagy = 0;
            int kicsi = 0;

            for (int i = 0; i < 5; i++)
            {
                if (pont[i] > pont[0]) nagy = i + 1;
            }

            for (int i = 0; i < 5; i++)
            {
                if (pont[i] < pont[0]) kicsi = i + 1;
            }

            Console.WriteLine("A diákok pontszámainak átlaga: {0}", atlag);
            Console.WriteLine("A legmagasabb pontszám: {0}", nagy);
            Console.WriteLine("A legalacsonyabb pontszám: {0}", kicsi);
            if (elegtelen == true) Console.WriteLine("Van elégtelen pontszám!");
            else Console.WriteLine("Nem volt elégtelen pontszám!");
        }
        static void Main(string[] args)
        {
            diakpontszam();
        }
    }
}
