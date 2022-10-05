using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class PotionSante : Potion
    {
        public override string getEffets()
        {
            return "Soigne de 50 PV";
        }
    }
}
