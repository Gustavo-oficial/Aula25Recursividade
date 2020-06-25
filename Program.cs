using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade seq = new Recursividade();

            Console.WriteLine("Digite: \n 1 para ver a sequencia Fibonacci \n 2 para ver Fatorial");
            string resposta = Console.ReadLine();
            Console.Clear();

            if(resposta == "1"){
                seq.MostrarFibonacci(4,6,10);
            }else{
                Console.WriteLine(seq.GerarFatorial(11));
            }
            
        }
    }
}
