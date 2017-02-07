using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DieselBil> ListDiesel = new List<DieselBil>();
            ListDiesel.Add(new DieselBil("Audi", "CW23213", 42000, 2016, 10, false ));
            ListDiesel.Add(new DieselBil("BMW", "JW65342", 30000, 2004, 14, false));
            ListDiesel.Add(new DieselBil("VW", "CW32997", 400000, 2003, 8, true));
            ListDiesel.Add(new DieselBil("Tesla", "ORALESAHBI", 16000, 2016, 15,true ));
            ListDiesel.Add(new DieselBil("VW", "RING", 10000, 2002, 22, true));
            foreach (DieselBil dieselbil in ListDiesel)
            { Console.WriteLine($"Registreringsnummer: {dieselbil.RegistreringsNr}, Halvårlig ejerafgift: {dieselbil.HalvÅrligEjerafgift()}");
            }



            Console.ReadLine();

        }
    }
}
