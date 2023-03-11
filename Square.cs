using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTZC
{
    internal class Square : Figura
    {
        public Square(int a) {
            this.a = a;
        }

        public override int obObwod()
        {
            return a * 4;
        }

        public override int obPole()
        {
            return a * a;
        }

        private int a;
    }
}
