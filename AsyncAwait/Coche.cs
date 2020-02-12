using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Coche
    {
        // Use el modificador async para especificar que un método es asincrónico.
        // Este método o una expresión, hace referencia al mismo como un método asincrónico.

        // Para determinar el status de incio fin empleo una flag.
        public bool finDestino { get; set; }

        // Necesario declarar que es un método asincrónico
        public async void Conducir()
        {
            finDestino = false;
            Console.WriteLine("Empezando a conducir");

            await TiempoOperacion();

            Console.WriteLine("\nA llegado a su destino");

            finDestino = true;
        }

        private Task TiempoOperacion()
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Conduciendo");
                Thread.Sleep(3000);
            });
        }
    }
}
