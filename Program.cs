using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseiObjekti12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            osoba.setIme("Ivan");
            osoba.setPrezime("Mažuranić");
            osoba.setVisina(180);
            osoba.setTezina(80);
            osoba.setGodinarođenja(1983);
            osoba.setSpol('M');

            Console.WriteLine(osoba.ToString());
            Osoba osoba2 = new Osoba("Vladimir", "Nazor", 180, 80, 1983, 'M');
            Console.WriteLine(osoba2.ToString());
            Console.ReadKey();
        }
    }
}
