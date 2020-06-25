using System;

namespace Aula_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();
            // rec.GerarSequenciaDeFibonacci(1, 0, 10);
            
            Console.WriteLine(rec.GerarFatorial(10));
        }
    }
}
