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


        public override double RegistreringsAfgift()
        {
            return base.RegistreringsAfgift();
        }

    }
}
