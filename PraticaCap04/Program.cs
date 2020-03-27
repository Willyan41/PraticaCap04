using System;
using System.Globalization;

namespace PraticaCap04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("O Valor da Circunferencia {0}", circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Valor do Volume {0}", volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: {0}", Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
