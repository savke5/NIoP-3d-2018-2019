using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SavicKarloKlaseIObjekti.Klase;

namespace SavicKarloKlaseIObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozilo avijon = new Vozilo();
            avijon.setBrojKotaca(6);
            avijon.setLeti(true);
            avijon.setPliva(false);
            avijon.setVozi(true);
            avijon.setVrsta("Cessna");
            avijon.setOznaka("1312");
            Console.WriteLine("\n Vrsta:" + avijon.getVrsta() + "\n Oznaka: " + avijon.getOznaka() + "\n Leti:"

                + avijon.getLeti() + "\n Pliva" + avijon.getPliva() + "\n Vozi: " + avijon.getVozi() + "\n Broj kotaca: " + avijon.getbrojKotaca());

            Vozilo kamion = new Vozilo(8, false, false, true, "TAM", "RI1987AR");

            Console.WriteLine(kamion.ToString());



            Console.ReadLine();


           

        }
    }
}
