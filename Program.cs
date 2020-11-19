using System;

namespace idade_de_um_artista_famoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos tem o artista Carlos Alberto de Nóbrega?");
            int resposta = int.Parse(Console.ReadLine());
            while(resposta!=84){
                Console.WriteLine("Tente novamente!");
                Console.WriteLine("Quantos anos tem o artista Carlos Alberto de Nóbrega?");
                resposta = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Parabéns, você acertou!");
            
        }
    }
}
