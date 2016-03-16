using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase2Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Uso de TryParse";
            string Dato;

            Console.WriteLine("Ingrese su edad");
            Dato = Console.ReadLine();

            int Numero;

            Numero = int.Parse(Dato);
        }
    }
}
