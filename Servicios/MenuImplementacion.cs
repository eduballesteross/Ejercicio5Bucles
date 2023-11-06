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
           

            Console.WriteLine("Introduzca el número equivalente al mes deseado: "); 
            numMes=Convert.ToInt32(Console.ReadLine());

            return numMes;  
            

        }
    }
}
