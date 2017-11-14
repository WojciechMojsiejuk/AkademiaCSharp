using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Silnik silnik = new Silnik("product", 2009);
            Samochod mojSamochod = new Samochod("Audi","S6",2010,"Czerwony",2.1,silnik);
            mojSamochod.Jedz();
            mojSamochod.silnikSamochodu = silnik;
            Console.WriteLine(mojSamochod.silnikSamochodu.producent);
            Console.ReadKey();
        }
    }
}
