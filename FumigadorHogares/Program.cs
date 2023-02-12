using System;

namespace FumigadorHogares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa para gestionar la fumigacion de hogares");
            Console.WriteLine("Se fumigaran ciertos hogares\n");

            int cantidadHogares = 0;
            bool cantidadHogaresCorrecta = false;

            do
            {
                try
                {
                    Console.Write("\nCuantas hogares quieres fumigar? ");
                    cantidadHogares = int.Parse(Console.ReadLine()!);

                    if (cantidadHogares <= 0)
                        Console.WriteLine("El dato ingresado debe ser entero positivo. Intenta nuevamente.");
                    else
                        cantidadHogaresCorrecta = true;
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no representa una cantidad. Intenta nuevamente.");
                    Console.WriteLine(elError.Message);
                }
            }
            while (cantidadHogaresCorrecta == false);

            Fabrica fabricaDeFumigadores = new Fabrica(cantidadHogares);

            int contadorFumigadores = 1;

            foreach (Fumigador unFumigador in fabricaDeFumigadores.GetLosFumigadores())
            {
                Console.WriteLine($"No. {contadorFumigadores}\n{unFumigador.ToString()}\n");
                contadorFumigadores++;
            }
        }

    }
}