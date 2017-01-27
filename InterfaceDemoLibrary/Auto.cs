using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceDemoLibrary.Sub;

namespace InterfaceDemoLibrary
{
    class Auto: IRijden, IRijden2
    {

        void IRijden.Rijden()
        {
            
        }

        void IRijden2.Rijden()
        {
            
        }

        public bool Gereden()
        {
            return false;
        }
    }
}
