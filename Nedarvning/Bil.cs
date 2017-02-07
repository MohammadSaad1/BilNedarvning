using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    public abstract class Bil
    {
        public int BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }
        public string Mærke { get; set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; set; }





        public abstract double RegistreringsAfgift();
        
      /*      if (KøbsÅr <= 2014)
            {
                double RegistreringsAfgift = ((1.05 * 80500) + (1.80 * (BilPrisExAfgift - 80500)));
                return RegistreringsAfgift;
            }

            else if (KøbsÅr >= 2015)
            {
                double RegistreringsAfgift = ((1.05 * 80500) + (1.80 * (BilPrisExAfgift - 81700)));
                return RegistreringsAfgift;
            }
            else
            {
                return 0;
            }
        }
        */
       

        public double TotalPris()
        {
            return BilPrisExAfgift + RegistreringsAfgift();
        }

        public virtual int HalvÅrligEjerafgift()
        {
            return 1000;
        }

        public Bil (string Mærke,string RegistreringsNr, int PrisExAfgift, int KøbsÅr, int KmPrLiter)
        {
            this.Mærke = Mærke;
            this.BilPrisExAfgift = BilPrisExAfgift;
            this.KøbsÅr = KøbsÅr;
            this.KmPrLiter = KmPrLiter;
            this.RegistreringsNr = RegistreringsNr;
        }

        


    }
}
