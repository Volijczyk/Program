using System;
using System.Collections.Generic;
using System.Text;

namespace squarefunction
{
    class SquareFun
    {
        double a, b, c;
        double delta, x1, x2, x0;
        int qsquares; 
        public SquareFun(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public SquareFun(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public SquareFun()
        {

        }

        public void GetData()
        {
            try
            {
                Console.WriteLine("Program oblicza pierwiastki równania kwadratowego\n Proszę podać współczynnik a: ");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Współczynnik a musi być różny od 0");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Proszę podać współczynnik b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Proszę podać współczynnik c: ");
                    c = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Współczynniki muszą być liczbami");
                Environment.Exit(0);
            }
           
        }
        public void Process()
        {
            delta = b * b - (4 * a * c);

            if (delta < 0) qsquares = 0;
            if (delta == 0) qsquares = 1;
            if (delta > 0) qsquares = 2;

            switch (qsquares)
            {
                case 1:
                    x0 = -b / (2 * 1);
                    break;
                case 2:
                    {
                        x1 = -b - (Math.Sqrt(delta)) / (2 * a);
                        x2 = -b + (Math.Sqrt(delta)) / (2 * a);
                        break;
                    }
            } 
        }
        public void Result()
        { 
            switch (qsquares)
            {
                case 0:
                    Console.WriteLine("Brak pierwiastków równania kwadratowego");
                    break;
                case 1:
                    Console.WriteLine($"Istnieje jeden pierwiastek równania kwadratowego wynoszący: {x0}");
                    break;
                case 2:
                    Console.WriteLine($"Istnieją dwa pierwiastki równania kwadratowego i wynoszą x1 = {x1} oraz x2 = {x2}");
                    break;
            }
        }










    }
}
