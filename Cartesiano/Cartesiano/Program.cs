using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ponto> pontos = new List<Ponto>();
            double somax = 0, somay = 0;
            int n = int.Parse(Console.ReadLine());
            double x;
            double y;
            for (int i = 0; i < n; i++) 
            {
                x = double.Parse(Console.ReadLine());
                y = double.Parse(Console.ReadLine());
                Ponto p = new Ponto(x,y);
                pontos.Add(p);
                somax = somax + pontos[i].X;
                somay = somay + pontos[i].Y;                
            }

            Ponto medio = new Ponto(somay / n, somax / n);
            Console.WriteLine(" {0}, {1}.", medio.X, medio.Y);
            double peri = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == n-1)
                {
                    Console.WriteLine(peri += Ponto.Distancia(pontos[i], pontos[0]));
                }
                else 
                    Console.WriteLine(Ponto.Distancia(pontos[i], pontos[i + 1]));
            }
            Console.WriteLine(peri);
        }
    }
}
