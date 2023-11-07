using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int PedirYMostrarAño()
        {
            int año;
            Console.WriteLine("Introduzca el año deseado: ");
            año = Convert.ToInt32(Console.ReadLine());
            return año;
        }

        public int PedirYMostrarMes()
        {

            int numMes;
            int opcionMinima = 1;
            int opcionMaxima = 12;


            do
            {
                Console.WriteLine("Ingrese un número equivalente al mes deseado: ");


                if (int.TryParse(Console.ReadLine(), out numMes) && numMes >= opcionMinima && numMes <= opcionMaxima)
                {
                    return numMes;
                }

                else
                {
                    Console.WriteLine("Opción no válida. Intentelo de nuevo.");

                }
            }

            while (true); 

              




        }
    }
}
