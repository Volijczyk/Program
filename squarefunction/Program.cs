using System;

namespace squarefunction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SquareFun s1 = new SquareFun();
            s1.GetData();
            s1.Process();
            s1.Result();

            Matrix m1 = new Matrix();
            int rozmiar = 10;
            double[,] tablica = new double[rozmiar, rozmiar];
            m1.Matriks(tablica,rozmiar);
            m1.DisplayMatrix(tablica, rozmiar);
            
            
        }
    }
}
