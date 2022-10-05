using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    abstract class DecorateurPotion : Potion
    {
        protected Potion _potion;

        public DecorateurPotion(Potion potion)
        {
            this._potion = potion;
        }

        public override string getEffets()
        {
            if (this._potion != null)
            {
                return _potion.getEffets();
            }
            else
            {
                return "Erreur, aucune potion de base";
            }
        }
    }
}
