using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTZC
{
    internal class Rectangle : Figura
    {
        private int a;
        private int b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public override int obObwod()
        {
            return (a * 2)+(b*2);
        }

        public override int obPole()
        {
            return a * b;
        }
    }
}
