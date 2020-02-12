using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Coche
    {
        public bool finDestino { get; set; }

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
