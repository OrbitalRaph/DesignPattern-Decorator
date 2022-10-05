using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class GeleBleue : DecorateurPotion
    {
        private string effet;
        private string[] effetsPossible = {"+ 5 PV", "+ 15 PV", "x 2 PV", "+ 5 PM", "+ 10 PM", "+ 15 PM"};
        
        Random rnd = new Random();

        public GeleBleue(Potion potion) : base(potion)
        {
            effet = effetsPossible[rnd.Next(effetsPossible.Length)];
        }

        public override string getEffets()
        {
            return $"({base.getEffets()}) {effet}";
        }

        public void Agiter()
        {
            effet = effetsPossible[rnd.Next(effetsPossible.Length)];
        } 
    }
}
