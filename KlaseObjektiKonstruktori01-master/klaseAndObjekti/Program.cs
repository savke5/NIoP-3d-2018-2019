using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using klaseAndObjekti.Klase;

namespace klaseAndObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo ime = new Vozilo();


            bool josupisa = true;
            
            do
            {
                Console.WriteLine("Kojoj vrsti pripada:");
                ime.setVrsta(Console.ReadLine().ToString());
                Console.WriteLine("Koliko kotača ima vaše vozilo(ako nema niti jedan napšite 0)");
                ime.setBrojKotaca(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Može li vaše vozilo letjeti(true/false):");
                ime.setLeti(bool.Parse(Console.ReadLine()));
                Console.WriteLine("Može li vaše vozilo plivati(true/false):");
                ime.setPliva(bool.Parse(Console.ReadLine()));
                Console.WriteLine("Može li vaše vozilo voziti(true/false):");
                ime.setVozi(bool.Parse(Console.ReadLine()));
                Console.WriteLine("Koja je oznaka vašeg vozila:");
                ime.setOznaka(Console.ReadLine().ToString());

                Console.WriteLine(ime.ispis());

                Console.WriteLine("Želite li dodati još neko vozilo?(true/false)");
                josupisa = bool.Parse(Console.ReadLine());
            } while (josupisa == true);

           


            Console.ReadLine();
        }
    }

    
}
