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
            return sum;
        }



    }
}
