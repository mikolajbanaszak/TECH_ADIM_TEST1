using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTZC
{
    internal class Prostokat : Figura
    {
        public override int Pole { get; set; }
        public override int Obwod { get; set; }

        public override void zakoncz()
        {
            Console.WriteLine("Podaj  bok");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 2  bok");
            int b= int.Parse(Console.ReadLine());
            Pole = obPole(a , b);
            Obwod = obObwod(a , b);
            Console.WriteLine("Pole: {0} Obwod: {1}", Pole, Obwod);

        }
        public override int obObwod(int a , int b)
        {
            return (a * 2)+(b*2);
        }

        public override int obPole(int a , int b)
        {
            return a * b;
        }
    }
}
