using System;
using System.Threading;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando ruta");

            // Iniciamos la variable
            var coche = new Coche();
            coche.Conducir();

            // Creamos un bucle preguntando el "¿Cuándo llegaremos?"
            while (!coche.finDestino)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            // Muestro el mensaje de finalizacion
            Console.WriteLine("Finalizando ruta");
            Console.ReadKey();
        }
    }
}
