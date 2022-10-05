using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class GeleVerte : DecorateurPotion
    {
        public GeleVerte(Potion potion) : base(potion)
        {
        }

        public override string getEffets()
        {
            return $"({base.getEffets()}) x 2 PM";
        }
    }
}
