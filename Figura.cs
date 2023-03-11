using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTZC
{
    internal abstract class Figura
    {
        public abstract int Pole { get; set; }
        public abstract int Obwod { get; set; }

        public virtual void zakoncz() { }
        public virtual int obPole(int a)
        {
            return a;
        }
        public virtual int obObwod(int a)
        {
            return a;
        }

        public virtual int obObwod(int a , int b)
        {
            return a;
        }
        public virtual int obPole(int a , int b)
        {
            return a;
        }


    }
}
