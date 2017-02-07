using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning
{
    public class DieselBil : Bil
    {
        public bool PartikelFilter { get; private set; }

        public DieselBil(string mærke, string registringsnr, int prisexafgift, int købsår, int kmprliter, bool partikelfilter) : base (mærke, registringsnr, prisexafgift, købsår, kmprliter)
        {
          
            this.PartikelFilter = partikelfilter;
        }

        public DieselBil(string mærke, string registringsnr, int prisexafgift, int købsår, int kmprliter) : this(mærke, registringsnr, prisexafgift, købsår, kmprliter, true)
        {
           
        }


        public override int HalvÅrligEjerafgift()
        {
            int sum = 0;

            if (PartikelFilter == false)
            {
                return sum += 500;
            }

            if (KmPrLiter <15)
            {
                return 2000;
            }

            else if ((KmPrLiter ==25) && (KmPrLiter ==15))
            {
                return 1000;
            }

            else if (KmPrLiter >25 )
            {
                return 350;
            }

            return sum;
        }

        public override double RegistreringsAfgift()
        {
            if (KøbsÅr <= 2014)
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
    }
    }
}
