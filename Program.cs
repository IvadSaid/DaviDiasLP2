using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos triângulos você quer analisar: ");
            int qtd = int.Parse(Console.ReadLine());
            double perim = 0;
            double x;
            int id = 0;
            Triangulo tri = new Triangulo(3, 6, 9);
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o id do triângulo:");
                tri.id = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o tamanho do lado 1:");
                tri.Lado1 = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o tamanho do lado 2:");
                tri.Lado2 = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o tamanho do lado 3:");
                tri.Lado3 = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o código da cor do triângulo:");
                tri.Cor = double.Parse(Console.ReadLine());
                
                x = tri.Lado1 + tri.Lado2 + tri.Lado3;
                if (x > perim)
                {
                    perim = x;
                    id = tri.id;
                }
                
            }
            
            Console.WriteLine("O maior triangulo é o de ID número: {0}, e perímetro {1}.", id, perimetro);


        }
    }
}
