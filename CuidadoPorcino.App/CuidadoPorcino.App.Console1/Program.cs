// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//

using System;
using CuidadoPorcino.App.Dominio;
using CuidadoPorcino.App.Persistencia;

namespace CuidadoPorcino.App.Console1
{
    class Program
    {
        private static INRepositorioCerdos _repoCerdos = new RepositorioCerdos(new Persistencia.appContext());
        static void Main(string[]args)
        {
            addCerdo();
        }
        private static void addCerdo()
        {
            var Cerdo = new Cerdos
            {
                Nombre = "porki2",
                Color = "pink2",
                Especie = "Mamifero2",
                Raza = "raza2"
            };

            _repoCerdos.addCerdo(Cerdo);
        }
    }
}
