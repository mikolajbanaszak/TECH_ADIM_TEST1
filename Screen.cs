using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTZC
{
    internal class Screen
    {
         private List<Figura> FiguraList = new List<Figura>();

        public void add( Figura figura )
        {
            FiguraList.Add( figura );
        }

         public void print()
        {
            foreach(Figura f in FiguraList)
            {
                Console.WriteLine("Id: Clasa: {0} Obwód: {1} Pole: {2} ", f.GetType().ToString(), f.obObwod(), f.obPole());
            }
        }
    }
}
