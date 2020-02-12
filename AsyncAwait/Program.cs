using System;
using System.Threading;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando ruta");

            var coche = new Coche();
            coche.Conducir();

            while (!coche.finDestino)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Finalizando ruta");
            Console.ReadKey();
        }
    }
}
