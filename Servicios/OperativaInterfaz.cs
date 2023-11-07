using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Bucles.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método que calcula si el año introducido por el usuario es bisiesto o no.
        /// 061123 - ebp
        /// </summary>
        /// <param name="año"></param>
        /// <returns></returns>
        public bool CalcularAñoBisiesto(int año);
    }
}
