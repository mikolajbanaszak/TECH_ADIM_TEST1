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
            Lista lista = new Lista();
            Square kwadrat = new Square();
            Prostokat rectangle = new Prostokat();
            int id = 0;
            bool error;
            bool again;
            int g = 0; ;
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

                        kwadrat.zakoncz();
                        break;
                    case 2:

                        rectangle.zakoncz();
                        break;


                }
                Console.WriteLine("Chcesz zapisać do listy? jesli tak to 1");
                int b = int.Parse(Console.ReadLine());
                if (b == 1)
                {
                    id++;
                    if (g == 1)
                    {
                        lista.list1.Add(new Lista() { id = id, figura = "Kwadrat", obwod = kwadrat.Obwod, pole = kwadrat.Pole });
                    }
                    else
                    {
                        lista.list1.Add(new Lista() { id = id, figura = "prostokąt", obwod = rectangle.Obwod, pole = rectangle.Pole });
                    }

                }
                Console.WriteLine("Chcesz jeszcze raz? jesli tak to 1");
                int d = int.Parse(Console.ReadLine());
                if(d== 1)
                {
                    again = true;
                }

            } while (again);
            foreach(var f in lista.list1)
            {
                Console.WriteLine("Id: {0} Figura: {1} Obwód: {2} Pole: {3} ", f.id, f.figura, f.obwod, f.pole);
            }
            Console.ReadKey();

        }
    }
}
