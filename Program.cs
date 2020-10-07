using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int distancia;
            int tempo;
            
            Console.Write("Distancia percorrida (m): ");
            distancia = int.Parse(Console.ReadLine());

            Console.Write("Tempo gasto (s): ");
            tempo = int.Parse(Console.ReadLine());

            int velocidade;

            velocidade = (distancia/tempo);

            Console.WriteLine();

            Console.WriteLine($"Velocidade média: {velocidade} m/s");

            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
