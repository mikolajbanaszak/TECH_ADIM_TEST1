using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTZC
{
    internal class Square : Figura
    {
        public override int Pole { get; set; }
        public  override int Obwod { get; set; }

        public override void zakoncz()
        {
            Console.WriteLine("Podaj  bok");
            int a = int.Parse(Console.ReadLine());
            Pole = obPole(a);
            Obwod = obObwod(a);
            Console.WriteLine("Pole: {0} Obwod: {1}", Pole, Obwod);

        }
        public override int obObwod(int a)
        {
            return a * 4;
        }

        public override int obPole(int a)
        {
            return a * a;
        }
    }
}
