using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class GeleRouge : DecorateurPotion
    {
        public GeleRouge(Potion potion) : base(potion)
        {
        }

        public override string getEffets()
        {
            return $"({base.getEffets()}) + 10 PV";
        }
    }
}
