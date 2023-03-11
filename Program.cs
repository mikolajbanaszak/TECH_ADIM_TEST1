using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTZC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            Figura figura = null;
            bool error;
            bool again;
            int g = 0; 

            do
            {
                again = false;
                do
                {
                    try
                    {
                        error = false;
                        Console.WriteLine("Chcesz obliczyć pole kwadratu 1 a prostokąta 2");
                        g = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        error = true;
                    }

                    if (g > 2 || g < 1)
                    {
                        error = true;
                    }

                } while (error);

                switch (g)
                {
                    case 1:
                        {
                            Console.WriteLine("Podaj  bok");
                            int a = int.Parse(Console.ReadLine());
                            figura = new Square(a);                   
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Podaj  bok");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Podaj 2  bok");
                            int b = int.Parse(Console.ReadLine());
                            figura = new Rectangle(a, b);
                        }
                        break;
                }

                Console.WriteLine("Pole: {0} Obwod: {1}", figura.obPole(), figura.obObwod());

                Console.WriteLine("Chcesz zapisać do listy? jesli tak to 1");
                if (int.Parse(Console.ReadLine()) == 1)
                {
                    screen.add(figura);
                }
                
                Console.WriteLine("Chcesz jeszcze raz? jesli tak to 1");
                if( int.Parse(Console.ReadLine()) == 1)
                {
                    again = true;
                };

            } while (again);

            screen.print();

            Console.ReadKey();

        }
    }
}
