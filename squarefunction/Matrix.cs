using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
namespace squarefunction
{
    class Matrix
    {
        
        public Matrix(double [,]Macierz, int n)
        {
            
        }
        public Matrix()
        {

        }
        public void Matriks(double[,] Macierz, int n = 10)
        {
            
            
            

            int i, j;
            Random rand = new Random();
            
            for ( i = 0; i < n; i++)
            {
                for (  j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Macierz[i, j] = Round(9*(rand.NextDouble()));
                    }
                    else
                    {
                        Macierz[i, j] = 0;
                    }
                }
            }
        }

        

        public void DisplayMatrix(double[,] Macierz, int n=10)
        {
            
             
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(Macierz[i,j] +" ");
                }
                Console.WriteLine();
            }
        }

    }
}
