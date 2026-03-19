 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crear computadoras
            Computadora gamaBaja = new Computadora("PC Gama Baja");
            gamaBaja.AgregarHijo(new Pieza("Procesador Ryzen 3", 1800));
            gamaBaja.AgregarHijo(new Pieza("Tarjeta Madre A320", 1200));
            gamaBaja.AgregarHijo(new Pieza("RAM 8GB", 700));
            gamaBaja.AgregarHijo(new Pieza("SSD 240GB", 600));
            gamaBaja.AgregarHijo(new Pieza("Fuente de Poder 500W", 800));
            gamaBaja.AgregarHijo(new Pieza("Gabinete Básico", 900));

            Computadora gamaMedia = new Computadora("PC Gama Media");
            gamaMedia.AgregarHijo(new Pieza("Procesador Ryzen 5", 3200));
            gamaMedia.AgregarHijo(new Pieza("Tarjeta Madre B450", 1800));
            gamaMedia.AgregarHijo(new Pieza("RAM 16GB", 1400));
            gamaMedia.AgregarHijo(new Pieza("SSD 480GB", 1000));
            gamaMedia.AgregarHijo(new Pieza("Tarjeta Gráfica GTX 1660", 4500));
            gamaMedia.AgregarHijo(new Pieza("Fuente de Poder 600W", 1200));
            gamaMedia.AgregarHijo(new Pieza("Gabinete Gamer", 1500));

            Computadora gamaAlta = new Computadora("PC Gama Alta");
            gamaAlta.AgregarHijo(new Pieza("Procesador Ryzen 7", 6500));
            gamaAlta.AgregarHijo(new Pieza("Tarjeta Madre X570", 3500));
            gamaAlta.AgregarHijo(new Pieza("RAM 32GB", 2800));
            gamaAlta.AgregarHijo(new Pieza("SSD 1TB NVMe", 2200));
            gamaAlta.AgregarHijo(new Pieza("Tarjeta Gráfica RTX 4070", 14000));
            gamaAlta.AgregarHijo(new Pieza("Fuente de Poder 750W", 1800));
            gamaAlta.AgregarHijo(new Pieza("Gabinete Premium", 2500));
            gamaAlta.AgregarHijo(new Pieza("Refrigeración Líquida", 3000));

            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU ARMADO DE COMPUTADORAS =====");
                Console.WriteLine("1. Ver PC Gama Baja");
                Console.WriteLine("2. Ver PC Gama Media");
                Console.WriteLine("3. Ver PC Gama Alta");
                Console.WriteLine("4. Ver todas las computadoras");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                string entrada = Console.ReadLine();
                int.TryParse(entrada, out opcion);

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        MostrarComputadora(gamaBaja);
                        break;

                    case 2:
                        MostrarComputadora(gamaMedia);
                        break;

                    case 3:
                        MostrarComputadora(gamaAlta);
                        break;

                    case 4:
                        MostrarComputadora(gamaBaja);
                        Console.WriteLine();
                        MostrarComputadora(gamaMedia);
                        Console.WriteLine();
                        MostrarComputadora(gamaAlta);
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Presiona una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }

        static void MostrarComputadora(Computadora pc)
        {
            Console.WriteLine("======================================");
            Console.WriteLine(pc.Nombre);
            Console.WriteLine("======================================");

            foreach (Componente item in pc.ObtenerHijos())
            {
                Console.WriteLine("- " + item.Nombre + " -> $" + item.ObtenerCosto);
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Costo total: $" + pc.ObtenerCosto);
        }
    }
}
