using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elos_Noc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) 
            {
                Carro c = new Carro();
                c.Placa = Console.ReadLine();
                c.Ano = int.Parse(Console.ReadLine());
                c.Modelo = Console.ReadLine();
                carros.Add(c);
            }                                                                                                        

            Console.WriteLine("Digita aí, vacilão, a placa do ser carro roubado na favela, vamo te falar tudo que sabemos sobre ele");
            string p = Console.ReadLine();
            for (int i = 0; i < N; i++)
            {
                if (carros[i].Placa == p) 
                {
                    Console.WriteLine(carros[i].Ano);
                    Console.WriteLine(carros[i].Modelo);
                }

                if (carros[i].Placa != p && i == N - 1)
                {
                    Console.WriteLine("Ta tentando me inganar vacilão? Esse carro nem ta aqui");                
                }              
                               
            }            

        }

    }
}
               