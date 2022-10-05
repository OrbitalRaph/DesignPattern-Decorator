using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var potionExemple = new PotionSante();
            Console.WriteLine("Potion de base :");
            Console.WriteLine(potionExemple.getEffets());

            GeleVerte geleVerte = new GeleVerte(potionExemple);
            GeleRouge geleRouge = new GeleRouge(geleVerte);
            GeleBleue geleBleue = new GeleBleue(geleRouge);

            Console.WriteLine("Potion dans gelé verte, dans gelé rouge puis dans gelé bleue");
            Console.WriteLine(geleBleue.getEffets());
            geleBleue.Agiter();
            Console.WriteLine("On agite la gelé bleue :");
            Console.WriteLine(geleBleue.getEffets());
            Console.ReadLine();
        }
    }
}
